using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    abstract class Article
    {
        public const float RESERVATION_COSTS = 0.30f;
        public DateTime ArticleReturnDate { get; set; }
        public string Title { get; set; }
        public int ArticleID { get; set; }
        public int LoanStatus { get; set; }
        public Dictionary<int, DateTime> ReservationsList { get; set; }
        public int TimesLoaned { get; set; }
        public int LoanedPeriode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Article"/> class.
        /// </summary>
        /// <param name="ArticleID">The article identifier.</param>
        /// <param name="Title">The title.</param>
        public Article(int ArticleID, string Title)
        {
            this.ArticleID = ArticleID;
            this.Title = Title;
        }
    }
}
