namespace CourseWork
{
    partial class FormWelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcomePage));
            this.PanelWelcome = new System.Windows.Forms.Panel();
            this.ButtonForDeposit = new System.Windows.Forms.Button();
            this.ButtonForWithdrawal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelWelcome
            // 
            this.PanelWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelWelcome.BackgroundImage")));
            this.PanelWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelWelcome.Controls.Add(this.ButtonForDeposit);
            this.PanelWelcome.Controls.Add(this.ButtonForWithdrawal);
            this.PanelWelcome.Controls.Add(this.label1);
            this.PanelWelcome.Location = new System.Drawing.Point(1, -1);
            this.PanelWelcome.Name = "PanelWelcome";
            this.PanelWelcome.Size = new System.Drawing.Size(927, 530);
            this.PanelWelcome.TabIndex = 0;
            this.PanelWelcome.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelWelcome_Paint);
            // 
            // ButtonForDeposit
            // 
            this.ButtonForDeposit.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonForDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonForDeposit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonForDeposit.ForeColor = System.Drawing.Color.Black;
            this.ButtonForDeposit.Location = new System.Drawing.Point(201, 289);
            this.ButtonForDeposit.Name = "ButtonForDeposit";
            this.ButtonForDeposit.Size = new System.Drawing.Size(210, 67);
            this.ButtonForDeposit.TabIndex = 2;
            this.ButtonForDeposit.Text = "Deposit Money";
            this.ButtonForDeposit.UseVisualStyleBackColor = false;
            this.ButtonForDeposit.Click += new System.EventHandler(this.ButtonForDeposit_Click);
            // 
            // ButtonForWithdrawal
            // 
            this.ButtonForWithdrawal.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonForWithdrawal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonForWithdrawal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonForWithdrawal.ForeColor = System.Drawing.Color.Black;
            this.ButtonForWithdrawal.Location = new System.Drawing.Point(501, 289);
            this.ButtonForWithdrawal.Name = "ButtonForWithdrawal";
            this.ButtonForWithdrawal.Size = new System.Drawing.Size(210, 67);
            this.ButtonForWithdrawal.TabIndex = 1;
            this.ButtonForWithdrawal.Text = "Card Services ";
            this.ButtonForWithdrawal.UseVisualStyleBackColor = false;
            this.ButtonForWithdrawal.Click += new System.EventHandler(this.ButtonForWithdrawal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(252, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIBM COM BANKING";
            // 
            // FormWelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 499);
            this.Controls.Add(this.PanelWelcome);
            this.Name = "FormWelcomePage";
            this.Text = "Welcome to NIBM COM BANK";
            this.PanelWelcome.ResumeLayout(false);
            this.PanelWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelWelcome;
        private System.Windows.Forms.Button ButtonForDeposit;
        private System.Windows.Forms.Button ButtonForWithdrawal;
        private System.Windows.Forms.Label label1;
    }
}

