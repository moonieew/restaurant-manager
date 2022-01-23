using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyQuanAn
{
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
        }
        DIEMDANH diemdanh = new DIEMDANH();
        MYDB db = new MYDB();

        void fillGrid()
        {
            dGv_atten.ReadOnly = true;
            dGv_atten.RowHeadersVisible = false;
            dGv_atten.AllowUserToResizeColumns = false;
            dGv_atten.DataSource = diemdanh.getListtoDay();
        }
        bool veryif()
        {
            if (tb_id.Text.Trim() == "" || tb_pass.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool checkTimeIn1(string id)
        {
            //string ngay = DateTime.Now.ToShortDateString();
            SqlCommand command = new SqlCommand("select * from diemdanh where id=@id and ngay=@ngay", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@ngay", DateTime.Now.Date);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        bool checkTimeOut1(string id)
        {
            //string ngay = DateTime.Now.ToShortDateString();
            SqlCommand command = new SqlCommand("select * from diemdanh where id=@id " +
                "and Time_in1 is not null and Time_out1 is null " +
                "and Time_in2 is null and Time_out2 is null and ngay=@ngay", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@ngay", DateTime.Now.Date);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool checkTimeIn2(string id)
        {
            //string ngay = DateTime.Now.ToShortDateString();
            SqlCommand command = new SqlCommand("select * from diemdanh where id=@id " +
                "and Time_in1 is not null and Time_out1 is not null " +
                "and Time_in2 is null and Time_out2 is null and ngay=@ngay", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@ngay", DateTime.Now.Date);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool checkTimeOut2(string id)
        {
            //string ngay = DateTime.Now.ToShortDateString();
            SqlCommand command = new SqlCommand("select * from diemdanh where id=@id " +
                "and Time_in1 is not null and Time_out1 is not null " +
                "and Time_in2 is not null and Time_out2 is null and ngay=@ngay", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@ngay", DateTime.Now.Date);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Dangnhap(string id, string password)
        {
            SqlCommand command = new SqlCommand("select id,password from nhanvien where id = @id and password =@pass", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@pass", password);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void bt_timein_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string password = tb_pass.Text;
            if (veryif())
            {
                if (Dangnhap(id, password))
                {
                    if (checkTimeIn1(id))
                    {
                        if (diemdanh.insertTime(id))
                        {
                            MessageBox.Show("Thêm thành công", "Nhắc nhở", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại", "Nhắc nhở", MessageBoxButtons.OK);
                        }
                    }
                    else if (checkTimeIn2(id))
                    {
                        if (diemdanh.updateTime(id, "2"))
                        {
                            MessageBox.Show("Thêm thành công", "Nhắc nhở", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại", "Nhắc nhở", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa TIMEOUT", "Nhắc nhở", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Sai ID hoặc Password", "Nhắc nhở", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Nhắc nhở", MessageBoxButtons.OK);
            }
            fillGrid();
        }

        private void bt_timeout_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string password = tb_pass.Text;
            string ngay = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToShortTimeString();
            if (veryif())
            {
                if (Dangnhap(id, password))
                {
                    if (checkTimeOut1(id))
                    {
                        if (diemdanh.updateTime(id, "1"))
                        {
                            MessageBox.Show("Thêm thành công", "Nhắc nhở", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại", "Nhắc nhở", MessageBoxButtons.OK);
                        }
                    }
                    else if (checkTimeOut2(id))
                    {
                        if (diemdanh.updateTime(id, "3"))
                        {
                            MessageBox.Show("Thêm thành công", "Nhắc nhở", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại", "Nhắc nhở", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa TIMEIN", "Nhắc nhở", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Sai ID hoặc Password", "Nhắc nhở", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Nhắc nhở", MessageBoxButtons.OK);
            }
            fillGrid();
        }

        private void bt_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
