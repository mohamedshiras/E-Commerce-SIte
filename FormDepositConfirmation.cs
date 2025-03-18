using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormDepositConfirmation : Form
    {
        public string accnumber { get; set; }
        public string holdername { get; set; }
        public string NIC { get; set; }
        public string MobileNumber { get; set; }
        public int depositamount { get; set; }

        public FormDepositConfirmation()
        {
            InitializeComponent();
        }

        private void FormDepositConfirmation_Load(object sender, EventArgs e)
        {  
            LabelAccHolderName.Text = holdername;
            LabelAccNo.Text = accnumber;
            LabelAmount.Text = depositamount.ToString();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseConnection con = new DataBaseConnection();

                string sql = @"SELECT cardholderid FROM cardholder WHERE accnumber = @accno";
                SqlCommand cmd = new SqlCommand(sql, con.DBcon());
                cmd.Parameters.AddWithValue("@accno", accnumber);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int id = (int)reader["cardholderid"];
                    reader.Close();

                    string insertSql = @"INSERT INTO DepositDetails (cardholderid, depositamount, nic, number) VALUES (@cardholderId, @depositAmount, @nic, @no)";
                    SqlCommand command = new SqlCommand(insertSql, con.DBcon());
                    command.Parameters.AddWithValue("@cardholderId", id);
                    command.Parameters.AddWithValue("@depositAmount", depositamount);
                    command.Parameters.AddWithValue("@nic", NIC);
                    command.Parameters.AddWithValue("@no", MobileNumber);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        string updateSql = @"UPDATE cardholder SET amount = amount + @depositAmount WHERE cardholderid = @cardholderId";
                        SqlCommand updateCommand = new SqlCommand(updateSql, con.DBcon());
                        updateCommand.Parameters.AddWithValue("@depositAmount", depositamount);
                        updateCommand.Parameters.AddWithValue("@cardholderId", id);

                        int updateRowsAffected = updateCommand.ExecuteNonQuery();

                        if (updateRowsAffected > 0)
                        {
                            FormReceipt receipt = new FormReceipt
                            {
                                AccountHolder = holdername,
                                accnumber = accnumber,
                                type = "Deposit",
                                amount = depositamount,
                            };

                            receipt.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("failed to update balance");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Faild to insert deposit record");
                    }
                }
                else
                {
                    MessageBox.Show("No matching Account number");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
