using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AutheticationForm : Form
    {
        public static AutheticationForm instance;
        public int result;
        public AutheticationForm()
        {
            InitializeComponent();
        }

        private void ButtonCardDetailsSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseConnection connection = new DataBaseConnection();
                string enteredCardNumber = TextBoxCardNumber.Text;

                if (int.TryParse(TextBoxCardPin.Text, out int pin))
                {
                    string sql = "SELECT cardholderid FROM cardholder WHERE cardnumber = @cardNumber AND pin = @pin";

                    SqlCommand command = new SqlCommand(sql, connection.DBcon());
                    command.Parameters.AddWithValue("@cardNumber", enteredCardNumber);
                    command.Parameters.AddWithValue("@pin", pin);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        int cardholderId = Convert.ToInt32(result);

                        FormCardServices formCardServices = new FormCardServices
                        {
                            CardholderId = cardholderId
                        };
                        formCardServices.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid PIN format.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void ButtonCardDetailsClear_Click(object sender, EventArgs e)
        {
            TextBoxCardNumber.Text = string.Empty;
            TextBoxCardPin.Text = string.Empty;
        }

        private void ButtonCardDetailsCancel_Click(object sender, EventArgs e)
        {
            FormWelcomePage form = new FormWelcomePage();
            form.ShowDialog();
            this.Close();
        }
    }
}
