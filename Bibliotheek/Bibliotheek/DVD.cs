using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    enum DVDType
    {
        A,
        B
    }

    class DVD : Article
    {
        public const float LOAN_COSTS = 0.00F;

        public DVDType DVDType { get; private set; }

        public DVD(DVDType dvdType, int ArticleID, string Title)
            : base(ArticleID, Title)
        {
            DVDType = dvdType;
        }
    }
}
