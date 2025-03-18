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
    public partial class FormBillPayments : Form
    {
        public int CardholderId { get; set; }
        public FormBillPayments()
        {
            InitializeComponent();
            ComboBoxPaymentType.SelectedIndex = 0;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ComboBoxPaymentType.SelectedIndex = 0;
            TextBoxBillNo.Text = string.Empty;
            TextBoxPaymentAmount.Text = string.Empty;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSubmitPayment_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseConnection con = new DataBaseConnection();

                if (!String.IsNullOrEmpty(TextBoxBillNo.Text) && !String.IsNullOrEmpty(TextBoxPaymentAmount.Text) && ComboBoxPaymentType.SelectedIndex > 0 )
                {
                    if (int.TryParse(TextBoxPaymentAmount.Text,out int paymentamount) && int.TryParse(TextBoxBillNo.Text,out int billno))
                    {
                        string BalanceSql = "SELECT amount FROM cardholder WHERE cardholderid = @cardholder";
                        SqlCommand BalanceCmd = new SqlCommand(BalanceSql, con.DBcon());
                        BalanceCmd.Parameters.AddWithValue("@cardholder", CardholderId);

                        int balance = (int)BalanceCmd.ExecuteScalar();

                        if (balance > paymentamount)
                        {
                            string type = ComboBoxPaymentType.SelectedItem.ToString();
                            string sql = "INSERT INTO payments (cardholderid, paymenttype, bilno, amount, paymentdate) VALUES (@cardholder,@type,@billno,@payamount,@paymentdate);";
                            SqlCommand cmd = new SqlCommand(sql, con.DBcon());
                            cmd.Parameters.AddWithValue("@cardholder", CardholderId);
                            cmd.Parameters.AddWithValue("@type", type);
                            cmd.Parameters.AddWithValue("@billno", billno);
                            cmd.Parameters.AddWithValue("@payamount", paymentamount);
                            cmd.Parameters.AddWithValue("@paymentdate", DateTime.Now);
                            cmd.ExecuteNonQuery();

                            string updatesql = "UPDATE cardholder SET amount = amount - @payamount WHERE cardholderid = @cardholder";
                            SqlCommand updateCmd = new SqlCommand(updatesql, con.DBcon());
                            updateCmd.Parameters.AddWithValue("@payamount", paymentamount);
                            updateCmd.Parameters.AddWithValue("@cardholder", CardholderId);
                            updateCmd.ExecuteNonQuery();

                            FormBillPaymentReceipt formBillPaymentReceipt = new FormBillPaymentReceipt()
                            {
                                type = type,
                                amount = paymentamount,
                                billno = billno,
                            };
                            formBillPaymentReceipt.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No Sufficient Money to Make Payments");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insert Numeric Values");
                    }
                }
                else
                {
                    MessageBox.Show("Do not keep the fields empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
