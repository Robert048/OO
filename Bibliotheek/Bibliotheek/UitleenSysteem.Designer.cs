﻿namespace Bibliotheek
{
    partial class UitleenSysteem
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
            this.cbArticleType = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtArticleID = new System.Windows.Forms.TextBox();
            this.txtArticleTitle = new System.Windows.Forms.TextBox();
            this.btnNewArticle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCdAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.txtMemberAdres = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbList = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEditCdAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEditArticleType = new System.Windows.Forms.ComboBox();
            this.btnEditArticle = new System.Windows.Forms.Button();
            this.cbEditType = new System.Windows.Forms.ComboBox();
            this.txtEditArticleTitle = new System.Windows.Forms.TextBox();
            this.txtEditArticleID = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtEditMemberID = new System.Windows.Forms.TextBox();
            this.txtEditMemberName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.txtEditMemberEmail = new System.Windows.Forms.TextBox();
            this.txtEditMemberAdres = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnMemberEdit = new System.Windows.Forms.Button();
            this.btnMemberDelete = new System.Windows.Forms.Button();
            this.memList = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.daysPassed = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbArticleType
            // 
            this.cbArticleType.FormattingEnabled = true;
            this.cbArticleType.Items.AddRange(new object[] {
            "Book",
            "CD",
            "DVD"});
            this.cbArticleType.Location = new System.Drawing.Point(71, 19);
            this.cbArticleType.Name = "cbArticleType";
            this.cbArticleType.Size = new System.Drawing.Size(121, 21);
            this.cbArticleType.TabIndex = 0;
            this.cbArticleType.SelectedIndexChanged += new System.EventHandler(this.cbChange);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(72, 47);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 1;
            this.cbType.Tag = "";
            // 
            // txtArticleID
            // 
            this.txtArticleID.Location = new System.Drawing.Point(72, 75);
            this.txtArticleID.Name = "txtArticleID";
            this.txtArticleID.Size = new System.Drawing.Size(120, 20);
            this.txtArticleID.TabIndex = 2;
            // 
            // txtArticleTitle
            // 
            this.txtArticleTitle.Location = new System.Drawing.Point(72, 102);
            this.txtArticleTitle.Name = "txtArticleTitle";
            this.txtArticleTitle.Size = new System.Drawing.Size(120, 20);
            this.txtArticleTitle.TabIndex = 3;
            // 
            // btnNewArticle
            // 
            this.btnNewArticle.Location = new System.Drawing.Point(71, 160);
            this.btnNewArticle.Name = "btnNewArticle";
            this.btnNewArticle.Size = new System.Drawing.Size(120, 23);
            this.btnNewArticle.TabIndex = 4;
            this.btnNewArticle.Text = "New article";
            this.btnNewArticle.UseVisualStyleBackColor = true;
            this.btnNewArticle.Click += new System.EventHandler(this.btnNewArticle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtCdAge);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbArticleType);
            this.groupBox1.Controls.Add(this.btnNewArticle);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.txtArticleTitle);
            this.groupBox1.Controls.Add(this.txtArticleID);
            this.groupBox1.Location = new System.Drawing.Point(14, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 189);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a new Article";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "CD Age";
            this.label15.Visible = false;
            // 
            // txtCdAge
            // 
            this.txtCdAge.Location = new System.Drawing.Point(71, 129);
            this.txtCdAge.Name = "txtCdAge";
            this.txtCdAge.Size = new System.Drawing.Size(120, 20);
            this.txtCdAge.TabIndex = 9;
            this.txtCdAge.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Article Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Article ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Article type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMemberID);
            this.groupBox2.Controls.Add(this.txtMemberName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnNewMember);
            this.groupBox2.Controls.Add(this.txtMemberEmail);
            this.groupBox2.Controls.Add(this.txtMemberAdres);
            this.groupBox2.Location = new System.Drawing.Point(14, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 162);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add a new Member";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(72, 19);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(120, 20);
            this.txtMemberID.TabIndex = 2;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(72, 49);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(120, 20);
            this.txtMemberName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID";
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(72, 129);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(120, 23);
            this.btnNewMember.TabIndex = 6;
            this.btnNewMember.Text = "New member";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.Location = new System.Drawing.Point(72, 102);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.Size = new System.Drawing.Size(120, 20);
            this.txtMemberEmail.TabIndex = 5;
            // 
            // txtMemberAdres
            // 
            this.txtMemberAdres.Location = new System.Drawing.Point(72, 75);
            this.txtMemberAdres.Name = "txtMemberAdres";
            this.txtMemberAdres.Size = new System.Drawing.Size(120, 20);
            this.txtMemberAdres.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.lbList);
            this.groupBox3.Location = new System.Drawing.Point(222, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 189);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Articles list";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(101, 129);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.Location = new System.Drawing.Point(6, 19);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(179, 108);
            this.lbList.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtEditCdAge);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cbEditArticleType);
            this.groupBox4.Controls.Add(this.btnEditArticle);
            this.groupBox4.Controls.Add(this.cbEditType);
            this.groupBox4.Controls.Add(this.txtEditArticleTitle);
            this.groupBox4.Controls.Add(this.txtEditArticleID);
            this.groupBox4.Location = new System.Drawing.Point(420, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 189);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit Article";
            this.groupBox4.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "CD Age";
            this.label16.Visible = false;
            // 
            // txtEditCdAge
            // 
            this.txtEditCdAge.Location = new System.Drawing.Point(72, 129);
            this.txtEditCdAge.Name = "txtEditCdAge";
            this.txtEditCdAge.Size = new System.Drawing.Size(120, 20);
            this.txtEditCdAge.TabIndex = 17;
            this.txtEditCdAge.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Article Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Article ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Article type";
            // 
            // cbEditArticleType
            // 
            this.cbEditArticleType.FormattingEnabled = true;
            this.cbEditArticleType.Items.AddRange(new object[] {
            "Book",
            "CD",
            "DVD"});
            this.cbEditArticleType.Location = new System.Drawing.Point(72, 15);
            this.cbEditArticleType.Name = "cbEditArticleType";
            this.cbEditArticleType.Size = new System.Drawing.Size(121, 21);
            this.cbEditArticleType.TabIndex = 9;
            this.cbEditArticleType.SelectedIndexChanged += new System.EventHandler(this.cbEditChange);
            // 
            // btnEditArticle
            // 
            this.btnEditArticle.Location = new System.Drawing.Point(72, 160);
            this.btnEditArticle.Name = "btnEditArticle";
            this.btnEditArticle.Size = new System.Drawing.Size(120, 23);
            this.btnEditArticle.TabIndex = 13;
            this.btnEditArticle.Text = "Edit article";
            this.btnEditArticle.UseVisualStyleBackColor = true;
            this.btnEditArticle.Click += new System.EventHandler(this.btnEditArticle_Click);
            // 
            // cbEditType
            // 
            this.cbEditType.FormattingEnabled = true;
            this.cbEditType.Items.AddRange(new object[] {
            "Roman",
            "Study",
            "Classic",
            "Pop",
            "Amovie",
            "Bmovie"});
            this.cbEditType.Location = new System.Drawing.Point(73, 43);
            this.cbEditType.Name = "cbEditType";
            this.cbEditType.Size = new System.Drawing.Size(121, 21);
            this.cbEditType.TabIndex = 10;
            this.cbEditType.Tag = "";
            // 
            // txtEditArticleTitle
            // 
            this.txtEditArticleTitle.Location = new System.Drawing.Point(73, 98);
            this.txtEditArticleTitle.Name = "txtEditArticleTitle";
            this.txtEditArticleTitle.Size = new System.Drawing.Size(120, 20);
            this.txtEditArticleTitle.TabIndex = 12;
            // 
            // txtEditArticleID
            // 
            this.txtEditArticleID.Location = new System.Drawing.Point(73, 71);
            this.txtEditArticleID.Name = "txtEditArticleID";
            this.txtEditArticleID.Size = new System.Drawing.Size(120, 20);
            this.txtEditArticleID.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtEditMemberID);
            this.groupBox5.Controls.Add(this.txtEditMemberName);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.btnEditMember);
            this.groupBox5.Controls.Add(this.txtEditMemberEmail);
            this.groupBox5.Controls.Add(this.txtEditMemberAdres);
            this.groupBox5.Location = new System.Drawing.Point(420, 257);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 162);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edit Article";
            this.groupBox5.Visible = false;
            // 
            // txtEditMemberID
            // 
            this.txtEditMemberID.Location = new System.Drawing.Point(73, 15);
            this.txtEditMemberID.Name = "txtEditMemberID";
            this.txtEditMemberID.Size = new System.Drawing.Size(120, 20);
            this.txtEditMemberID.TabIndex = 10;
            // 
            // txtEditMemberName
            // 
            this.txtEditMemberName.Location = new System.Drawing.Point(73, 45);
            this.txtEditMemberName.Name = "txtEditMemberName";
            this.txtEditMemberName.Size = new System.Drawing.Size(120, 20);
            this.txtEditMemberName.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Adres";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "ID";
            // 
            // btnEditMember
            // 
            this.btnEditMember.Location = new System.Drawing.Point(73, 125);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(120, 23);
            this.btnEditMember.TabIndex = 15;
            this.btnEditMember.Text = "Edit member";
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // txtEditMemberEmail
            // 
            this.txtEditMemberEmail.Location = new System.Drawing.Point(73, 98);
            this.txtEditMemberEmail.Name = "txtEditMemberEmail";
            this.txtEditMemberEmail.Size = new System.Drawing.Size(120, 20);
            this.txtEditMemberEmail.TabIndex = 14;
            // 
            // txtEditMemberAdres
            // 
            this.txtEditMemberAdres.Location = new System.Drawing.Point(73, 71);
            this.txtEditMemberAdres.Name = "txtEditMemberAdres";
            this.txtEditMemberAdres.Size = new System.Drawing.Size(120, 20);
            this.txtEditMemberAdres.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnMemberEdit);
            this.groupBox6.Controls.Add(this.btnMemberDelete);
            this.groupBox6.Controls.Add(this.memList);
            this.groupBox6.Location = new System.Drawing.Point(222, 257);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(191, 162);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Members list";
            // 
            // btnMemberEdit
            // 
            this.btnMemberEdit.Location = new System.Drawing.Point(101, 129);
            this.btnMemberEdit.Name = "btnMemberEdit";
            this.btnMemberEdit.Size = new System.Drawing.Size(84, 23);
            this.btnMemberEdit.TabIndex = 3;
            this.btnMemberEdit.Text = "Edit";
            this.btnMemberEdit.UseVisualStyleBackColor = true;
            this.btnMemberEdit.Click += new System.EventHandler(this.btnMemberEdit_Click);
            // 
            // btnMemberDelete
            // 
            this.btnMemberDelete.Location = new System.Drawing.Point(6, 129);
            this.btnMemberDelete.Name = "btnMemberDelete";
            this.btnMemberDelete.Size = new System.Drawing.Size(84, 23);
            this.btnMemberDelete.TabIndex = 2;
            this.btnMemberDelete.Text = "Delete";
            this.btnMemberDelete.UseVisualStyleBackColor = true;
            this.btnMemberDelete.Click += new System.EventHandler(this.btnMemberDelete_Click);
            // 
            // memList
            // 
            this.memList.FormattingEnabled = true;
            this.memList.Location = new System.Drawing.Point(6, 19);
            this.memList.Name = "memList";
            this.memList.Size = new System.Drawing.Size(179, 108);
            this.memList.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnReturn);
            this.groupBox7.Controls.Add(this.btnLoan);
            this.groupBox7.Controls.Add(this.btnReserve);
            this.groupBox7.Location = new System.Drawing.Point(222, 424);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(191, 118);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Select article and member";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(6, 83);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(179, 29);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Location = new System.Drawing.Point(6, 50);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(179, 29);
            this.btnLoan.TabIndex = 16;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(6, 17);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(2);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(179, 29);
            this.btnReserve.TabIndex = 15;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // daysPassed
            // 
            this.daysPassed.Location = new System.Drawing.Point(85, 512);
            this.daysPassed.Margin = new System.Windows.Forms.Padding(2);
            this.daysPassed.Name = "daysPassed";
            this.daysPassed.Size = new System.Drawing.Size(121, 20);
            this.daysPassed.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 515);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Days passed";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Bibliotheek.Properties.Resources.library;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(420, 424);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 118);
            this.panel1.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("SketchFlow Print", 29.02618F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 7);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(395, 42);
            this.label18.TabIndex = 17;
            this.label18.Text = "Best Library EVER";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Total income";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UitleenSysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(640, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.daysPassed);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UitleenSysteem";
            this.Text = "Uitleen systeem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbArticleType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtArticleID;
        private System.Windows.Forms.TextBox txtArticleTitle;
        private System.Windows.Forms.Button btnNewArticle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.TextBox txtMemberEmail;
        private System.Windows.Forms.TextBox txtMemberAdres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEditArticleType;
        private System.Windows.Forms.Button btnEditArticle;
        private System.Windows.Forms.ComboBox cbEditType;
        private System.Windows.Forms.TextBox txtEditArticleTitle;
        private System.Windows.Forms.TextBox txtEditArticleID;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnMemberEdit;
        private System.Windows.Forms.Button btnMemberDelete;
        private System.Windows.Forms.ListBox memList;
        private System.Windows.Forms.TextBox txtEditMemberID;
        private System.Windows.Forms.TextBox txtEditMemberName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.TextBox txtEditMemberEmail;
        private System.Windows.Forms.TextBox txtEditMemberAdres;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCdAge;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEditCdAge;
        private System.Windows.Forms.TextBox daysPassed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
    }
}

