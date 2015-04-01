using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    enum BookType
    {
        ROMAN,
        STUDY
    }

    class Book : Article
    {
        public const float LOAN_COSTS = 0.00F;
        public const int COSTS_DAYS = 21; // in dagen

        public BookType BookType { get; private set; }

        public Book(BookType bookType, int ArticleID, string Title) 
            : base(ArticleID, Title)
        {
            BookType = bookType;
        }
    }
}
