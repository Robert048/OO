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

            cbType.Items.Add("Choose a type");
            cbType.SelectedIndex = 0;

            Article newArticle = new Book(BookType.ROMAN, 1, "test");
            articles.Add(newArticle);
            getArticle("test");

        }

        /// <summary>
        /// check the availability of an article.
        /// </summary>
        private bool AvailableArticle()
        {

            return false;
        }

        private Article getArticle(string title)
        {
            Article article = articles.Find(x => x.Title.Contains(title));
            return article;
        }

        private void addArticle(string articleType, string type, int articleID, string title)
        {
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
                    CD newArticle = new CD(CDType.CLASSIC, articleID, title);
                    articles.Add(newArticle);
                }
                else if (type == "Pop")
                {
                    CD newArticle = new CD(CDType.POP, articleID, title);
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
                MessageBox.Show("+Wrong type");
            }
        }

        private void changeArticle()
        {

        }

        private void deleteArticle()
        {

        }

        private void getMember()
        {

        }

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

        private void btnNewArticle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtArticleID.Text);
            addArticle(cbArticleType.SelectedItem.ToString(), cbType.SelectedItem.ToString(), id, txtArticleTitle.Text);
            txtArticleID.Text = "";
            txtArticleTitle.Text = "";
        }
    }
}