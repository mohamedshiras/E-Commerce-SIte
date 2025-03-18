namespace CourseWork
{
    partial class FormWithdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWithdraw));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonWithdrawAmountClear = new System.Windows.Forms.Button();
            this.ButtonWithdrawAmountSubmit = new System.Windows.Forms.Button();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.ButtonCancel.Location = new System.Drawing.Point(525, 309);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(92, 38);
            this.ButtonCancel.TabIndex = 16;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonWithdrawAmountClear
            // 
            this.ButtonWithdrawAmountClear.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonWithdrawAmountClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonWithdrawAmountClear.ForeColor = System.Drawing.Color.Black;
            this.ButtonWithdrawAmountClear.Location = new System.Drawing.Point(397, 309);
            this.ButtonWithdrawAmountClear.Name = "ButtonWithdrawAmountClear";
            this.ButtonWithdrawAmountClear.Size = new System.Drawing.Size(92, 38);
            this.ButtonWithdrawAmountClear.TabIndex = 15;
            this.ButtonWithdrawAmountClear.Text = "Clear";
            this.ButtonWithdrawAmountClear.UseVisualStyleBackColor = false;
            this.ButtonWithdrawAmountClear.Click += new System.EventHandler(this.ButtonWithdrawAmountClear_Click);
            // 
            // ButtonWithdrawAmountSubmit
            // 
            this.ButtonWithdrawAmountSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonWithdrawAmountSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonWithdrawAmountSubmit.ForeColor = System.Drawing.Color.Black;
            this.ButtonWithdrawAmountSubmit.Location = new System.Drawing.Point(272, 309);
            this.ButtonWithdrawAmountSubmit.Name = "ButtonWithdrawAmountSubmit";
            this.ButtonWithdrawAmountSubmit.Size = new System.Drawing.Size(92, 38);
            this.ButtonWithdrawAmountSubmit.TabIndex = 14;
            this.ButtonWithdrawAmountSubmit.Text = "Enter";
            this.ButtonWithdrawAmountSubmit.UseVisualStyleBackColor = false;
            this.ButtonWithdrawAmountSubmit.Click += new System.EventHandler(this.ButtonWithdrawAmountSubmit_Click);
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.Location = new System.Drawing.Point(307, 228);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.Size = new System.Drawing.Size(281, 39);
            this.TextBoxAmount.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(309, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Withdrawal Amount";
            // 
            // FormWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(902, 524);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonWithdrawAmountClear);
            this.Controls.Add(this.ButtonWithdrawAmountSubmit);
            this.Controls.Add(this.TextBoxAmount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormWithdraw";
            this.Text = "FormWithdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonWithdrawAmountClear;
        private System.Windows.Forms.Button ButtonWithdrawAmountSubmit;
        private System.Windows.Forms.TextBox TextBoxAmount;
        private System.Windows.Forms.Label label1;
    }
}