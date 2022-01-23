using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyQuanAn
{
    public partial class ManageEmployeeForm : Form
    {
        public ManageEmployeeForm()
        {
            InitializeComponent();
        }
        NHANVIEN nv = new NHANVIEN();
        void fillGird()
        {
            dGv_employee.ReadOnly = true;
            dGv_employee.AllowUserToResizeRows = false;
            dGv_employee.RowTemplate.Height = 100;
            dGv_employee.DataSource = nv.getEmployee();

            DataGridViewImageColumn Pic = new DataGridViewImageColumn();
            Pic = (DataGridViewImageColumn)dGv_employee.Columns[4];
            Pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            lb_total.Text = "Total : " + dGv_employee.Rows.Count.ToString();
        }

        bool veryif()
        {
            if (tb_id.Text.Trim() == ""
                || tb_address.Text.Trim() == ""
                || tb_name.Text.Trim() == ""
                || tb_phone.Text.Trim() == ""
                || tb_pass.Text.Trim() == "")
            //|| pb_image.Image==null)
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
            string id = tb_id.Text;
            string name = tb_name.Text;
            string address = tb_address.Text;
            string phone = tb_phone.Text;
            MemoryStream pic = new MemoryStream();
            string password = tb_pass.Text;
            string author = cb_author.Text.Trim();
            if (veryif())
            {
                if (nv.CheckEmployee(id))
                {
                    pb_image.Image.Save(pic, pb_image.Image.RawFormat);
                    if (nv.insertEmployee(id, name, address, phone, pic, password, author))
                    {
                        MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_id.Clear();
                        tb_name.Clear();
                        tb_address.Clear();
                        tb_phone.Clear();
                        tb_pass.Clear();
                        pb_image.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Trùng ID với nhân viên khác", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fillGird();
        }
        private void dGv_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Binding textbox
            tb_id.Text = dGv_employee.CurrentRow.Cells[0].Value.ToString();
            tb_name.Text = dGv_employee.CurrentRow.Cells[1].Value.ToString();
            tb_address.Text = dGv_employee.CurrentRow.Cells[2].Value.ToString();
            tb_phone.Text = dGv_employee.CurrentRow.Cells[3].Value.ToString();
            tb_pass.Text = dGv_employee.CurrentRow.Cells[5].Value.ToString();
            cb_author.Text = dGv_employee.CurrentRow.Cells[6].Value.ToString();
            //Binding combobox
            byte[] pic = (byte[])dGv_employee.CurrentRow.Cells[4].Value;
            MemoryStream picture = new MemoryStream(pic);
            pb_image.Image = Image.FromStream(picture);
        }
        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (tb_id.Text.Trim() != "")
            {
                string id = tb_id.Text.Trim();
                if (MessageBox.Show("Xoá nhân viên ?", "Nhắc nhở", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nv.deleteEmployee(id))
                    {
                        MessageBox.Show("Xoá nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_id.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xoá nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Điền ID cần xoá", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGird();
        }
        private void bt_edit_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string address = tb_address.Text;
            string phone = tb_phone.Text;
            MemoryStream pic = new MemoryStream();
            string password = tb_pass.Text;
            string author = cb_author.Text.Trim();
            if (veryif())
            {
                if (nv.CheckEmployee(id))
                {
                    pb_image.Image.Save(pic, pb_image.Image.RawFormat);
                    if (nv.updateEmployee(id, name, address, phone, pic, password, author))
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_id.Clear();
                        tb_name.Clear();
                        tb_address.Clear();
                        tb_phone.Clear();
                        tb_pass.Clear();
                        pb_image.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thất bại", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Trùng ID với nhân viên khác", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fillGird();
        }

        private void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            fillGird();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                Image pic = Image.FromFile(file.FileName);
                pb_image.Image = pic;
            }
        }

        private void bt_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
