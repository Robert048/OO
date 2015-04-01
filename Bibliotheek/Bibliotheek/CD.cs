using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    enum CDType
    {
        POP,
        CLASSIC
    }

    class CD : Article
    {
        public const float LOAN_COSTS_CD = 0.00F;
        public int CdAge { get; set; }

        public CDType CDType { get; private set; }

        public CD(CDType cdType, int ArticleID, string Title)
            : base(ArticleID, Title)
        {
            CDType = cdType;
        }
    }
}
