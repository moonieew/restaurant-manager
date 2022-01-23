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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        MYDB db = new MYDB();

        bool veryif()
        {
            if ((tb_id.Text.Trim() == "") || (tb_pass.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            if (veryif())
            {
                if (rBt_quanly.Checked)
                {
                    string userid = tb_id.Text;
                    string pass = tb_pass.Text;
                    SqlCommand cmd = new SqlCommand("select * from nhanvien where id=@id and password=@pass and Author='Admin'", db.getSqlConnection);
                    cmd.Parameters.AddWithValue("@id", userid);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MainForm form = new MainForm();
                        this.Hide();
                        Global.setGlobalUserID(userid);
                        form.menuStrip1.Visible = true;
                        form.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if(rBt_nhanvien.Checked)
                {
                    string userid = tb_id.Text;
                    string pass = tb_pass.Text;
                    SqlCommand cmd = new SqlCommand("select * from nhanvien where id=@id and password=@pass and Author='Member'", db.getSqlConnection);
                    cmd.Parameters.AddWithValue("@id", userid);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MainForm form = new MainForm();
                        this.Hide();
                        Global.setGlobalUserID(userid);
                        form.menuStrip1.Visible = false;
                        form.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (radioButtonCustom.Checked)
                {
                    Customer TM = new Customer();
                    this.Hide();
                    TM.ShowDialog();
                    this.Show();

                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống ID/Pass", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_diemdanh_Click(object sender, EventArgs e)
        {
            AttendanceForm form = new AttendanceForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            rBt_nhanvien.Checked = true;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
