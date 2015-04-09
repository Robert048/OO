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
        private bool AvailableArticle(Article article)
        {
            if ((article.LoanStatus == false) && article.ReservationsList.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            catch (Exception)
            {
                MessageBox.Show("Geen geldig ID en anders screw you");
            }
        }

        private void deleteArticle()
        {
            Article delete = getArticle(lbList.SelectedItem.ToString());
            articles.Remove(delete);
            lbList.Items.Remove(delete);
            refreshList();
        }

        private Member getMember(string name)
        {
            Member member = members.Find( x => x.memberName.Contains(name));
            return member;

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
            try
            {

                int id = Convert.ToInt32(txtEditMemberID.Text);
                addMember(id, txtEditMemberName.Text, txtEditMemberAdres.Text, txtEditMemberEmail.Text);
                Member delete = getMember(memList.SelectedItem.ToString());
                members.Remove(delete);
                memList.Items.Remove(delete);
                refreshMemList();

                txtMemberID.Text = "";
                txtMemberName.Text = "";
                txtMemberAdres.Text = "";
                txtMemberEmail.Text = "";

                groupBox5.Visible = false;
            }
            
            catch(Exception)
            {
                MessageBox.Show("You fucked up");
            }
        }

        private void deleteMember()
        {
            Member delete = getMember(memList.SelectedItem.ToString());
            members.Remove(delete);
            memList.Items.Remove(delete);
            refreshMemList();

        }

        private void loan(int memberID, int articleID)
        {
            Article article = articles.Find(x => x.ArticleID == articleID);
            Member member = members.Find(x => x.memberId == memberID);
            if (member.numberOfArticles < member.getMaxArticles())
            {
                if (AvailableArticle(article))
                {
                    article.LoanStatus = true;
                    article.LoanDate = DateTime.Now;
                    article.LoanMember = memberID;
                    member.numberOfArticles++;
                    MessageBox.Show("Article loaned");
                }
                else
                {
                    MessageBox.Show("Article unavailable, please reserve it.");
                }
            }
            else
            {
                MessageBox.Show("Too many articles loaned");
            }
        }

        public double checkFine(int diff, int articleID)
        {
            Article article = articles.Find(x => x.ArticleID == articleID);
            var classEdit = getArticle(lbList.SelectedItem.ToString());
            string className = classEdit.GetType().ToString();

            
            double fine = 0;

            if (className == "Bibliotheek.Book")
            {
                var book = (getArticle(lbList.SelectedItem.ToString()) as Book);
                if(book.BookType.ToString() == "ROMAN")
                {
                    diff = diff - 21;
                    if (diff > 0)
                    {
                        fine = 0.25 * diff;
                    }
                    else
                    {
                        fine = 0;
                    }
                }

                if(book.BookType.ToString() == "STUDY")
                {
                    diff = diff - 21;
                    if (diff > 0)
                    {
                        fine = 1 * diff;
                    }
                    else
                    {
                        fine = 0;
                    }
                }

            }
            else if (className == "Bibliotheek.CD")
            {
                var cd = (getArticle(lbList.SelectedItem.ToString()) as CD);
                if (cd.CDType.ToString() == "POP")
                {
                    diff = diff - 21;
                    if (diff > 0)
                    {
                        fine = 2 * diff;
                    }
                    else
                    {
                        fine = 0;
                    }
                }

                if (cd.CDType.ToString() == "CLASSIC")
                {
                    diff = diff - 21;
                    if (diff > 0)
                    {
                        fine = 1.50 * diff;
                    }
                    else
                    {
                        diff = 0;
                    }
                }
            }
            else if (className == "Bibliotheek.DVD")
            {
                var dvd = (getArticle(lbList.SelectedItem.ToString()) as DVD);

                if (dvd.DVDType.ToString() == "AMOVIE")
                {
                    diff = diff - 21;
                    if (diff > 0)
                    {
                        fine = 1 * diff;
                    }
                    else
                    {
                        fine = 0;
                    }
                }
                if (dvd.DVDType.ToString() == "BMOVIE")
                {
                    diff = diff - 21;
                    if (diff > 0)
                    {
                        fine = 1 * diff;
                    }
                    else
                    {
                        fine = 0;
                    }
                }
            }

            return fine;
        }

        private void returnArticle(int memberID, int articleID)
        {
            Article article = articles.Find(x => x.ArticleID == articleID);
            Member member = members.Find(x => x.memberId == memberID);
            if (article.LoanMember == memberID)
            {
                article.LoanStatus = false;
                TimeSpan duration = article.LoanDate - DateTime.Now;
                int time = Convert.ToInt32(duration.TotalDays + 54);
                article.LoanedPeriod = article.LoanedPeriod + time;
                article.LoanMember = -1;
                member.numberOfArticles--;
                MessageBox.Show("Article returned" + " Fine is :  €" + checkFine(time, articleID).ToString());
            }
            else
            {
                MessageBox.Show("No match");
            }
        }

        /// <summary>
        /// Method to reserve an article
        /// </summary>
        /// <param name="memberID">ID of the member that wants to reserve an article</param>
        /// <param name="articleID">the article that is gonna be reserved</param>
        private void ReserveArticle(int memberID, int articleID)
        {
            Article article = articles.Find(x => x.ArticleID == articleID);
            if(AvailableArticle(article))
            {
                MessageBox.Show("Article available, Loan instead of reserve");
            }
            else if(article.ReservationsList.ContainsKey(memberID))
            {
                MessageBox.Show("Already reserved by this member");
            }
            else if(article.LoanMember == memberID)
            {
                MessageBox.Show("Member already has this article loaned");
            }
            else
            {
                article.ReservationsList.Add(memberID, DateTime.Now);
                MessageBox.Show("Gereserveerd");
            }
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
            try
            {
                int id = Convert.ToInt32(txtMemberID.Text);
                addMember(id, txtMemberName.Text, txtMemberAdres.Text, txtMemberEmail.Text);
                txtMemberID.Text = "";
                txtMemberName.Text = "";
                txtMemberAdres.Text = "";
                txtMemberEmail.Text = "";
                refreshMemList();
            }

            catch(Exception)
            {
                MessageBox.Show("Invalid values.");
            }
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

        private void refreshMemList()
        {
            memList.Items.Clear();
            foreach(Member m in members)
            {
                memList.Items.Add(m.memberName);
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


        private void btnMemberDelete_Click(object sender, EventArgs e)
        {
            deleteMember();
        }

        private void btnMemberEdit_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            var memEdit = getMember(memList.SelectedItem.ToString());
            string memName = memEdit.GetType().ToString();
            txtEditMemberID.Text = memEdit.memberId.ToString();
            txtEditMemberName.Text = memEdit.memberName;
            txtEditMemberAdres.Text = memEdit.memberAdress;
            txtEditMemberEmail.Text = memEdit.memberEmail;
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            changeMember();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                Member memberId = getMember(memList.SelectedItem.ToString());
                Article articleId = getArticle(lbList.SelectedItem.ToString());

                ReserveArticle(memberId.memberId, articleId.ArticleID);
            }
            catch(Exception)
            {
                MessageBox.Show("gaga");
            }
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Member memberId = getMember(memList.SelectedItem.ToString());
            Article articleId = getArticle(lbList.SelectedItem.ToString());

            loan(memberId.memberId, articleId.ArticleID);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Member memberId = getMember(memList.SelectedItem.ToString());
            Article articleId = getArticle(lbList.SelectedItem.ToString());

            returnArticle(memberId.memberId, articleId.ArticleID);
        }
    }
}