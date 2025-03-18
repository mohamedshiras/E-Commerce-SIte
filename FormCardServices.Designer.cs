namespace CourseWork
{
    partial class FormCardServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCardServices));
            this.ButtonWIthdrawal = new System.Windows.Forms.Button();
            this.ButtonChangePin = new System.Windows.Forms.Button();
            this.ButtonCheckBalance = new System.Windows.Forms.Button();
            this.ButtonBillPayments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonWIthdrawal
            // 
            this.ButtonWIthdrawal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonWIthdrawal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonWIthdrawal.Location = new System.Drawing.Point(540, 148);
            this.ButtonWIthdrawal.Name = "ButtonWIthdrawal";
            this.ButtonWIthdrawal.Size = new System.Drawing.Size(260, 48);
            this.ButtonWIthdrawal.TabIndex = 0;
            this.ButtonWIthdrawal.Text = "Withdraw";
            this.ButtonWIthdrawal.UseVisualStyleBackColor = true;
            this.ButtonWIthdrawal.Click += new System.EventHandler(this.ButtonWIthdrawal_Click);
            // 
            // ButtonChangePin
            // 
            this.ButtonChangePin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChangePin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonChangePin.Location = new System.Drawing.Point(540, 333);
            this.ButtonChangePin.Name = "ButtonChangePin";
            this.ButtonChangePin.Size = new System.Drawing.Size(260, 48);
            this.ButtonChangePin.TabIndex = 2;
            this.ButtonChangePin.Text = "Change PIN";
            this.ButtonChangePin.UseVisualStyleBackColor = true;
            this.ButtonChangePin.Click += new System.EventHandler(this.ButtonChangePin_Click);
            // 
            // ButtonCheckBalance
            // 
            this.ButtonCheckBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCheckBalance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCheckBalance.Location = new System.Drawing.Point(540, 242);
            this.ButtonCheckBalance.Name = "ButtonCheckBalance";
            this.ButtonCheckBalance.Size = new System.Drawing.Size(260, 48);
            this.ButtonCheckBalance.TabIndex = 3;
            this.ButtonCheckBalance.Text = "Check Balance";
            this.ButtonCheckBalance.UseVisualStyleBackColor = true;
            this.ButtonCheckBalance.Click += new System.EventHandler(this.ButtonCheckBalance_Click);
            // 
            // ButtonBillPayments
            // 
            this.ButtonBillPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBillPayments.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBillPayments.Location = new System.Drawing.Point(70, 148);
            this.ButtonBillPayments.Name = "ButtonBillPayments";
            this.ButtonBillPayments.Size = new System.Drawing.Size(232, 48);
            this.ButtonBillPayments.TabIndex = 4;
            this.ButtonBillPayments.Text = "Bill Payments";
            this.ButtonBillPayments.UseVisualStyleBackColor = true;
            this.ButtonBillPayments.Click += new System.EventHandler(this.ButtonBillPayments_Click);
            // 
            // FormCardServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 486);
            this.Controls.Add(this.ButtonBillPayments);
            this.Controls.Add(this.ButtonCheckBalance);
            this.Controls.Add(this.ButtonChangePin);
            this.Controls.Add(this.ButtonWIthdrawal);
            this.Name = "FormCardServices";
            this.Text = "Card Services";
            this.Load += new System.EventHandler(this.FormCardServices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonWIthdrawal;
        private System.Windows.Forms.Button ButtonChangePin;
        private System.Windows.Forms.Button ButtonCheckBalance;
        private System.Windows.Forms.Button ButtonBillPayments;
    }
}