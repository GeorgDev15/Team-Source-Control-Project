using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamSourceControlProject.Models
{
    /// <summary>
    /// contains basic information for a member to be added into simple database.
    /// </summary>
    public class Members
    {
        
        public int MemberID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string FavoriteAnimal { get; set; }
    }
}