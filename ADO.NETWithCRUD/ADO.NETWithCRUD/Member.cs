using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETWithCRUD
{
    class Member
    {
        public int MemberID { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteAnimal { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
