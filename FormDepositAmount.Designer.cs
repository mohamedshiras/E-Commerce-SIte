namespace CourseWork
{
    partial class FormDepositAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepositAmount));
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxDespositAmount = new System.Windows.Forms.TextBox();
            this.ButtonDepositAmountSubmit = new System.Windows.Forms.Button();
            this.ButtonDepositAmountClear = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(306, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deposit Amount";
            // 
            // TextboxDespositAmount
            // 
            this.TextboxDespositAmount.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxDespositAmount.Location = new System.Drawing.Point(305, 206);
            this.TextboxDespositAmount.Name = "TextboxDespositAmount";
            this.TextboxDespositAmount.Size = new System.Drawing.Size(230, 39);
            this.TextboxDespositAmount.TabIndex = 1;
            // 
            // ButtonDepositAmountSubmit
            // 
            this.ButtonDepositAmountSubmit.BackColor = System.Drawing.Color.White;
            this.ButtonDepositAmountSubmit.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDepositAmountSubmit.ForeColor = System.Drawing.Color.Black;
            this.ButtonDepositAmountSubmit.Location = new System.Drawing.Point(268, 294);
            this.ButtonDepositAmountSubmit.Name = "ButtonDepositAmountSubmit";
            this.ButtonDepositAmountSubmit.Size = new System.Drawing.Size(87, 35);
            this.ButtonDepositAmountSubmit.TabIndex = 2;
            this.ButtonDepositAmountSubmit.Text = "Enter";
            this.ButtonDepositAmountSubmit.UseVisualStyleBackColor = false;
            this.ButtonDepositAmountSubmit.Click += new System.EventHandler(this.ButtonDepositAmountSubmit_Click);
            // 
            // ButtonDepositAmountClear
            // 
            this.ButtonDepositAmountClear.BackColor = System.Drawing.Color.White;
            this.ButtonDepositAmountClear.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDepositAmountClear.ForeColor = System.Drawing.Color.Black;
            this.ButtonDepositAmountClear.Location = new System.Drawing.Point(377, 294);
            this.ButtonDepositAmountClear.Name = "ButtonDepositAmountClear";
            this.ButtonDepositAmountClear.Size = new System.Drawing.Size(87, 35);
            this.ButtonDepositAmountClear.TabIndex = 3;
            this.ButtonDepositAmountClear.Text = "Clear";
            this.ButtonDepositAmountClear.UseVisualStyleBackColor = false;
            this.ButtonDepositAmountClear.Click += new System.EventHandler(this.ButtonDepositAmountClear_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.White;
            this.ButtonCancel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.ButtonCancel.Location = new System.Drawing.Point(484, 294);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(87, 35);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormDepositAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(850, 506);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonDepositAmountClear);
            this.Controls.Add(this.ButtonDepositAmountSubmit);
            this.Controls.Add(this.TextboxDespositAmount);
            this.Controls.Add(this.label1);
            this.Name = "FormDepositAmount";
            this.Text = "FormDepositAmount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxDespositAmount;
        private System.Windows.Forms.Button ButtonDepositAmountSubmit;
        private System.Windows.Forms.Button ButtonDepositAmountClear;
        private System.Windows.Forms.Button ButtonCancel;
    }
}