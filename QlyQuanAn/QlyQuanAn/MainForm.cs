using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyQuanAn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        MYDB db = new MYDB();

        private void attendanceRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRecordForm form = new ManageRecordForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void salaryRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSalaryForm form = new ManageSalaryForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void employeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployeeForm form = new ManageEmployeeForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void foodControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void employeeScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScheduleForm form = new AddScheduleForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void bt_mon_Click(object sender, EventArgs e)
        {
            Customer form = new Customer();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void bt_bep_Click(object sender, EventArgs e)
        {
            KitchenForm form = new KitchenForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            getImageandUsername();
        }
        public void getImageandUsername()
        {
            SqlCommand command = new SqlCommand("select * from nhanvien where id = @id", db.getSqlConnection);
            command.Parameters.AddWithValue("@id", Global.GlobalUserID);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0][4];
                MemoryStream picture = new MemoryStream(pic);
                pb_user.Image = Image.FromStream(picture);
                string user = table.Rows[0][0].ToString().Trim();
                string name1 = table.Rows[0][1].ToString().Trim();
                string author = table.Rows[0][6].ToString().Trim();
                lb_hello.Text = "Welcome back ( " + user + " )\n" + author + "\n" + name1;
            }
        }

        private void linklb_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
