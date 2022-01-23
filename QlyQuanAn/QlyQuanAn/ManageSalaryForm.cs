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
    public partial class ManageSalaryForm : Form
    {
        public ManageSalaryForm()
        {
            InitializeComponent();
        }
        MYDB db = new MYDB();

        void fillGrid()
        {
            dGv_diemdanh.DataSource = getFullList();
        }
        public DataTable getFullList()
        {
            string dieukien = "";
            if (tb_search.Text.Trim() != "")
            {
                dieukien += " CONCAT(diemdanh.id,name) LIKE '%" + tb_search.Text.Trim() + "%' and ";
            }
            SqlCommand command = new SqlCommand("select diemdanh.id as ID,name as Name,ngay as Ngay,Time_in1 as TimeIn1," +
                " Time_out1 as TimeOut1,Time_in2 as TimeIn2,Time_out2 as TimeOut2, checkDate as CheckSalary" +
                " ,Salary" +
                " from diemdanh inner join nhanvien on nhanvien.id = diemdanh.id" +
                " where " + dieukien +
                " ngay between @fromdate and @todate", db.getSqlConnection);
            command.Parameters.AddWithValue("@fromdate", dTpfromdate.Value);
            command.Parameters.AddWithValue("@todate", dTptodate.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertSalary(string id, double salary,DateTime ngay)
        {
            SqlCommand command = new SqlCommand("update diemdanh set checkDate=@check,Salary=@sal where id=@id" +
                " and ngay = @ngay", db.getSqlConnection);
            command.Parameters.AddWithValue("@check", 1);
            command.Parameters.AddWithValue("@sal", salary);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@ngay", ngay);
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
        public bool checkDiemdanh(string id)
        {
            SqlCommand command = new SqlCommand("select * from diemdanh where id=@id and checkDate=1", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", id);
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

        private void ManageSalaryForm_Load(object sender, EventArgs e)
        {
            fillGrid();
            dTpfromdate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dTptodate.Value = dTpfromdate.Value.AddMonths(1).AddDays(-1);
        }

        private void dGv_diemdanh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime timein1;
            DateTime timein2;
            DateTime timeout1;
            DateTime timeout2;
            string id = dGv_diemdanh.CurrentRow.Cells[0].Value.ToString();
            timein1 = Convert.ToDateTime(dGv_diemdanh.CurrentRow.Cells[3].Value);
            timeout1 = Convert.ToDateTime(dGv_diemdanh.CurrentRow.Cells[4].Value);
            double totalhours = (timeout1 - timein1).TotalHours;
            DateTime ngay = Convert.ToDateTime(dGv_diemdanh.CurrentRow.Cells[2].Value);
            if (dGv_diemdanh.CurrentRow.Cells[5].Value.ToString().Trim() != "" && dGv_diemdanh.CurrentRow.Cells[6].Value.ToString().Trim() != "")
            {
                timein2 = Convert.ToDateTime(dGv_diemdanh.CurrentRow.Cells[5].Value);
                timeout2 = Convert.ToDateTime(dGv_diemdanh.CurrentRow.Cells[6].Value);
                totalhours = totalhours + (timeout2 - timein2).TotalHours;
            }
            double salary = 0;
            if (totalhours < 8.5 && totalhours >= 8)
            {
                salary = 50000 * 8;
            }
            else if (totalhours < 8 && totalhours >= 7)
            {
                salary = 50000 * 8 - 100000;
            }
            else if (totalhours < 7 && totalhours >= 5)
            {
                salary = 50000 * 8 - 200000;
            }
            else if (totalhours < 5 && totalhours >= 3)
            {
                salary = 50000 * 8 - 300000;
            }
            else
            {
                salary = 0;
            }
            if (MessageBox.Show("Tính lương cho nhân viên này ? ", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (checkDiemdanh(id))
                {
                    if (insertSalary(id, salary,ngay))
                    {
                        MessageBox.Show("Tính lương thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tính lương thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Đã tính lương cho người này", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                fillGrid();
            }
        }

        private void bt_check_Click(object sender, EventArgs e)
        {
            fillGrid();
            lb_count.Text = "Count Row : " + dGv_diemdanh.Rows.Count.ToString();
        }

        private void bt_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_sortThang_Click(object sender, EventArgs e)
        {
            dTpfromdate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dTptodate.Value = dTpfromdate.Value.AddMonths(1).AddDays(-1);
        }

        private void bt_sortTuan_Click(object sender, EventArgs e)
        {
            dTpfromdate.Value = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
            dTptodate.Value = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek+7);
        }
    }
}
