using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETWithCRUD
{
    static class MemberDB
    {
        public static List<Member> GetAllMembers()
        {
            var selCommand = new SqlCommand();
            selCommand.Connection = DBHelper.GetConnection();
            selCommand.CommandText =
                "SELECT MemberID, BirthDate, FirstName, LastName, FavoriteAnimal " +
                "FROM Member";

            try
            {
                selCommand.Connection.Open();
                SqlDataReader rdr = selCommand.ExecuteReader();
                var memberList = new List<Member>();
                while (rdr.Read())
                {
                    var member = new Member();
                    member.MemberID = (int)rdr["CustomerID"];
                    member.BirthDate = (DateTime)rdr["BirthDate"];
                    member.FirstName = (string)rdr["FirstName"];
                    member.LastName = (string)rdr["LastName"];
                    member.FavoriteAnimal = (string)rdr["FavoriteAnimal"];
                    memberList.Add(member);
                }
                return memberList;
            }
            finally
            {
                selCommand.Connection.Dispose();
            }
        }

        public static bool Add(Member newMember)
        {
            SqlConnection dbConnection = DBHelper.GetConnection();

            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = dbConnection;
            addCommand.CommandText = "INSERT INTO Member " +
            "(FirstName, LastName, BirthDate, FavoriteAnimal) " +
        "VALUES" +
            "(@firstname, @lastname, @birthdate, @favoriteanimal)";

            addCommand.Parameters.AddWithValue("@firstname", newMember.FirstName);
            addCommand.Parameters.AddWithValue("@lastname", newMember.LastName);
            addCommand.Parameters.AddWithValue("@birthdate", newMember.BirthDate);
            addCommand.Parameters.AddWithValue("@favoriteanimal", newMember.FavoriteAnimal);

            try
            {
                dbConnection.Open();
                int rowsAffected = addCommand.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    return true;
                }
                return false;
            }
            finally
            {
                dbConnection.Dispose();
            }
        }
        public static bool Update(Member currMember)
        {
            SqlCommand updateCmd = new SqlCommand();
            updateCmd.CommandText = "UPDATE Member " +
                                    "SET FirstName = @firstname, " +
                                    "LastName = @lastname, " +
                                    "BirthDate = @birthdate, " +
                                    "FavoriteAnimal = @favoriteanimal " +
                                    "WHERE MemberID = @memberid";
            updateCmd.Parameters.AddWithValue("@firstname", currMember.FirstName);
            updateCmd.Parameters.AddWithValue("@lastname", currMember.LastName);
            updateCmd.Parameters.AddWithValue("@birthdate", currMember.BirthDate);
            updateCmd.Parameters.AddWithValue("@favoriteanimal", currMember.FavoriteAnimal);
            updateCmd.Parameters.AddWithValue("@memberid", currMember.MemberID);
            using (SqlConnection con = DBHelper.GetConnection())
            {
                updateCmd.Connection = con;
                con.Open();

                int rows = updateCmd.ExecuteNonQuery();
                if (rows == 1)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
