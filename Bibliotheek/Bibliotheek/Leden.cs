using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    class Leden
    {
        public int lidId
        {
            get
            {
                return lidId;
            }

            set
            {
                lidId = value;
            }
        }

        public string naam
        {
            get
            {
                return naam;
            }

            set
            {
                naam = value;
            }
        }

        public string adres
        {
            get
            {
                return adres;
            }

            set
            {
                adres = value;
            }
        }

        public string email
        {
            get
            {
                return email;
            }

            set
            {
                email = value; 
            }
        }

        public int aantalArtikelen
        {
            get
            {
                return aantalArtikelen;
            }

            set
            {
                aantalArtikelen = value;
            }
        }
    }
}
