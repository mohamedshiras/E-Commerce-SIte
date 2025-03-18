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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void ButtonDespositDetailsSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TextBoxAccNumber.Text) &&
                    !string.IsNullOrEmpty(TextBoxMobileNumber.Text) &&
                    !string.IsNullOrEmpty(TextBoxNIC.Text))
                {
                    DataBaseConnection con = new DataBaseConnection();

                    string sql = @"SELECT fullname FROM cardholder WHERE accnumber = @accno";
                    SqlCommand cmd = new SqlCommand(sql, con.DBcon());
                    cmd.Parameters.AddWithValue("@accno",TextBoxAccNumber.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string accountHolderName = reader["fullname"].ToString();
                        reader.Close();

                        FormDepositAmount formDepositAmount = new FormDepositAmount()
                        {
                            accnumber = TextBoxAccNumber.Text,
                            holdername = accountHolderName,
                            NIC = TextBoxNIC.Text,
                            MobileNumber = TextBoxMobileNumber.Text,
                        };
                        formDepositAmount.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all required fields.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            FormWelcomePage form = new FormWelcomePage();
            form.ShowDialog();
            this.Close();
        }

        private void ButtonDepositDetailsClear_Click(object sender, EventArgs e)
        {
            TextBoxAccNumber.Text = string.Empty;
            TextBoxMobileNumber.Text = string.Empty;
            TextBoxNIC.Text = string.Empty;
        }
    }
}
