using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheek
{
    public partial class UitleenSysteem : Form
    {
        //Fields
        private List<Article> articles;
        private List<Member> members;

        //Constants
        public const int NOTPICKEDUPFINE = 2;
        public const int EXPIREDRESERVATION = 7;

        /// <summary>
        /// constructor
        /// </summary>
        public UitleenSysteem()
        {
            InitializeComponent();
            articles = new List<Article>();
            members = new List<Member>();
        }

        /// <summary>
        /// check the availability of an article.
        /// </summary>
        private bool AvailableArticle()
        {

            return false;
        }

        /// <summary>
        /// finds an article with its title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private Article getArticle(string title)
        {
            Article article = articles.Find(x => x.Title.Contains(title));
            return article;
        }

        /// <summary>
        /// adds an article to the articles list
        /// </summary>
        /// <param name="articleType"></param>
        /// <param name="type"></param>
        /// <param name="articleID"></param>
        /// <param name="title"></param>
        private void addArticle(string articleType, string type, int articleID, string title)
        {
            //TODO age of CD
            int age = 0;
            if(articleType == "Book")
            {
                if (type == "Roman")
                {
                    Book newArticle = new Book(BookType.ROMAN, articleID, title);
                    articles.Add(newArticle);
                }
                else if (type == "Study")
                {
                    Book newArticle = new Book(BookType.STUDY, articleID, title);
                    articles.Add(newArticle);
                }
                else
                {
                    MessageBox.Show("Wrong type");
                }
            }
            else if (articleType == "CD")
            {
                if (type == "Classic")
                {
                    CD newArticle = new CD(CDType.CLASSIC, articleID, title, age);
                    articles.Add(newArticle);
                }
                else if (type == "Pop")
                {
                    CD newArticle = new CD(CDType.POP, articleID, title, age);
                    articles.Add(newArticle);
                }
                else
                {
                    MessageBox.Show("Wrong type");
                }
            }
            else if (articleType == "DVD")
            {
                if (type == "AMovie")
                {
                    DVD newArticle = new DVD(DVDType.AMOVIE, articleID, title);
                    articles.Add(newArticle);
                }
                else if (type == "BMovie")
                {
                    DVD newArticle = new DVD(DVDType.BMOVIE, articleID, title);
                    articles.Add(newArticle);
                }
                else
                {
                    MessageBox.Show("Wrong type");
                }
            }
            else
            {
                MessageBox.Show("Wrong article type");
            }
        }

        private void changeArticle()
        {
            try
            {
                int id = Convert.ToInt32(txtEditArticleID.Text);
                addArticle(cbEditArticleType.SelectedItem.ToString(), cbEditType.SelectedItem.ToString(), id, txtEditArticleTitle.Text);
                Article delete = getArticle(lbList.SelectedItem.ToString());
                articles.Remove(delete);
                lbList.Items.Remove(delete);
                refreshList();
                txtEditArticleID.Text = "";
                txtEditArticleTitle.Text = "";
                groupBox4.Visible = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Geen geldig ID");
            }
        }

        private void deleteArticle()
        {
            Article delete = getArticle(lbList.SelectedItem.ToString());
            articles.Remove(delete);
            lbList.Items.Remove(delete);
            refreshList();
        }

        private void getMember()
        {

        }

        /// <summary>
        /// adds a member to the members list
        /// </summary>
        /// <param name="memberID"></param>
        /// <param name="name"></param>
        /// <param name="adres"></param>
        /// <param name="email"></param>
        private void addMember(int memberID, string name, string adres, string email)
        {
            Member newMember = new Member(memberID, name, adres, email);
            members.Add(newMember);
        }

        private void changeMember()
        {

        }

        private void deleteMember()
        {

        }

        private void loan()
        {

        }

        private void returnArticle()
        {

        }

        private void ReserveArticle(int memberID, int articleID)
        {

        }

        /// <summary>
        /// combobox change method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbChange(object sender, EventArgs e)
        {
            cbType.Items.Clear();
            if(cbArticleType.SelectedItem.ToString() == "Book")
            {
                cbType.Items.Add("Roman");
                cbType.Items.Add("Study");
            }
            else if (cbArticleType.SelectedItem.ToString() == "CD")
            {
                cbType.Items.Add("Classic");
                cbType.Items.Add("Pop");
            }
            else if (cbArticleType.SelectedItem.ToString() == "DVD")
            {
                cbType.Items.Add("AMovie");
                cbType.Items.Add("BMovie");
            }
            else
            {
                cbType.Items.Add("Choose a type");
            }
            cbType.SelectedIndex = 0;
        }

        /// <summary>
        /// button method for creating new article
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewArticle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtArticleID.Text);
                addArticle(cbArticleType.SelectedItem.ToString(), cbType.SelectedItem.ToString(), id, txtArticleTitle.Text);
                refreshList();
                txtArticleID.Text = "";
                txtArticleTitle.Text = "";
            }
            catch(FormatException)
            {
                MessageBox.Show("Geen geldig ID");
            }
        }

        /// <summary>
        /// button method for creating new member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewMember_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMemberID.Text);
            addMember(id,txtMemberName.Text, txtMemberAdres.Text, txtMemberEmail.Text);
            txtMemberID.Text = "";
            txtMemberName.Text = "";
            txtMemberAdres.Text = "";
            txtMemberEmail.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteArticle();
        }

        private void refreshList()
        {
            lbList.Items.Clear();
            foreach (Article article in articles)
            {
                lbList.Items.Add(article.Title);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            var classEdit = getArticle(lbList.SelectedItem.ToString());
            string className = classEdit.GetType().ToString();
            if (className == "Bibliotheek.Book")
            {
                var edit = (getArticle(lbList.SelectedItem.ToString()) as Book);
                cbEditArticleType.Text = "Book";
                cbEditType.Text = edit.BookType.ToString();
                txtEditArticleID.Text = edit.ArticleID.ToString();
                txtEditArticleTitle.Text = edit.Title.ToString();
            }
            else if(className == "Bibliotheek.CD")
            {
                var edit = (getArticle(lbList.SelectedItem.ToString()) as CD);
                cbEditArticleType.Text = "CD";
                cbEditType.Text = edit.CDType.ToString();
                txtEditArticleID.Text = edit.ArticleID.ToString();
                txtEditArticleTitle.Text = edit.Title.ToString();
            }
            else if (className == "Bibliotheek.DVD")
            {
                var edit = (getArticle(lbList.SelectedItem.ToString()) as DVD);
                cbEditArticleType.Text = "DVD";
                cbEditType.Text = edit.DVDType.ToString();
                txtEditArticleID.Text = edit.ArticleID.ToString();
                txtEditArticleTitle.Text = edit.Title.ToString();
            }
            else
            {
                MessageBox.Show("Wrong article type");
            }

        }

        private void btnEditArticle_Click(object sender, EventArgs e)
        {
            changeArticle();
        }

        private void cbEditChange(object sender, EventArgs e)
        {
            cbEditType.Items.Clear();
            if (cbEditArticleType.SelectedItem.ToString() == "Book")
            {
                cbEditType.Items.Add("Roman");
                cbEditType.Items.Add("Study");
            }
            else if (cbEditArticleType.SelectedItem.ToString() == "CD")
            {
                cbEditType.Items.Add("Classic");
                cbEditType.Items.Add("Pop");
            }
            else if (cbEditArticleType.SelectedItem.ToString() == "DVD")
            {
                cbEditType.Items.Add("AMovie");
                cbEditType.Items.Add("BMovie");
            }
        }
    }
}