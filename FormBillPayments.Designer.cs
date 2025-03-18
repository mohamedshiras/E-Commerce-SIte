namespace CourseWork
{
    partial class FormBillPayments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBillPayments));
            this.ComboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxBillNo = new System.Windows.Forms.TextBox();
            this.TextBoxPaymentAmount = new System.Windows.Forms.TextBox();
            this.ButtonSubmitPayment = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxPaymentType
            // 
            this.ComboBoxPaymentType.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPaymentType.FormattingEnabled = true;
            this.ComboBoxPaymentType.Items.AddRange(new object[] {
            "--Select--",
            "Water Bill",
            "Electricity",
            "Dialog Broadband",
            "Creadit Card Payments"});
            this.ComboBoxPaymentType.Location = new System.Drawing.Point(328, 99);
            this.ComboBoxPaymentType.Name = "ComboBoxPaymentType";
            this.ComboBoxPaymentType.Size = new System.Drawing.Size(189, 35);
            this.ComboBoxPaymentType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(322, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(309, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paying Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(333, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bill Number";
            // 
            // TextBoxBillNo
            // 
            this.TextBoxBillNo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBillNo.Location = new System.Drawing.Point(328, 221);
            this.TextBoxBillNo.Name = "TextBoxBillNo";
            this.TextBoxBillNo.Size = new System.Drawing.Size(190, 34);
            this.TextBoxBillNo.TabIndex = 4;
            // 
            // TextBoxPaymentAmount
            // 
            this.TextBoxPaymentAmount.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPaymentAmount.Location = new System.Drawing.Point(327, 344);
            this.TextBoxPaymentAmount.Name = "TextBoxPaymentAmount";
            this.TextBoxPaymentAmount.Size = new System.Drawing.Size(190, 34);
            this.TextBoxPaymentAmount.TabIndex = 5;
            // 
            // ButtonSubmitPayment
            // 
            this.ButtonSubmitPayment.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmitPayment.Location = new System.Drawing.Point(260, 415);
            this.ButtonSubmitPayment.Name = "ButtonSubmitPayment";
            this.ButtonSubmitPayment.Size = new System.Drawing.Size(94, 42);
            this.ButtonSubmitPayment.TabIndex = 6;
            this.ButtonSubmitPayment.Text = "Pay";
            this.ButtonSubmitPayment.UseVisualStyleBackColor = true;
            this.ButtonSubmitPayment.Click += new System.EventHandler(this.ButtonSubmitPayment_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.Location = new System.Drawing.Point(373, 415);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(94, 42);
            this.ButtonClear.TabIndex = 7;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(485, 415);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(94, 42);
            this.ButtonExit.TabIndex = 8;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FormBillPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(862, 523);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonSubmitPayment);
            this.Controls.Add(this.TextBoxPaymentAmount);
            this.Controls.Add(this.TextBoxBillNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxPaymentType);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormBillPayments";
            this.Text = "FormBillPayments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxPaymentType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxBillNo;
        private System.Windows.Forms.TextBox TextBoxPaymentAmount;
        private System.Windows.Forms.Button ButtonSubmitPayment;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonExit;
    }
}