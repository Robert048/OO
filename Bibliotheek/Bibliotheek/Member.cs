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

        /// <summary>
        /// Create a new member of member class
        /// </summary>
        /// <param name="memberId">id of the member</param>
        /// <param name="memberName">name of the member</param>
        /// <param name="memberAdress">adress of the member</param>
        /// <param name="memberEmail">email of the member</param>
        public Member(int memberId,string memberName,string memberAdress,string memberEmail)
        {
            this.memberId = memberId;
            this.memberName = memberName;
            this.memberAdress = memberAdress;
            this.memberEmail = memberEmail;
        }

    }
}
