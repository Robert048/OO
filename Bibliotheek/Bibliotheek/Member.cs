using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    class Member
    {
        public int memberId { get; set; }
        public string memberName { get; set; }
        public string memberAdress { get; set; }
        public string memberEmail { get; set; }
        public int aantalArtikelen { get; set; }

        public Member(int memberId,string memberName,string memberAdress,string memberEmail)
        {
            this.memberId = memberId;
            this.memberName = memberName;
            this.memberAdress = memberAdress;
            this.memberEmail = memberEmail;
        }

    }
}
