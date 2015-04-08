using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    /// <summary>
    /// Types of books
    /// </summary>
    enum BookType
    {
        ROMAN,
        STUDY
    }
    class Book : Article
    {
        // constant variables
        public const float LOAN_COSTS_BOOK = 0.00F;
        public const int COSTFREE_LOAN_PERIOD = 21; // in dagen

        public BookType BookType { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// Initializes a new instance of the <see cref="Article"/> class.
        /// </summary>
        /// <param name="bookType">Type of the book.</param>
        /// <param name="ArticleID">The article identifier.</param>
        /// <param name="Title">The title.</param>
        public Book(BookType bookType, int ArticleID, string Title) 
            : base(ArticleID, Title)
        {
            BookType = bookType;
        }
    }
}
