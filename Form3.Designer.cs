namespace Receipt
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Save = new System.Windows.Forms.Button();
            this.FirstText = new System.Windows.Forms.TextBox();
            this.LastText = new System.Windows.Forms.TextBox();
            this.AdressText = new System.Windows.Forms.TextBox();
            this.itmebox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneNumText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itmebox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(389, 395);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(114, 48);
            this.Save.TabIndex = 0;
            this.Save.Text = "ثبت";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // FirstText
            // 
            this.FirstText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstText.Location = new System.Drawing.Point(67, 44);
            this.FirstText.Name = "FirstText";
            this.FirstText.Size = new System.Drawing.Size(320, 22);
            this.FirstText.TabIndex = 1;
            this.FirstText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastText
            // 
            this.LastText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastText.Location = new System.Drawing.Point(67, 78);
            this.LastText.Name = "LastText";
            this.LastText.Size = new System.Drawing.Size(320, 22);
            this.LastText.TabIndex = 1;
            // 
            // AdressText
            // 
            this.AdressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressText.Location = new System.Drawing.Point(67, 191);
            this.AdressText.Multiline = true;
            this.AdressText.Name = "AdressText";
            this.AdressText.Size = new System.Drawing.Size(320, 129);
            this.AdressText.TabIndex = 1;
            // 
            // itmebox1
            // 
            this.itmebox1.Controls.Add(this.label3);
            this.itmebox1.Controls.Add(this.label5);
            this.itmebox1.Controls.Add(this.label4);
            this.itmebox1.Controls.Add(this.label2);
            this.itmebox1.Controls.Add(this.label1);
            this.itmebox1.Controls.Add(this.FirstText);
            this.itmebox1.Controls.Add(this.AdressText);
            this.itmebox1.Controls.Add(this.MailTextBox);
            this.itmebox1.Controls.Add(this.PhoneNumText);
            this.itmebox1.Controls.Add(this.LastText);
            this.itmebox1.Location = new System.Drawing.Point(51, 25);
            this.itmebox1.Name = "itmebox1";
            this.itmebox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itmebox1.Size = new System.Drawing.Size(474, 354);
            this.itmebox1.TabIndex = 2;
            this.itmebox1.TabStop = false;
            this.itmebox1.Text = "اطلاعات فردی";
            this.itmebox1.Enter += new System.EventHandler(this.FirstText_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 194);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ادرس :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 81);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 47);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام :";
            // 
            // PhoneNumText
            // 
            this.PhoneNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumText.Location = new System.Drawing.Point(67, 113);
            this.PhoneNumText.Name = "PhoneNumText";
            this.PhoneNumText.Size = new System.Drawing.Size(320, 22);
            this.PhoneNumText.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 116);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "شماره تلفن :";
            // 
            // MailTextBox
            // 
            this.MailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailTextBox.Location = new System.Drawing.Point(67, 152);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(320, 22);
            this.MailTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 155);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ایمیل :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(559, 473);
            this.Controls.Add(this.itmebox1);
            this.Controls.Add(this.Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.itmebox1.ResumeLayout(false);
            this.itmebox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox FirstText;
        private System.Windows.Forms.TextBox LastText;
        private System.Windows.Forms.TextBox AdressText;
        private System.Windows.Forms.GroupBox itmebox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneNumText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MailTextBox;
    }
}