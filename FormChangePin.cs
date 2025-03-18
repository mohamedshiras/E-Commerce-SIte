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
    
    public partial class FormChangePin : Form
    {
        public int CardholderId { get; internal set; }

        public FormChangePin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSubmitPinChange_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseConnection con = new DataBaseConnection();

                string selectSql = "SELECT pin FROM cardholder WHERE cardholderid = @cardholderId";
                SqlCommand selectCommand = new SqlCommand(selectSql, con.DBcon());
                selectCommand.Parameters.AddWithValue("@cardholderId", CardholderId);

                object result = selectCommand.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int currentDatabasePin))
                {
                    if (currentDatabasePin == int.Parse(TextBoxCurrentPin.Text))
                    {
                        if (TextBoxNewPin.Text == TextBoxConfirmNewPin.Text)
                        {
                            if (int.TryParse(TextBoxNewPin.Text, out int newPin))
                            {
                                string updateSql = "UPDATE cardholder SET pin = @newPin WHERE cardholderid = @cardholderId";
                                SqlCommand updateCommand = new SqlCommand(updateSql, con.DBcon());
                                updateCommand.Parameters.AddWithValue("@newPin", newPin);
                                updateCommand.Parameters.AddWithValue("@cardholderId", CardholderId);

                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("PIN changed successfully.");
                                    this.Close();
                                    FormWelcomePage formWelcomePage = new FormWelcomePage();
                                    formWelcomePage.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to change PIN.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid format: Use numbers for the new PIN.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("New PIN and confirmation PIN do not match.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Current PIN is incorrect.");
                    }
                }
                else
                {
                    MessageBox.Show("Error retrieving current PIN.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            FormWelcomePage form = new FormWelcomePage();
            form.ShowDialog();
            this.Close();
        }

        private void ButtonDetailsClear_Click(object sender, EventArgs e)
        {
            TextBoxCurrentPin.Text = string.Empty;
            TextBoxNewPin.Text = string.Empty;
            TextBoxConfirmNewPin.Text = string.Empty;
        }
    }
}
