using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyQuanAn
{
    class DIEMDANH
    {
        MYDB db = new MYDB();
        public bool insertTime(string id)
        {
            //string ngay = DateTime.Now.ToShortDateString();
            string timein = DateTime.Now.ToShortTimeString();
            SqlCommand command = new SqlCommand("insert into diemdanh(id,ngay,Time_in1,status) values" +
                "(@id,@ngay,@timein,@stt)", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@ngay", DateTime.Now.Date);
            command.Parameters.AddWithValue("@timein", timein);
            command.Parameters.AddWithValue("@stt", 1);
            db.openConnection();

            if (command.ExecuteNonQuery() > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool updateTime(string id, string ex)
        {
            string time = DateTime.Now.ToShortTimeString();
            SqlCommand command = new SqlCommand();
            if (ex == "1")
            {
                command.CommandText = "update diemdanh set Time_out1=@time,status=@stt where id=@id";
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@stt", 0);
            }
            else if (ex == "2")
            {
                command.CommandText = "update diemdanh set Time_in2=@time,status=@stt where id=@id";
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@stt", 1);
            }
            else if (ex == "3")
            {
                command.CommandText = "update diemdanh set Time_out2=@time,status=@stt where id=@id";
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@stt", 0);
            }
            command.Connection = db.getSqlConnection;


            db.openConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }

        public DataTable getListtoDay()
        {
            //string ngay = DateTime.Now.ToShortDateString();
            SqlCommand command = new SqlCommand("select id as ID,ngay as Ngay,Time_in1 as TimeIn1," +
                " Time_out1 as TimeOut1,Time_in2 as TimeIn2,Time_out2 as TimeOut2,status as Status" +
                " from diemdanh where ngay=@ngay", db.getSqlConnection);
            command.Parameters.AddWithValue("@ngay", DateTime.Now.Date);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
