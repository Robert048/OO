namespace Bibliotheek
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
            this.btnReserve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbArticleType
            // 
            this.cbArticleType.FormattingEnabled = true;
            this.cbArticleType.Items.AddRange(new object[] {
            "Book",
            "CD",
            "DVD"});
            this.cbArticleType.Location = new System.Drawing.Point(142, 37);
            this.cbArticleType.Margin = new System.Windows.Forms.Padding(6);
            this.cbArticleType.Name = "cbArticleType";
            this.cbArticleType.Size = new System.Drawing.Size(238, 33);
            this.cbArticleType.TabIndex = 0;
            this.cbArticleType.SelectedIndexChanged += new System.EventHandler(this.cbChange);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(144, 90);
            this.cbType.Margin = new System.Windows.Forms.Padding(6);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(238, 33);
            this.cbType.TabIndex = 1;
            this.cbType.Tag = "";
            // 
            // txtArticleID
            // 
            this.txtArticleID.Location = new System.Drawing.Point(144, 144);
            this.txtArticleID.Margin = new System.Windows.Forms.Padding(6);
            this.txtArticleID.Name = "txtArticleID";
            this.txtArticleID.Size = new System.Drawing.Size(236, 31);
            this.txtArticleID.TabIndex = 2;
            // 
            // txtArticleTitle
            // 
            this.txtArticleTitle.Location = new System.Drawing.Point(144, 196);
            this.txtArticleTitle.Margin = new System.Windows.Forms.Padding(6);
            this.txtArticleTitle.Name = "txtArticleTitle";
            this.txtArticleTitle.Size = new System.Drawing.Size(236, 31);
            this.txtArticleTitle.TabIndex = 3;
            // 
            // btnNewArticle
            // 
            this.btnNewArticle.Location = new System.Drawing.Point(144, 248);
            this.btnNewArticle.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewArticle.Name = "btnNewArticle";
            this.btnNewArticle.Size = new System.Drawing.Size(240, 44);
            this.btnNewArticle.TabIndex = 4;
            this.btnNewArticle.Text = "New article";
            this.btnNewArticle.UseVisualStyleBackColor = true;
            this.btnNewArticle.Click += new System.EventHandler(this.btnNewArticle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbArticleType);
            this.groupBox1.Controls.Add(this.btnNewArticle);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.txtArticleTitle);
            this.groupBox1.Controls.Add(this.txtArticleID);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(404, 312);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a new Article";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Article Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Article ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
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
            this.groupBox2.Location = new System.Drawing.Point(24, 346);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(404, 312);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add a new Member";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(144, 37);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(6);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(236, 31);
            this.txtMemberID.TabIndex = 2;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(144, 94);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(6);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(236, 31);
            this.txtMemberName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID";
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(144, 248);
            this.btnNewMember.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(240, 44);
            this.btnNewMember.TabIndex = 6;
            this.btnNewMember.Text = "New member";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.Location = new System.Drawing.Point(144, 196);
            this.txtMemberEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.Size = new System.Drawing.Size(236, 31);
            this.txtMemberEmail.TabIndex = 5;
            // 
            // txtMemberAdres
            // 
            this.txtMemberAdres.Location = new System.Drawing.Point(144, 144);
            this.txtMemberAdres.Margin = new System.Windows.Forms.Padding(6);
            this.txtMemberAdres.Name = "txtMemberAdres";
            this.txtMemberAdres.Size = new System.Drawing.Size(236, 31);
            this.txtMemberAdres.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.lbList);
            this.groupBox3.Location = new System.Drawing.Point(440, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(382, 312);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Articles list";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(202, 248);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 44);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 248);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 25;
            this.lbList.Location = new System.Drawing.Point(12, 37);
            this.lbList.Margin = new System.Windows.Forms.Padding(6);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(354, 204);
            this.lbList.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cbEditArticleType);
            this.groupBox4.Controls.Add(this.btnEditArticle);
            this.groupBox4.Controls.Add(this.cbEditType);
            this.groupBox4.Controls.Add(this.txtEditArticleTitle);
            this.groupBox4.Controls.Add(this.txtEditArticleID);
            this.groupBox4.Location = new System.Drawing.Point(834, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(400, 312);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit Article";
            this.groupBox4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Article Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Article ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 26);
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
            this.cbEditArticleType.Location = new System.Drawing.Point(144, 29);
            this.cbEditArticleType.Margin = new System.Windows.Forms.Padding(6);
            this.cbEditArticleType.Name = "cbEditArticleType";
            this.cbEditArticleType.Size = new System.Drawing.Size(238, 33);
            this.cbEditArticleType.TabIndex = 9;
            this.cbEditArticleType.SelectedIndexChanged += new System.EventHandler(this.cbEditChange);
            // 
            // btnEditArticle
            // 
            this.btnEditArticle.Location = new System.Drawing.Point(146, 240);
            this.btnEditArticle.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditArticle.Name = "btnEditArticle";
            this.btnEditArticle.Size = new System.Drawing.Size(240, 44);
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
            this.cbEditType.Location = new System.Drawing.Point(146, 83);
            this.cbEditType.Margin = new System.Windows.Forms.Padding(6);
            this.cbEditType.Name = "cbEditType";
            this.cbEditType.Size = new System.Drawing.Size(238, 33);
            this.cbEditType.TabIndex = 10;
            this.cbEditType.Tag = "";
            // 
            // txtEditArticleTitle
            // 
            this.txtEditArticleTitle.Location = new System.Drawing.Point(146, 188);
            this.txtEditArticleTitle.Margin = new System.Windows.Forms.Padding(6);
            this.txtEditArticleTitle.Name = "txtEditArticleTitle";
            this.txtEditArticleTitle.Size = new System.Drawing.Size(236, 31);
            this.txtEditArticleTitle.TabIndex = 12;
            // 
            // txtEditArticleID
            // 
            this.txtEditArticleID.Location = new System.Drawing.Point(146, 137);
            this.txtEditArticleID.Margin = new System.Windows.Forms.Padding(6);
            this.txtEditArticleID.Name = "txtEditArticleID";
            this.txtEditArticleID.Size = new System.Drawing.Size(236, 31);
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
            this.groupBox5.Location = new System.Drawing.Point(834, 346);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(400, 312);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edit Article";
            this.groupBox5.Visible = false;
            // 
            // txtEditMemberID
            // 
            this.txtEditMemberID.Location = new System.Drawing.Point(146, 29);
            this.txtEditMemberID.Margin = new System.Windows.Forms.Padding(6);
            this.txtEditMemberID.Name = "txtEditMemberID";
            this.txtEditMemberID.Size = new System.Drawing.Size(236, 31);
            this.txtEditMemberID.TabIndex = 10;
            // 
            // txtEditMemberName
            // 
            this.txtEditMemberName.Location = new System.Drawing.Point(146, 86);
            this.txtEditMemberName.Margin = new System.Windows.Forms.Padding(6);
            this.txtEditMemberName.Name = "txtEditMemberName";
            this.txtEditMemberName.Size = new System.Drawing.Size(236, 31);
            this.txtEditMemberName.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 88);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 26);
            this.label12.TabIndex = 17;
            this.label12.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 142);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 26);
            this.label13.TabIndex = 16;
            this.label13.Text = "Adres";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 34);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 26);
            this.label14.TabIndex = 13;
            this.label14.Text = "ID";
            // 
            // btnEditMember
            // 
            this.btnEditMember.Location = new System.Drawing.Point(146, 240);
            this.btnEditMember.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(240, 44);
            this.btnEditMember.TabIndex = 15;
            this.btnEditMember.Text = "Edit member";
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // txtEditMemberEmail
            // 
            this.txtEditMemberEmail.Location = new System.Drawing.Point(146, 188);
            this.txtEditMemberEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEditMemberEmail.Name = "txtEditMemberEmail";
            this.txtEditMemberEmail.Size = new System.Drawing.Size(236, 31);
            this.txtEditMemberEmail.TabIndex = 14;
            // 
            // txtEditMemberAdres
            // 
            this.txtEditMemberAdres.Location = new System.Drawing.Point(146, 136);
            this.txtEditMemberAdres.Margin = new System.Windows.Forms.Padding(6);
            this.txtEditMemberAdres.Name = "txtEditMemberAdres";
            this.txtEditMemberAdres.Size = new System.Drawing.Size(236, 31);
            this.txtEditMemberAdres.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnMemberEdit);
            this.groupBox6.Controls.Add(this.btnMemberDelete);
            this.groupBox6.Controls.Add(this.memList);
            this.groupBox6.Location = new System.Drawing.Point(440, 346);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox6.Size = new System.Drawing.Size(382, 312);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Members list";
            // 
            // btnMemberEdit
            // 
            this.btnMemberEdit.Location = new System.Drawing.Point(202, 248);
            this.btnMemberEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnMemberEdit.Name = "btnMemberEdit";
            this.btnMemberEdit.Size = new System.Drawing.Size(168, 44);
            this.btnMemberEdit.TabIndex = 3;
            this.btnMemberEdit.Text = "Edit";
            this.btnMemberEdit.UseVisualStyleBackColor = true;
            this.btnMemberEdit.Click += new System.EventHandler(this.btnMemberEdit_Click);
            // 
            // btnMemberDelete
            // 
            this.btnMemberDelete.Location = new System.Drawing.Point(12, 248);
            this.btnMemberDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnMemberDelete.Name = "btnMemberDelete";
            this.btnMemberDelete.Size = new System.Drawing.Size(168, 44);
            this.btnMemberDelete.TabIndex = 2;
            this.btnMemberDelete.Text = "Delete";
            this.btnMemberDelete.UseVisualStyleBackColor = true;
            this.btnMemberDelete.Click += new System.EventHandler(this.btnMemberDelete_Click);
            // 
            // memList
            // 
            this.memList.FormattingEnabled = true;
            this.memList.ItemHeight = 25;
            this.memList.Location = new System.Drawing.Point(12, 37);
            this.memList.Margin = new System.Windows.Forms.Padding(6);
            this.memList.Name = "memList";
            this.memList.Size = new System.Drawing.Size(354, 204);
            this.memList.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(24, 668);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(404, 310);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(440, 668);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(382, 55);
            this.btnReserve.TabIndex = 15;
            this.btnReserve.Text = "Uitlenen";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // UitleenSysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 1040);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
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
            this.ResumeLayout(false);

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
    }
}

