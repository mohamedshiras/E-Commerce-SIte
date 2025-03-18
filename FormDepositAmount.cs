using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormDepositAmount : Form
    {
        public string accnumber { get; set; }
        public string holdername { get; set; }
        public string NIC { get; set; }
        public string MobileNumber { get; set; }

        public FormDepositAmount()
        {
            InitializeComponent();
        }


        private void ButtonDepositAmountSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(TextboxDespositAmount.Text, out int depositAmount))
                {
                    FormDepositConfirmation formDepositConfirmation = new FormDepositConfirmation()
                    {
                        accnumber = accnumber,
                        holdername = holdername,
                        NIC = NIC,
                        MobileNumber = MobileNumber,
                        depositamount = depositAmount,
                    };
                    formDepositConfirmation.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid deposit amount.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void ButtonDepositAmountClear_Click(object sender, EventArgs e)
        {
            TextboxDespositAmount.Text = string.Empty;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            FormWelcomePage form = new FormWelcomePage();
            form.ShowDialog();
            this.Close();
        }
    }
}
