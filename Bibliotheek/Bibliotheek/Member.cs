using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    class Member
    {
        private int memberId { get; set; }
        private string memberName { get; set; }
        private string memberAdress { get; set; }
        private string memberEmail { get; set; }
        private int aantalArtikelen { get; set; }

        public Member(int memberId,string memberName,string memberAdress,string memberEmail)
        {
            this.memberId = memberId;
            this.memberName = memberName;
            this.memberAdress = memberAdress;
            this.memberEmail = memberEmail;
        }

    }
}
