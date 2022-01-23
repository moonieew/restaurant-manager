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
    class NHANVIEN
    {
        MYDB db = new MYDB();
        public bool insertEmployee(string id, string name, string address, string phone, MemoryStream picture, string password, string author)
        {
            SqlCommand command = new SqlCommand("insert into nhanvien values(@id,@name,@add,@phone,@pic,@pass,@author)", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@add", address);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@pic", picture.ToArray());
            command.Parameters.AddWithValue("@pass", password);
            command.Parameters.AddWithValue("@author", author);
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
        public bool updateEmployee(string id, string name, string address, string phone, MemoryStream picture, string password, string author)
        {
            SqlCommand command = new SqlCommand("update nhanvien set name=@name, address=@add, " +
                "phone = @phone, picture=@pic, password=@pass,Author=@author where id =@id", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@add", address);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@pic", picture.ToArray());
            command.Parameters.AddWithValue("@pass", password);
            command.Parameters.AddWithValue("@author", author);
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
        public bool deleteEmployee(string id)
        {
            SqlCommand command = new SqlCommand("delete from nhanvien where id = @id ", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            db.openConnection();
            if ((command.ExecuteNonQuery() > 0))
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
        public bool CheckEmployee(string id)
        {
            string query = "select * from nhanvien where id <> @id";
            SqlCommand command = new SqlCommand(query, db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            db.openConnection();
            if (table.Rows.Count > 0)
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
        public DataTable getEmployee()
        {
            SqlCommand command = new SqlCommand("select * from nhanvien", db.getSqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
