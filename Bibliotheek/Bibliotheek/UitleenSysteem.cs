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
        private List<Artikel> articles;
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
            articles = new List<Artikel>();
            members = new List<Leden>();
            
        }

        /// <summary>
        /// check the availability of an article.
        /// </summary>
        private bool AvailableArticle()
        {

            return false;
        }

        private void getArticle()
        {
            
        }

        private void addArticle(int articleID, string title)
        {
            Artikel newArticle = new Artikel(articleID, title);
            articles.Add(newArticle);
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
            Leden newMember = new Leden(memberID, name, adres, email);
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
    }
}
