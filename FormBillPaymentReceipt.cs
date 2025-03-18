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
    public partial class FormBillPaymentReceipt : Form
    {
        public int amount {  get; set; }
        public int billno {  get; set; }
        public string type { get; set; }
        public FormBillPaymentReceipt()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormBillPaymentReceipt_Load(object sender, EventArgs e)
        {
            LabelAmount.Text = amount.ToString();
            LabelBillNo.Text = billno.ToString();
            LabelBillType.Text = type;
            LabelDateAndTime.Text = DateTime.Now.ToString();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormWelcomePage formWelcomePage = new FormWelcomePage();
            formWelcomePage.Show();
        }
    }
}
