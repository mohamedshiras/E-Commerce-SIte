namespace CourseWork
{
    partial class FormDepositConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepositConfirmation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LabelAccNo = new System.Windows.Forms.Label();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.LabelAccHolderName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(188, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Holder         :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(186, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Number       :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(186, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 66);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount                      :\r\n\r\n";
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConfirm.ForeColor = System.Drawing.Color.Black;
            this.ButtonConfirm.Location = new System.Drawing.Point(291, 368);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(97, 41);
            this.ButtonConfirm.TabIndex = 3;
            this.ButtonConfirm.Text = "Confirm";
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.Black;
            this.ButtonExit.Location = new System.Drawing.Point(474, 368);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(90, 41);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Cancel";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // LabelAccNo
            // 
            this.LabelAccNo.AutoSize = true;
            this.LabelAccNo.BackColor = System.Drawing.Color.Transparent;
            this.LabelAccNo.ForeColor = System.Drawing.Color.White;
            this.LabelAccNo.Location = new System.Drawing.Point(587, 184);
            this.LabelAccNo.Name = "LabelAccNo";
            this.LabelAccNo.Size = new System.Drawing.Size(0, 33);
            this.LabelAccNo.TabIndex = 5;
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.BackColor = System.Drawing.Color.Transparent;
            this.LabelAmount.ForeColor = System.Drawing.Color.White;
            this.LabelAmount.Location = new System.Drawing.Point(587, 267);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(0, 33);
            this.LabelAmount.TabIndex = 6;
            // 
            // LabelAccHolderName
            // 
            this.LabelAccHolderName.AutoSize = true;
            this.LabelAccHolderName.BackColor = System.Drawing.Color.Transparent;
            this.LabelAccHolderName.ForeColor = System.Drawing.Color.White;
            this.LabelAccHolderName.Location = new System.Drawing.Point(587, 106);
            this.LabelAccHolderName.Name = "LabelAccHolderName";
            this.LabelAccHolderName.Size = new System.Drawing.Size(0, 33);
            this.LabelAccHolderName.TabIndex = 7;
            // 
            // FormDepositConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(887, 481);
            this.Controls.Add(this.LabelAccHolderName);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.LabelAccNo);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormDepositConfirmation";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.FormDepositConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label LabelAccNo;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.Label LabelAccHolderName;
    }
}