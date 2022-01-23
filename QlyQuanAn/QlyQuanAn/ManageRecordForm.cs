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
    public partial class ManageRecordForm : Form
    {
        public ManageRecordForm()
        {
            InitializeComponent();
        }
        DIEMDANH diemdanh = new DIEMDANH();
        MYDB db = new MYDB();

        void fillGrid()
        {
            dGv_diemdanh.DataSource = getListbyDate();
        }
        public DataTable getListbyDate()
        {
            string dieukien = "";
            if (rBt_absent.Checked)
            {
                dieukien = "(Time_out1 is null or Time_in2 is null or Time_out2 is null) and ";
            }
            else if (rBt_late.Checked)
            {
                dieukien = "((convert(datetime,Time_out1)-convert(datetime, Time_in1)) < '03:00:00'" +
                    " or (convert(datetime,Time_out2)-convert(datetime, Time_in2)) < '03:00:00') and ";
            }
            if (tb_search.Text.Trim() != "")
            {
                dieukien += " CONCAT(nhanvien.id,name) LIKE '%" + tb_search.Text + "%' and ";
            }
            SqlCommand command = new SqlCommand("select nhanvien.id as ID,name as Name,ngay as Ngay,Time_in1 as TimeIn1," +
                " Time_out1 as TimeOut1,Time_in2 as TimeIn2,Time_out2 as TimeOut2,status as Status" +
                " from diemdanh inner join nhanvien on nhanvien.id = diemdanh.id where " + dieukien +
                " ngay >= @fromdate and ngay <= @todate", db.getSqlConnection);
            command.Parameters.AddWithValue("@fromdate", dTpfromdate.Value);
            command.Parameters.AddWithValue("@todate", dTptodate.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void ManageRecordForm_Load(object sender, EventArgs e)
        {
            fillGrid();
            rBt_none.Checked = true;
            dTpfromdate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dTptodate.Value = dTpfromdate.Value.AddMonths(1).AddDays(-1);
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
            dTptodate.Value = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 7);
        }
    }
}
