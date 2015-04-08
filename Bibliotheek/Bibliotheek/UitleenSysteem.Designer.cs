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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.txtMemberAdres = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbList = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.btnNewArticle.Location = new System.Drawing.Point(72, 129);
            this.btnNewArticle.Name = "btnNewArticle";
            this.btnNewArticle.Size = new System.Drawing.Size(120, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 162);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a new Article";
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
            this.groupBox2.Location = new System.Drawing.Point(220, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 162);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add a new Member";
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
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(72, 49);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(120, 20);
            this.txtMemberName.TabIndex = 3;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(72, 19);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(120, 20);
            this.txtMemberID.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.lbList);
            this.groupBox3.Location = new System.Drawing.Point(429, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 162);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.Location = new System.Drawing.Point(6, 19);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(179, 108);
            this.lbList.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(101, 129);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // UitleenSysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 360);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UitleenSysteem";
            this.Text = "Uitleen systeem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
    }
}

