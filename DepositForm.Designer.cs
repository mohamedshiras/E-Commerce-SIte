namespace CourseWork
{
    partial class DepositForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxNIC = new System.Windows.Forms.TextBox();
            this.TextBoxMobileNumber = new System.Windows.Forms.TextBox();
            this.ButtonDespositDetailsSubmit = new System.Windows.Forms.Button();
            this.ButtonDepositDetailsClear = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.TextBoxAccNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(342, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(421, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(345, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mobile Number";
            // 
            // TextBoxNIC
            // 
            this.TextBoxNIC.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNIC.Location = new System.Drawing.Point(326, 201);
            this.TextBoxNIC.Name = "TextBoxNIC";
            this.TextBoxNIC.Size = new System.Drawing.Size(268, 39);
            this.TextBoxNIC.TabIndex = 4;
            // 
            // TextBoxMobileNumber
            // 
            this.TextBoxMobileNumber.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMobileNumber.Location = new System.Drawing.Point(338, 339);
            this.TextBoxMobileNumber.Name = "TextBoxMobileNumber";
            this.TextBoxMobileNumber.Size = new System.Drawing.Size(242, 39);
            this.TextBoxMobileNumber.TabIndex = 5;
            // 
            // ButtonDespositDetailsSubmit
            // 
            this.ButtonDespositDetailsSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonDespositDetailsSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDespositDetailsSubmit.ForeColor = System.Drawing.Color.Black;
            this.ButtonDespositDetailsSubmit.Location = new System.Drawing.Point(282, 423);
            this.ButtonDespositDetailsSubmit.Name = "ButtonDespositDetailsSubmit";
            this.ButtonDespositDetailsSubmit.Size = new System.Drawing.Size(92, 38);
            this.ButtonDespositDetailsSubmit.TabIndex = 6;
            this.ButtonDespositDetailsSubmit.Text = "Enter";
            this.ButtonDespositDetailsSubmit.UseVisualStyleBackColor = false;
            this.ButtonDespositDetailsSubmit.Click += new System.EventHandler(this.ButtonDespositDetailsSubmit_Click);
            // 
            // ButtonDepositDetailsClear
            // 
            this.ButtonDepositDetailsClear.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonDepositDetailsClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDepositDetailsClear.ForeColor = System.Drawing.Color.Black;
            this.ButtonDepositDetailsClear.Location = new System.Drawing.Point(407, 423);
            this.ButtonDepositDetailsClear.Name = "ButtonDepositDetailsClear";
            this.ButtonDepositDetailsClear.Size = new System.Drawing.Size(92, 38);
            this.ButtonDepositDetailsClear.TabIndex = 7;
            this.ButtonDepositDetailsClear.Text = "Clear";
            this.ButtonDepositDetailsClear.UseVisualStyleBackColor = false;
            this.ButtonDepositDetailsClear.Click += new System.EventHandler(this.ButtonDepositDetailsClear_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.ButtonCancel.Location = new System.Drawing.Point(535, 423);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(92, 38);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TextBoxAccNumber
            // 
            this.TextBoxAccNumber.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAccNumber.Location = new System.Drawing.Point(326, 92);
            this.TextBoxAccNumber.Name = "TextBoxAccNumber";
            this.TextBoxAccNumber.Size = new System.Drawing.Size(268, 39);
            this.TextBoxAccNumber.TabIndex = 3;
            this.TextBoxAccNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(920, 520);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonDepositDetailsClear);
            this.Controls.Add(this.ButtonDespositDetailsSubmit);
            this.Controls.Add(this.TextBoxMobileNumber);
            this.Controls.Add(this.TextBoxNIC);
            this.Controls.Add(this.TextBoxAccNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "DepositForm";
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxNIC;
        private System.Windows.Forms.TextBox TextBoxMobileNumber;
        private System.Windows.Forms.Button ButtonDespositDetailsSubmit;
        private System.Windows.Forms.Button ButtonDepositDetailsClear;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox TextBoxAccNumber;
    }
}