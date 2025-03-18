namespace CourseWork
{
    partial class AutheticationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutheticationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCardNumber = new System.Windows.Forms.TextBox();
            this.TextBoxCardPin = new System.Windows.Forms.TextBox();
            this.ButtonCardDetailsSubmit = new System.Windows.Forms.Button();
            this.ButtonCardDetailsClear = new System.Windows.Forms.Button();
            this.ButtonCardDetailsCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(460, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(595, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "PIN";
            // 
            // TextBoxCardNumber
            // 
            this.TextBoxCardNumber.BackColor = System.Drawing.Color.White;
            this.TextBoxCardNumber.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCardNumber.Location = new System.Drawing.Point(466, 129);
            this.TextBoxCardNumber.Name = "TextBoxCardNumber";
            this.TextBoxCardNumber.Size = new System.Drawing.Size(336, 39);
            this.TextBoxCardNumber.TabIndex = 2;
            // 
            // TextBoxCardPin
            // 
            this.TextBoxCardPin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCardPin.Location = new System.Drawing.Point(522, 233);
            this.TextBoxCardPin.Name = "TextBoxCardPin";
            this.TextBoxCardPin.Size = new System.Drawing.Size(214, 39);
            this.TextBoxCardPin.TabIndex = 3;
            // 
            // ButtonCardDetailsSubmit
            // 
            this.ButtonCardDetailsSubmit.BackColor = System.Drawing.Color.White;
            this.ButtonCardDetailsSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCardDetailsSubmit.ForeColor = System.Drawing.Color.Black;
            this.ButtonCardDetailsSubmit.Location = new System.Drawing.Point(466, 339);
            this.ButtonCardDetailsSubmit.Name = "ButtonCardDetailsSubmit";
            this.ButtonCardDetailsSubmit.Size = new System.Drawing.Size(99, 41);
            this.ButtonCardDetailsSubmit.TabIndex = 4;
            this.ButtonCardDetailsSubmit.Text = "Enter";
            this.ButtonCardDetailsSubmit.UseVisualStyleBackColor = false;
            this.ButtonCardDetailsSubmit.Click += new System.EventHandler(this.ButtonCardDetailsSubmit_Click);
            // 
            // ButtonCardDetailsClear
            // 
            this.ButtonCardDetailsClear.BackColor = System.Drawing.Color.White;
            this.ButtonCardDetailsClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCardDetailsClear.ForeColor = System.Drawing.Color.Black;
            this.ButtonCardDetailsClear.Location = new System.Drawing.Point(588, 339);
            this.ButtonCardDetailsClear.Name = "ButtonCardDetailsClear";
            this.ButtonCardDetailsClear.Size = new System.Drawing.Size(95, 41);
            this.ButtonCardDetailsClear.TabIndex = 5;
            this.ButtonCardDetailsClear.Text = "Clear";
            this.ButtonCardDetailsClear.UseVisualStyleBackColor = false;
            this.ButtonCardDetailsClear.Click += new System.EventHandler(this.ButtonCardDetailsClear_Click);
            // 
            // ButtonCardDetailsCancel
            // 
            this.ButtonCardDetailsCancel.BackColor = System.Drawing.Color.White;
            this.ButtonCardDetailsCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCardDetailsCancel.ForeColor = System.Drawing.Color.Black;
            this.ButtonCardDetailsCancel.Location = new System.Drawing.Point(712, 339);
            this.ButtonCardDetailsCancel.Name = "ButtonCardDetailsCancel";
            this.ButtonCardDetailsCancel.Size = new System.Drawing.Size(101, 41);
            this.ButtonCardDetailsCancel.TabIndex = 6;
            this.ButtonCardDetailsCancel.Text = "Cancel";
            this.ButtonCardDetailsCancel.UseVisualStyleBackColor = false;
            this.ButtonCardDetailsCancel.Click += new System.EventHandler(this.ButtonCardDetailsCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(98, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 284);
            this.panel1.TabIndex = 7;
            // 
            // AutheticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(906, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonCardDetailsCancel);
            this.Controls.Add(this.ButtonCardDetailsClear);
            this.Controls.Add(this.ButtonCardDetailsSubmit);
            this.Controls.Add(this.TextBoxCardPin);
            this.Controls.Add(this.TextBoxCardNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "AutheticationForm";
            this.Text = "Authetication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCardNumber;
        private System.Windows.Forms.TextBox TextBoxCardPin;
        private System.Windows.Forms.Button ButtonCardDetailsSubmit;
        private System.Windows.Forms.Button ButtonCardDetailsClear;
        private System.Windows.Forms.Button ButtonCardDetailsCancel;
        private System.Windows.Forms.Panel panel1;
    }
}