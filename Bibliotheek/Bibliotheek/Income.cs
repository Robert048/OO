using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    class Income
    {
        public float totaalReserveringKosten { get; set; }
        public float totaalBoeteKosten { get; set; }
        public float totaalCdInkomsten { get; set; }
        public float totaalDvdInkomsten { get; set; }

        /// <summary>
        /// create a new income
        /// </summary>
        public Income()
        {
            totaalReserveringKosten = 0.00F;
            totaalBoeteKosten = 0.00F;
            totaalCdInkomsten = 0.00F;
            totaalDvdInkomsten = 0.00F;
        }
    }
}
