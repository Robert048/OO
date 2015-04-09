 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    abstract class Article
    {
        // constant variables
        public const float RESERVATION_COSTS = 0.30f;
        // The return date of the article
        public DateTime ArticleReturnDate { get; set; }
        // The title of the current article
        public string Title { get; set; }
        // The identifier of the current article
        public int ArticleID { get; set; }
        // The status of loan
        public bool LoanStatus { get; set; }
        // The date of loan
        public DateTime LoanDate { get; set; }
        // The member to the loan
        public int LoanMember { get; set; }
        // The reservation list for the current instance
        public Dictionary<int, DateTime> ReservationsList { get; set; }
        // Times the object was loaned
        public int TimesLoaned { get; set; }
        // The periode of loan
        public int LoanedPeriod { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Article"/> class.
        /// </summary>
        /// <param name="ArticleID">The article identifier.</param>
        /// <param name="Title">The title.</param>
        public Article(int ArticleID, string Title)
        {
            this.ArticleID = ArticleID;
            this.Title = Title;
            ReservationsList = new Dictionary<int,DateTime>();
            ArticleReturnDate = new DateTime();
            TimesLoaned = 0;
            LoanedPeriod = 0;
            LoanStatus = false;
        }
    }
}
