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
    public partial class AddScheduleForm : Form
    {
        public AddScheduleForm()
        {
            InitializeComponent();
        }
        MYDB db = new MYDB();
        LICHLAM lich = new LICHLAM();
        void fillGrid()
        {
            cb_id.DataSource = getID();
            cb_id.DisplayMember = "name";
            cb_id.ValueMember = "id";
            dGv_lich.DataSource = lich.getLich();
        }
        public DataTable getID()
        {
            SqlCommand command = new SqlCommand("select * from nhanvien", db.getSqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        bool veryif()
        {
            if (cb_id.Text == "" || cb_ca1.Text == "" || cb_ca2.Text == "" || cb_thu.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            string id = cb_id.SelectedValue.ToString();
            string thu = cb_thu.Text.Trim();
            int ca1 = Convert.ToInt32(cb_ca1.Text.Trim());
            int ca2 = Convert.ToInt32(cb_ca2.Text.Trim());
            if (veryif())
            {
                if (lich.checkLich(id, thu) && ca1 != ca2)
                {
                    if (lich.insertLich(id, ca1, ca2, thu))
                    {
                        MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Trùng ngày hoặc trùng ca", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fillGrid();
        }

        private void AddScheduleForm_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
        private void dGv_lich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_id.SelectedValue = dGv_lich.CurrentRow.Cells[1].Value;
            cb_ca1.Text = dGv_lich.CurrentRow.Cells[2].Value.ToString();
            cb_ca2.Text = dGv_lich.CurrentRow.Cells[3].Value.ToString();
            cb_thu.Text = dGv_lich.CurrentRow.Cells[4].Value.ToString();
        }
        private void dGv_lich_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dGv_lich.CurrentRow.Cells[0].Value.ToString();
            string thu = dGv_lich.CurrentRow.Cells[3].Value.ToString();

            if (MessageBox.Show("Xoá hàng này ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lich.deleteLich(id, thu))
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            fillGrid();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string id = cb_id.SelectedValue.ToString();
            string thu = cb_thu.Text.Trim();
            int ca1 = Convert.ToInt32(cb_ca1.Text.Trim());
            int ca2 = Convert.ToInt32(cb_ca2.Text.Trim());
            if (veryif())
            {
                if (!lich.checkLich(id, thu) && ca1 != ca2)
                {
                    if (lich.updateLich(id, ca1, ca2, thu))
                    {
                        MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Trùng ngày hoặc trùng ca", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fillGrid();
        }

        private void bt_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
