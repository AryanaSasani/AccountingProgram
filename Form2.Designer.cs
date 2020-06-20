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
            this.dateTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.LeftAmountUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.PayAblePriceUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.OffUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.PriceUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.countUpDown = new System.Windows.Forms.NumericUpDown();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.AccountInfo = new System.Windows.Forms.Button();
            this.ShowDetail = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Accounts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.NewLineGBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddPerson = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteRow = new System.Windows.Forms.Button();
            this.rowCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceAfterOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Left = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditRowBtn = new System.Windows.Forms.Button();
            this.NewLineGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftAmountUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayAblePriceUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffUpDown1)).BeginInit();
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
            this.NewLineGBox.Controls.Add(this.dateTextBox1);
            this.NewLineGBox.Controls.Add(this.LeftAmountUpDown1);
            this.NewLineGBox.Controls.Add(this.PayAblePriceUpDown1);
            this.NewLineGBox.Controls.Add(this.OffUpDown1);
            this.NewLineGBox.Controls.Add(this.PriceUpDown2);
            this.NewLineGBox.Controls.Add(this.countUpDown);
            this.NewLineGBox.Controls.Add(this.SubjectTextBox);
            this.NewLineGBox.Controls.Add(this.AccountInfo);
            this.NewLineGBox.Controls.Add(this.ShowDetail);
            this.NewLineGBox.Controls.Add(this.label7);
            this.NewLineGBox.Controls.Add(this.label6);
            this.NewLineGBox.Controls.Add(this.Accounts);
            this.NewLineGBox.Controls.Add(this.label5);
            this.NewLineGBox.Controls.Add(this.label3);
            this.NewLineGBox.Controls.Add(this.count);
            this.NewLineGBox.Controls.Add(this.label2);
            this.NewLineGBox.Controls.Add(this.label4);
            this.NewLineGBox.Controls.Add(this.Subject);
            this.NewLineGBox.Location = new System.Drawing.Point(12, 89);
            this.NewLineGBox.Name = "NewLineGBox";
            this.NewLineGBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewLineGBox.Size = new System.Drawing.Size(1076, 151);
            this.NewLineGBox.TabIndex = 0;
            this.NewLineGBox.TabStop = false;
            this.NewLineGBox.Text = "سطر جدید";
            this.NewLineGBox.Enter += new System.EventHandler(this.NewLineGBox_Enter);
            // 
            // dateTextBox1
            // 
            this.dateTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTextBox1.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.dateTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateTextBox1.Location = new System.Drawing.Point(909, 49);
            this.dateTextBox1.Mask = "####/##/##";
            this.dateTextBox1.Name = "dateTextBox1";
            this.dateTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTextBox1.Size = new System.Drawing.Size(94, 20);
            this.dateTextBox1.TabIndex = 6;
            // 
            // LeftAmountUpDown1
            // 
            this.LeftAmountUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LeftAmountUpDown1.Location = new System.Drawing.Point(398, 106);
            this.LeftAmountUpDown1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.LeftAmountUpDown1.Name = "LeftAmountUpDown1";
            this.LeftAmountUpDown1.Size = new System.Drawing.Size(165, 20);
            this.LeftAmountUpDown1.TabIndex = 5;
            // 
            // PayAblePriceUpDown1
            // 
            this.PayAblePriceUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PayAblePriceUpDown1.Location = new System.Drawing.Point(398, 80);
            this.PayAblePriceUpDown1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.PayAblePriceUpDown1.Name = "PayAblePriceUpDown1";
            this.PayAblePriceUpDown1.Size = new System.Drawing.Size(165, 20);
            this.PayAblePriceUpDown1.TabIndex = 5;
            // 
            // OffUpDown1
            // 
            this.OffUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OffUpDown1.Location = new System.Drawing.Point(398, 52);
            this.OffUpDown1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.OffUpDown1.Name = "OffUpDown1";
            this.OffUpDown1.Size = new System.Drawing.Size(165, 20);
            this.OffUpDown1.TabIndex = 5;
            // 
            // PriceUpDown2
            // 
            this.PriceUpDown2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PriceUpDown2.Location = new System.Drawing.Point(398, 22);
            this.PriceUpDown2.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.PriceUpDown2.Name = "PriceUpDown2";
            this.PriceUpDown2.Size = new System.Drawing.Size(165, 20);
            this.PriceUpDown2.TabIndex = 5;
            // 
            // countUpDown
            // 
            this.countUpDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.countUpDown.Location = new System.Drawing.Point(801, 77);
            this.countUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.countUpDown.Name = "countUpDown";
            this.countUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.countUpDown.Size = new System.Drawing.Size(202, 20);
            this.countUpDown.TabIndex = 5;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SubjectTextBox.Location = new System.Drawing.Point(691, 23);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(312, 20);
            this.SubjectTextBox.TabIndex = 4;
            // 
            // AccountInfo
            // 
            this.AccountInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AccountInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountInfo.Image = ((System.Drawing.Image)(resources.GetObject("AccountInfo.Image")));
            this.AccountInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AccountInfo.Location = new System.Drawing.Point(6, 96);
            this.AccountInfo.Name = "AccountInfo";
            this.AccountInfo.Size = new System.Drawing.Size(161, 49);
            this.AccountInfo.TabIndex = 3;
            this.AccountInfo.Text = "نمایش اطلاعات مشتری";
            this.AccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountInfo.UseVisualStyleBackColor = true;
            this.AccountInfo.Click += new System.EventHandler(this.ShowInfo_Click);
            // 
            // ShowDetail
            // 
            this.ShowDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ShowDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDetail.Image = ((System.Drawing.Image)(resources.GetObject("ShowDetail.Image")));
            this.ShowDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowDetail.Location = new System.Drawing.Point(6, 46);
            this.ShowDetail.Name = "ShowDetail";
            this.ShowDetail.Size = new System.Drawing.Size(108, 49);
            this.ShowDetail.TabIndex = 3;
            this.ShowDetail.Text = "اتخاب";
            this.ShowDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowDetail.UseVisualStyleBackColor = true;
            this.ShowDetail.Click += new System.EventHandler(this.ShowDetail_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(569, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "باقی مانده :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "قابل پرداخت :";
            // 
            // Accounts
            // 
            this.Accounts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accounts.FormattingEnabled = true;
            this.Accounts.Location = new System.Drawing.Point(6, 17);
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(188, 26);
            this.Accounts.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = " تخفیف :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "قیمت بدون تخفیف :";
            // 
            // count
            // 
            this.count.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(1022, 82);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(43, 13);
            this.count.TabIndex = 0;
            this.count.Text = "تعداد :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1022, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "تاریخ :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 20);
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
            this.Subject.Location = new System.Drawing.Point(1022, 26);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(53, 13);
            this.Subject.TabIndex = 0;
            this.Subject.Text = "موضوع :";
            // 
            // NewLineGBox2
            // 
            this.NewLineGBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewLineGBox2.Controls.Add(this.dataGridView1);
            this.NewLineGBox2.Location = new System.Drawing.Point(12, 246);
            this.NewLineGBox2.Name = "NewLineGBox2";
            this.NewLineGBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewLineGBox2.Size = new System.Drawing.Size(1079, 305);
            this.NewLineGBox2.TabIndex = 1;
            this.NewLineGBox2.TabStop = false;
            this.NewLineGBox2.Text = "اطلاعات";
            this.NewLineGBox2.Enter += new System.EventHandler(this.NewLineGBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowCol,
            this.date,
            this.subjectCol,
            this.countCol,
            this.priceCol,
            this.offCol,
            this.PriceAfterOff,
            this.Left});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1073, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.GridDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(353, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 47);
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
            this.AddPerson.Location = new System.Drawing.Point(915, 5);
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
            this.AddItem.Location = new System.Drawing.Point(811, 10);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(97, 67);
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
            this.panel1.Controls.Add(this.EditRowBtn);
            this.panel1.Controls.Add(this.AddItem);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(41, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 85);
            this.panel1.TabIndex = 4;
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
            // DeleteRow
            // 
            this.DeleteRow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DeleteRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteRow.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRow.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRow.Image")));
            this.DeleteRow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteRow.Location = new System.Drawing.Point(636, 5);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(66, 72);
            this.DeleteRow.TabIndex = 4;
            this.DeleteRow.Text = "حذف مورد";
            this.DeleteRow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteRow.UseVisualStyleBackColor = true;
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // rowCol
            // 
            this.rowCol.HeaderText = "ردیف";
            this.rowCol.Name = "rowCol";
            this.rowCol.ReadOnly = true;
            this.rowCol.Width = 55;
            // 
            // date
            // 
            this.date.HeaderText = "تاریخ";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // subjectCol
            // 
            this.subjectCol.HeaderText = "موضوع";
            this.subjectCol.Name = "subjectCol";
            this.subjectCol.ReadOnly = true;
            this.subjectCol.Width = 280;
            // 
            // countCol
            // 
            this.countCol.HeaderText = "تعداد";
            this.countCol.Name = "countCol";
            this.countCol.ReadOnly = true;
            this.countCol.Width = 55;
            // 
            // priceCol
            // 
            this.priceCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceCol.FillWeight = 60F;
            this.priceCol.HeaderText = "قیمت بدون تخفیف";
            this.priceCol.Name = "priceCol";
            this.priceCol.ReadOnly = true;
            this.priceCol.Width = 110;
            // 
            // offCol
            // 
            this.offCol.HeaderText = "تخفیف";
            this.offCol.Name = "offCol";
            this.offCol.ReadOnly = true;
            // 
            // PriceAfterOff
            // 
            this.PriceAfterOff.HeaderText = "مبلغ قابل پرداخت";
            this.PriceAfterOff.Name = "PriceAfterOff";
            this.PriceAfterOff.ReadOnly = true;
            this.PriceAfterOff.Width = 110;
            // 
            // Left
            // 
            this.Left.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Left.HeaderText = "مبلغ باقیمانده";
            this.Left.Name = "Left";
            this.Left.ReadOnly = true;
            // 
            // EditRowBtn
            // 
            this.EditRowBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EditRowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditRowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditRowBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.EditRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRowBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditRowBtn.Image")));
            this.EditRowBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditRowBtn.Location = new System.Drawing.Point(708, 5);
            this.EditRowBtn.Name = "EditRowBtn";
            this.EditRowBtn.Size = new System.Drawing.Size(97, 72);
            this.EditRowBtn.TabIndex = 3;
            this.EditRowBtn.Text = "ویرایش سطر";
            this.EditRowBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditRowBtn.UseMnemonic = false;
            this.EditRowBtn.UseVisualStyleBackColor = true;
            this.EditRowBtn.Click += new System.EventHandler(this.EditRow_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1103, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NewLineGBox2);
            this.Controls.Add(this.NewLineGBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.NewLineGBox.ResumeLayout(false);
            this.NewLineGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftAmountUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayAblePriceUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffUpDown1)).EndInit();
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
        private System.Windows.Forms.Button DeleteRow;
        private System.Windows.Forms.Label CurrentUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox dateTextBox1;
        private System.Windows.Forms.NumericUpDown LeftAmountUpDown1;
        private System.Windows.Forms.NumericUpDown PayAblePriceUpDown1;
        private System.Windows.Forms.NumericUpDown OffUpDown1;
        private System.Windows.Forms.Button AccountInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn countCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn offCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceAfterOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Left;
        private System.Windows.Forms.Button EditRowBtn;
    }
}