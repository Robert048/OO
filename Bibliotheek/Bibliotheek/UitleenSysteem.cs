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
        private List<Leden> members;

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
            members = new List<Leden>();

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

        private void addArticle(string type, int articleID, string title)
        {
            if(type == "book")
            {
                Article newArticle = new Book(BookType.ROMAN, articleID, title);
                articles.Add(newArticle);
            }
            else if(type == "cd")
            {
                //Article newArticle = new CD(articleID, title);
                //articles.Add(newArticle);
            }
            else if(type == "DVD")
            {
                //Article newArticle = new DVD(articleID, title);
                //articles.Add(newArticle);
            }
            else
            {
                MessageBox.Show("Wrong type");
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
            //Leden newMember = new Leden(memberID, name, adres, email);
            //members.Add(newMember);
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
    }
}


//if (type == "book")
//            {
                
//            }
//            else if (type == "cd")
//            {
                
//            }
//            else if (type == "DVD")
//            {
                
//            }
//            else
//            {
//                MessageBox.Show("Wrong type");
//            }