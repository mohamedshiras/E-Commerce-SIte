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
    public partial class FormReceipt : Form
    {
        public string AccountHolder {  get; set; }
        public string accnumber { get; set; }
        public string type { get; set; }
        public int amount { get; set; }
        public FormReceipt()
        {
            InitializeComponent();
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            LabelAccHolder.Text = AccountHolder;
            LabelAccNo.Text = accnumber;
            LabelTransactionType.Text = type;
            LabelAmount.Text = amount.ToString();
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

