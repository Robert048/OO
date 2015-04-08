using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    class Income
    {
        public int totaalReserveringKosten { get; set; }
        public int totaalBoeteKosten { get; set; }
        public int totaalCdInkomsten { get; set; }
        public int totaalDvdInkomsten { get; set; }

        /// <summary>
        /// create a new income
        /// </summary>
        public Income()
        {

        }
    }
}
