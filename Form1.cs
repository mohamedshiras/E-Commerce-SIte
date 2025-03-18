using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormWelcomePage : Form
    {
        public FormWelcomePage()
        {
            InitializeComponent();
        }

        private void ButtonForWithdrawal_Click(object sender, EventArgs e)
        {
            AutheticationForm autheticationForm = new AutheticationForm();
            autheticationForm.Show();
            this.Hide();
        }

        private void ButtonForDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm();
            depositForm.Show();
            this.Hide();
        }

        private void PanelWelcome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
