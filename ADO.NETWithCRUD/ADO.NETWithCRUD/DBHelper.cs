using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETWithCRUD
{
    class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MembersDB;Integrated Security=True");
        }
    }
}
