using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    enum DVDType
    {
        AMOVIE,
        BMOVIE
    }

    class DVD : Article
    {
        public const float LOAN_COSTS_DVD = 0.00F;

        public DVDType DVDType { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DVD"/> class.
        /// </summary>
        /// <param name="dvdType">Type of the DVD.</param>
        /// <param name="ArticleID">The article identifier.</param>
        /// <param name="Title">The title.</param>
        public DVD(DVDType dvdType, int ArticleID, string Title)
            : base(ArticleID, Title)
        {
            DVDType = dvdType;
        }
    }
}
