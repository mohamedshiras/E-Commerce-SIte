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
    public partial class FormWithdraw : Form
    {
        public int CardholderId { get; set; }

        public FormWithdraw()
        {
            InitializeComponent();
        }

        private void ButtonWithdrawAmountSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(TextBoxAmount.Text, out int withdrawalAmount))
                {
                    DataBaseConnection con = new DataBaseConnection();
                    int cid = CardholderId;

                    string selectSql = "SELECT amount, accnumber, fullname FROM cardholder WHERE cardholderid = @cid";
                    SqlCommand selectCommand = new SqlCommand(selectSql, con.DBcon());
                    selectCommand.Parameters.AddWithValue("@cid", cid);

                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        int amount = reader.GetInt32(reader.GetOrdinal("amount"));
                        string accnumber = reader.GetString(reader.GetOrdinal("accnumber"));
                        string fullname = reader.GetString(reader.GetOrdinal("fullname"));
                        reader.Close();

                        if (amount >= withdrawalAmount)
                        {
                            int newAmount = amount - withdrawalAmount;

                            string insertTransactionSql = "INSERT INTO withdrawaltransactions (cardholderid, amount, transactiondate) VALUES (@cardholderId, @withdrawalAmount, @transactionDate)";
                            SqlCommand insertTransactionCommand = new SqlCommand(insertTransactionSql, con.DBcon());
                            insertTransactionCommand.Parameters.AddWithValue("@cardholderId", cid);
                            insertTransactionCommand.Parameters.AddWithValue("@withdrawalAmount", withdrawalAmount);
                            insertTransactionCommand.Parameters.AddWithValue("@transactionDate", DateTime.Now);

                            int rowsAffected = insertTransactionCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                string updateSql = "UPDATE cardholder SET amount = @newAmount WHERE cardholderid = @cid";
                                SqlCommand updateCommand = new SqlCommand(updateSql, con.DBcon());
                                updateCommand.Parameters.AddWithValue("@newAmount", newAmount);
                                updateCommand.Parameters.AddWithValue("@cid", cid);
                                updateCommand.ExecuteNonQuery();

                                FormReceipt formReceipt = new FormReceipt()
                                {
                                    AccountHolder = fullname,
                                    accnumber = accnumber,
                                    type = "Withdrawal",
                                    amount = withdrawalAmount
                                };

                                formReceipt.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Withdrawal failed.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Insufficient balance.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve account details.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid amount format.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void ButtonWithdrawAmountClear_Click(object sender, EventArgs e)
        {
            TextBoxAmount.Text = string.Empty;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            FormWelcomePage form = new FormWelcomePage();
            form.ShowDialog();
            this.Close();
        }
    }

}


