﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    /// <summary>
    /// Types of cds
    /// </summary>
    enum CDType
    {
        POP,
        CLASSIC
    }

    class CD : Article
    {
        // The age of the current cd instance
        public int CdAge { get; set; }
        // The type of the current cd instance
        public CDType CDType { get; private set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="CD"/> class.
        /// Initializes a new instance of the <see cref="Article"/> class.
        /// </summary>
        /// <param name="cdType">Type of the cd.</param>
        /// <param name="ArticleID">The article identifier.</param>
        /// <param name="Title">The title.</param>
        public CD(CDType cdType, int ArticleID, string Title, int cdAge)
            : base(ArticleID, Title)
        {
            CDType = cdType;
            CdAge = cdAge;
        }
    }
}
