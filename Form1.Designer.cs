namespace Receipt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Result = new System.Windows.Forms.Label();
            this.CreatAccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Member Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(417, 104);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(187, 26);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(417, 142);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(187, 26);
            this.textBoxPassword.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Lime;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(417, 174);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(187, 32);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Red;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(417, 212);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(187, 32);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Red;
            this.Result.Location = new System.Drawing.Point(424, 72);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 15);
            this.Result.TabIndex = 4;
            // 
            // CreatAccount
            // 
            this.CreatAccount.BackColor = System.Drawing.Color.Transparent;
            this.CreatAccount.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.CreatAccount.FlatAppearance.BorderSize = 0;
            this.CreatAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatAccount.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatAccount.ForeColor = System.Drawing.Color.DeepPink;
            this.CreatAccount.Location = new System.Drawing.Point(404, 267);
            this.CreatAccount.Name = "CreatAccount";
            this.CreatAccount.Size = new System.Drawing.Size(214, 32);
            this.CreatAccount.TabIndex = 2;
            this.CreatAccount.Text = "Creat new account ";
            this.CreatAccount.UseVisualStyleBackColor = false;
            this.CreatAccount.Click += new System.EventHandler(this.CreatAccount_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(610, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 39);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.FlatAppearance.BorderSize = 0;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(0, 3);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(41, 39);
            this.info.TabIndex = 6;
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(653, 311);
            this.ControlBox = false;
            this.Controls.Add(this.info);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.CreatAccount);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button CreatAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button info;
    }
}

