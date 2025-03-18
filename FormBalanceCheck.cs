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
    public partial class FormBalanceCheck : Form
    {
        public int CardholderId { get; set; }
        public FormBalanceCheck()
        {
            InitializeComponent();
            this.Load += FormBalanceCheck_Load;
        }
        

        private void FormBalanceCheck_Load(object sender, EventArgs e)
        {
            try
            {
                DataBaseConnection con = new DataBaseConnection();

                string selectSql = "SELECT amount FROM cardholder WHERE cardholderid = @cardholderId";
                SqlCommand command = new SqlCommand(selectSql, con.DBcon());
                command.Parameters.AddWithValue("@cardholderId", CardholderId);

                object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out decimal balance))
                {
                    LabelBalanceDisplay.Text = $"Rs.{balance:F2}";
                }
                else
                {
                    LabelBalanceDisplay.Text = "Balance not found.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading balance: {ex.Message}");
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            FormWelcomePage form = new FormWelcomePage();
            form.ShowDialog();
            this.Close();
        }

        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            AutheticationForm form = new AutheticationForm();
            form.Show();
            this.Close();
        }
    }
}
