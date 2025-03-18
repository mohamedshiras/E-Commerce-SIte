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
    public partial class FormCardServices : Form
    {
        public int CardholderId { get; set; }
        public FormCardServices()
        {
            InitializeComponent();
        }

        private void ButtonWIthdrawal_Click(object sender, EventArgs e)
        {
            try
            {
                FormWithdraw formWithdraw = new FormWithdraw
                {
                    CardholderId = this.CardholderId
                };
                formWithdraw.Show();
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCardServices_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCheckBalance_Click(object sender, EventArgs e)
        {
            try
            {
                FormBalanceCheck formBalanceCheck = new FormBalanceCheck
                {
                    CardholderId = this.CardholderId
                };
                formBalanceCheck.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonChangePin_Click(object sender, EventArgs e)
        {
            try
            {
                FormChangePin formChangePin = new FormChangePin
                {
                    CardholderId = this.CardholderId
                };

                formChangePin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonBillPayments_Click(object sender, EventArgs e)
        {
            FormBillPayments formBillPayments = new FormBillPayments()
            {
                CardholderId = this.CardholderId
            };
            formBillPayments.Show();
            this.Close();
        }
    }
}
