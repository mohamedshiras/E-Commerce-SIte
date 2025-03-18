namespace CourseWork
{
    partial class FormChangePin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePin));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonDetailsClear = new System.Windows.Forms.Button();
            this.ButtonSubmitPinChange = new System.Windows.Forms.Button();
            this.TextBoxConfirmNewPin = new System.Windows.Forms.TextBox();
            this.TextBoxNewPin = new System.Windows.Forms.TextBox();
            this.TextBoxCurrentPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.ButtonCancel.Location = new System.Drawing.Point(521, 428);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(92, 38);
            this.ButtonCancel.TabIndex = 17;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonDetailsClear
            // 
            this.ButtonDetailsClear.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonDetailsClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDetailsClear.ForeColor = System.Drawing.Color.Black;
            this.ButtonDetailsClear.Location = new System.Drawing.Point(393, 428);
            this.ButtonDetailsClear.Name = "ButtonDetailsClear";
            this.ButtonDetailsClear.Size = new System.Drawing.Size(92, 38);
            this.ButtonDetailsClear.TabIndex = 16;
            this.ButtonDetailsClear.Text = "Clear";
            this.ButtonDetailsClear.UseVisualStyleBackColor = false;
            this.ButtonDetailsClear.Click += new System.EventHandler(this.ButtonDetailsClear_Click);
            // 
            // ButtonSubmitPinChange
            // 
            this.ButtonSubmitPinChange.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonSubmitPinChange.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmitPinChange.ForeColor = System.Drawing.Color.Black;
            this.ButtonSubmitPinChange.Location = new System.Drawing.Point(260, 428);
            this.ButtonSubmitPinChange.Name = "ButtonSubmitPinChange";
            this.ButtonSubmitPinChange.Size = new System.Drawing.Size(100, 38);
            this.ButtonSubmitPinChange.TabIndex = 15;
            this.ButtonSubmitPinChange.Text = "Change";
            this.ButtonSubmitPinChange.UseVisualStyleBackColor = false;
            this.ButtonSubmitPinChange.Click += new System.EventHandler(this.ButtonSubmitPinChange_Click);
            // 
            // TextBoxConfirmNewPin
            // 
            this.TextBoxConfirmNewPin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxConfirmNewPin.Location = new System.Drawing.Point(313, 327);
            this.TextBoxConfirmNewPin.Name = "TextBoxConfirmNewPin";
            this.TextBoxConfirmNewPin.Size = new System.Drawing.Size(242, 39);
            this.TextBoxConfirmNewPin.TabIndex = 14;
            // 
            // TextBoxNewPin
            // 
            this.TextBoxNewPin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNewPin.Location = new System.Drawing.Point(305, 212);
            this.TextBoxNewPin.Name = "TextBoxNewPin";
            this.TextBoxNewPin.Size = new System.Drawing.Size(268, 39);
            this.TextBoxNewPin.TabIndex = 13;
            // 
            // TextBoxCurrentPin
            // 
            this.TextBoxCurrentPin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCurrentPin.Location = new System.Drawing.Point(301, 80);
            this.TextBoxCurrentPin.Name = "TextBoxCurrentPin";
            this.TextBoxCurrentPin.Size = new System.Drawing.Size(268, 39);
            this.TextBoxCurrentPin.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(307, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Re-Enter New PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(361, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "New PIN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(350, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Pin";
            // 
            // FormChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(853, 516);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonDetailsClear);
            this.Controls.Add(this.ButtonSubmitPinChange);
            this.Controls.Add(this.TextBoxConfirmNewPin);
            this.Controls.Add(this.TextBoxNewPin);
            this.Controls.Add(this.TextBoxCurrentPin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangePin";
            this.Text = "FormChangePin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonDetailsClear;
        private System.Windows.Forms.Button ButtonSubmitPinChange;
        private System.Windows.Forms.TextBox TextBoxConfirmNewPin;
        private System.Windows.Forms.TextBox TextBoxNewPin;
        private System.Windows.Forms.TextBox TextBoxCurrentPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}