using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace QLHS
{
    class KetNoi
    {
        public static SqlConnection ConnectDB()
        {
            string connString = @"Data Source=.;Initial Catalog=QlySinhVien;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            return con;
        }
    }
}
