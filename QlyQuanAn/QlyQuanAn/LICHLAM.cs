using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyQuanAn
{
    class LICHLAM
    {
        MYDB db = new MYDB();
        public bool insertLich(string id, int ca1, int ca2, string thu)
        {
            SqlCommand command = new SqlCommand("insert into lichlam values(@id,@ca1,@ca2,@thu)", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@ca1", ca1);
            command.Parameters.AddWithValue("@ca2", ca2);
            command.Parameters.AddWithValue("@thu", thu);

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
        public bool updateLich(string id, int ca1, int ca2, string thu)
        {
            SqlCommand command = new SqlCommand("update lichlam set id=@id,ca1=@ca1,ca2=@ca2,thu=@thu" +
                " where id=@id and thu=@thu", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@ca1", ca1);
            command.Parameters.AddWithValue("@ca2", ca2);
            command.Parameters.AddWithValue("@thu", thu);

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
        public bool deleteLich(string id, string thu)
        {
            SqlCommand command = new SqlCommand("delete from lichlam where id=@id and thu=@thu", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@thu", thu);
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
        public DataTable getLich()
        {
            SqlCommand command = new SqlCommand("select name as Name,lichlam.id as ID,ca1 as [Ca 1],ca2 as [Ca 2],thu as Thu from lichlam" +
                ",nhanvien where lichlam.id=nhanvien.id", db.getSqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkLich(string id, string thu)
        {
            SqlCommand command = new SqlCommand("select id,thu from lichlam where id=@id and thu=@thu", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@thu", thu);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
