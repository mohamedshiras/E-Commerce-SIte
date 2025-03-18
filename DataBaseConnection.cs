using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CourseWork
{
    internal class DataBaseConnection
    {
        String connection = @"Data Source=CHIYA\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=true;";
    
        public SqlConnection DBcon()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            return con;
        }

    }

}
