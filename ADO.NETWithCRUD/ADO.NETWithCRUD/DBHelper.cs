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
            //TODO: Add connection link
            return new SqlConnection("");
        }
    }
}
