namespace Receipt
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.NewLineGBox = new System.Windows.Forms.GroupBox();
            this.PriceUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.countUpDown = new System.Windows.Forms.NumericUpDown();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.ShowDetail = new System.Windows.Forms.Button();
            this.Accounts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.NewLineGBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rowCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddPerson = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteRow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentUsername = new System.Windows.Forms.Label();
            this.NewLineGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).BeginInit();
            this.NewLineGBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewLineGBox
            // 
            this.NewLineGBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewLineGBox.Controls.Add(this.PriceUpDown2);
            this.NewLineGBox.Controls.Add(this.countUpDown);
            this.NewLineGBox.Controls.Add(this.SubjectTextBox);
            this.NewLineGBox.Controls.Add(this.ShowDetail);
            this.NewLineGBox.Controls.Add(this.Accounts);
            this.NewLineGBox.Controls.Add(this.label3);
            this.NewLineGBox.Controls.Add(this.count);
            this.NewLineGBox.Controls.Add(this.label4);
            this.NewLineGBox.Controls.Add(this.Subject);
            this.NewLineGBox.Location = new System.Drawing.Point(41, 81);
            this.NewLineGBox.Name = "NewLineGBox";
            this.NewLineGBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewLineGBox.Size = new System.Drawing.Size(896, 122);
            this.NewLineGBox.TabIndex = 0;
            this.NewLineGBox.TabStop = false;
            this.NewLineGBox.Text = "سطر جدید";
            this.NewLineGBox.Enter += new System.EventHandler(this.NewLineGBox_Enter);
            // 
            // PriceUpDown2
            // 
            this.PriceUpDown2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PriceUpDown2.Location = new System.Drawing.Point(451, 78);
            this.PriceUpDown2.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.PriceUpDown2.Name = "PriceUpDown2";
            this.PriceUpDown2.Size = new System.Drawing.Size(370, 20);
            this.PriceUpDown2.TabIndex = 5;
            // 
            // countUpDown
            // 
            this.countUpDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.countUpDown.Location = new System.Drawing.Point(451, 49);
            this.countUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.countUpDown.Name = "countUpDown";
            this.countUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.countUpDown.Size = new System.Drawing.Size(370, 20);
            this.countUpDown.TabIndex = 5;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SubjectTextBox.Location = new System.Drawing.Point(451, 25);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(370, 20);
            this.SubjectTextBox.TabIndex = 4;
            // 
            // ShowDetail
            // 
            this.ShowDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ShowDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDetail.Image = ((System.Drawing.Image)(resources.GetObject("ShowDetail.Image")));
            this.ShowDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowDetail.Location = new System.Drawing.Point(25, 49);
            this.ShowDetail.Name = "ShowDetail";
            this.ShowDetail.Size = new System.Drawing.Size(108, 49);
            this.ShowDetail.TabIndex = 3;
            this.ShowDetail.Text = "اتخاب";
            this.ShowDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowDetail.UseVisualStyleBackColor = true;
            this.ShowDetail.Click += new System.EventHandler(this.ShowDetail_Click);
            // 
            // Accounts
            // 
            this.Accounts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Accounts.FormattingEnabled = true;
            this.Accounts.Location = new System.Drawing.Point(25, 25);
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(188, 21);
            this.Accounts.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(840, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "قیمت :";
            // 
            // count
            // 
            this.count.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(840, 57);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(43, 13);
            this.count.TabIndex = 0;
            this.count.Text = "تعداد :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "صورت حساب :";
            // 
            // Subject
            // 
            this.Subject.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Subject.AutoSize = true;
            this.Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.Location = new System.Drawing.Point(837, 28);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(53, 13);
            this.Subject.TabIndex = 0;
            this.Subject.Text = "موضوع :";
            // 
            // NewLineGBox2
            // 
            this.NewLineGBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewLineGBox2.Controls.Add(this.dataGridView1);
            this.NewLineGBox2.Location = new System.Drawing.Point(41, 209);
            this.NewLineGBox2.Name = "NewLineGBox2";
            this.NewLineGBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewLineGBox2.Size = new System.Drawing.Size(896, 305);
            this.NewLineGBox2.TabIndex = 1;
            this.NewLineGBox2.TabStop = false;
            this.NewLineGBox2.Text = "اطلاعات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowCol,
            this.subjectCol,
            this.countCol,
            this.priceCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rowCol
            // 
            this.rowCol.HeaderText = "ردیف";
            this.rowCol.Name = "rowCol";
            this.rowCol.ReadOnly = true;
            this.rowCol.Width = 60;
            // 
            // subjectCol
            // 
            this.subjectCol.HeaderText = "موضوع";
            this.subjectCol.Name = "subjectCol";
            this.subjectCol.ReadOnly = true;
            this.subjectCol.Width = 400;
            // 
            // countCol
            // 
            this.countCol.HeaderText = "تعداد";
            this.countCol.Name = "countCol";
            this.countCol.ReadOnly = true;
            // 
            // priceCol
            // 
            this.priceCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceCol.HeaderText = "قیمت";
            this.priceCol.Name = "priceCol";
            this.priceCol.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AddPerson
            // 
            this.AddPerson.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPerson.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPerson.Image = ((System.Drawing.Image)(resources.GetObject("AddPerson.Image")));
            this.AddPerson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddPerson.Location = new System.Drawing.Point(787, 3);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(103, 75);
            this.AddPerson.TabIndex = 3;
            this.AddPerson.Text = "افزودن شخص جدید";
            this.AddPerson.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // AddItem
            // 
            this.AddItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Image = ((System.Drawing.Image)(resources.GetObject("AddItem.Image")));
            this.AddItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddItem.Location = new System.Drawing.Point(684, 3);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(97, 75);
            this.AddItem.TabIndex = 3;
            this.AddItem.Text = "افزودن مورد جدید";
            this.AddItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddItem.UseMnemonic = false;
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CurrentUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DeleteRow);
            this.panel1.Controls.Add(this.AddPerson);
            this.panel1.Controls.Add(this.AddItem);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(41, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 81);
            this.panel1.TabIndex = 4;
            // 
            // DeleteRow
            // 
            this.DeleteRow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DeleteRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteRow.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRow.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRow.Image")));
            this.DeleteRow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteRow.Location = new System.Drawing.Point(612, 4);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(66, 74);
            this.DeleteRow.TabIndex = 4;
            this.DeleteRow.Text = "حذف مورد";
            this.DeleteRow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteRow.UseVisualStyleBackColor = true;
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "User :";
            // 
            // CurrentUsername
            // 
            this.CurrentUsername.AutoSize = true;
            this.CurrentUsername.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUsername.ForeColor = System.Drawing.Color.Red;
            this.CurrentUsername.Location = new System.Drawing.Point(95, 15);
            this.CurrentUsername.Name = "CurrentUsername";
            this.CurrentUsername.Size = new System.Drawing.Size(118, 36);
            this.CurrentUsername.TabIndex = 6;
            this.CurrentUsername.Text = "username";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(975, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NewLineGBox2);
            this.Controls.Add(this.NewLineGBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.NewLineGBox.ResumeLayout(false);
            this.NewLineGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).EndInit();
            this.NewLineGBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewLineGBox;
        private System.Windows.Forms.GroupBox NewLineGBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Button ShowDetail;
        private System.Windows.Forms.ComboBox Accounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown PriceUpDown2;
        private System.Windows.Forms.NumericUpDown countUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn countCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.Button DeleteRow;
        private System.Windows.Forms.Label CurrentUsername;
        private System.Windows.Forms.Label label1;
    }
}