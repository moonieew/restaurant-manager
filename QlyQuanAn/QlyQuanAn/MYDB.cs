using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyQuanAn
{
    class MYDB
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-L2I9TPJ\SQLEXPRESS;Initial Catalog=QuanLyMonAn;Integrated Security=True");
        public SqlConnection getSqlConnection
        {
            get
            { return conn; }
        }
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
