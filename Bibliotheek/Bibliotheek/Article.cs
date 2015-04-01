using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    abstract class Article
    {
        public const float RESERVATION_COSTS = 0.90f;
        public DateTime BroughtBackDate { get; set; }
        public string Title { get; set; }
        public int ArticleID { get; set; }
        public int LoanStatus { get; set; }
        public List<int> ReservationsList { get; set; }
        public int LoanedHours { get; set; }
        public int LoanedDate { get; set; }
        
        public Article(int ArticleID, string Title)
        {
            this.ArticleID = ArticleID;
            this.Title = Title;
        }
    }
}
