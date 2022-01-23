using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyQuanAn
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            LoadFoodList();
            LoadListBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);
            comboBoxCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "id";
            // LoadCategoryIntoCombobox(comboBoxCategory);
            AddFoodBinding();
            LoadTableList();
            LoadStatusIntoCombobox(comboBoxTable);
            AddTableBinding();
            LoadSortFood(dateTimePicker3.Value, dateTimePicker4.Value);
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker3.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
            dateTimePicker4.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
            LoadMaterialList();
            AddMaterialBinding();
            LoadCongThuc();
            LoadNameFoodIntoCombobox(comboBoxNameFood);
            LoadNameMaterialIntoCombobox(comboBoxMaterial);
            LoadSLMon();
            LoadNameFoodIntoCombobox(comboBoxFood);
        }
        void LoadFoodList()
        {
            dataGridViewFood.DataSource = FoodDAO.Instance.GetListFood();
        }
        void LoadSLMon()
        {
            dataGridViewSLMon.DataSource = FoodDAO.Instance.getSLMon();
        }
        void LoadCongThuc()
        {
            dataGridViewCongThuc.DataSource = FoodDAO.Instance.getCongThuc();
        }
        void LoadMaterialList()
        {
            dataGridViewMaterial.DataSource = MaterialDAO.Instance.GetListMaterial();
        }
        void LoadTableList()
        {
            dataGridViewTable.DataSource = TableDAO.Instance.GetListTable();
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dataGridViewBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        void LoadSortFood(DateTime checkIn, DateTime checkOut)
        {
            dataGridViewSortFood.DataSource = BillDAO.Instance.GetSortFood(checkIn, checkOut);
        }

        private void buttonViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void buttonViewFood_Click(object sender, EventArgs e)
        {
            LoadFoodList();
        }
        /*void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }*/
        void LoadNameFoodIntoCombobox(ComboBox cb)
        {
            cb.DataSource = FoodDAO.Instance.GetListFood();
            cb.DisplayMember = "Name";
        }
        void LoadNameMaterialIntoCombobox(ComboBox cb)
        {
            cb.DataSource = MaterialDAO.Instance.GetListMaterial();
            cb.DisplayMember = "Name";
        }
        void LoadStatusIntoCombobox(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.GetListTable();
            cb.DisplayMember = "Status";
        }
        void AddFoodBinding()
        {
            textBoxNameFood.DataBindings.Add(new Binding("Text", dataGridViewFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            textBoxID.DataBindings.Add(new Binding("Text", dataGridViewFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            numericUpDownFoodPrice.DataBindings.Add(new Binding("Value", dataGridViewFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void AddTableBinding()
        {
            textBoxNameTable.DataBindings.Add(new Binding("Text", dataGridViewTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
            textBoxIdTable.DataBindings.Add(new Binding("Text", dataGridViewTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }
        void AddMaterialBinding()
        {
            textBoxNameMaterial.DataBindings.Add(new Binding("Text", dataGridViewMaterial.DataSource, "Name", true, DataSourceUpdateMode.Never));
            textBoxIdMaterial.DataBindings.Add(new Binding("Text", dataGridViewMaterial.DataSource, "ID", true, DataSourceUpdateMode.Never));
            textBoxSoluong.DataBindings.Add(new Binding("Text", dataGridViewMaterial.DataSource, "Soluong", true, DataSourceUpdateMode.Never));
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewFood.SelectedCells.Count > 0)
                {
                    int id = (int)dataGridViewFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    comboBoxCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in comboBoxCategory.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    comboBoxCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            string name = textBoxNameFood.Text;
            int categoryID = (comboBoxCategory.SelectedItem as Category).ID;
            float price = (float)numericUpDownFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadFoodList();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }

        private void buttonEditFood_Click(object sender, EventArgs e)
        {
            string name = textBoxNameFood.Text;
            int categoryID = (comboBoxCategory.SelectedItem as Category).ID;
            float price = (float)numericUpDownFoodPrice.Value;
            int id = Convert.ToInt32(textBoxID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadFoodList();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void buttonDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadFoodList();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void buttonViewTable_Click(object sender, EventArgs e)
        {
            LoadTableList();
        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            string name = textBoxNameTable.Text;

            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadTableList();
                //if (insertFood != null)
                //insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn");
            }
        }

        private void buttonEditTable_Click(object sender, EventArgs e)
        {
            string name = textBoxNameTable.Text;

            int id = Convert.ToInt32(textBoxIdTable.Text);

            if (TableDAO.Instance.UpdateTable(id, name))
            {
                MessageBox.Show("Sửa tên bàn thành công");
                LoadTableList();
                //if (updateFood != null)
                // updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa tên bàn");
            }
        }

        private void buttonDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdTable.Text);

            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xóa bàn thành công");
                LoadTableList();
                //if (deleteFood != null)
                // deleteFood(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa bàn ăn");
            }

        }

        private void dataGridViewTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewTable.CurrentCell.RowIndex;
            textBoxIdTable.Text = dataGridViewTable.Rows[index].Cells[2].Value.ToString();
            textBoxNameTable.Text = dataGridViewTable.Rows[index].Cells[1].Value.ToString();
            //comboBoxTable.SelectedValue = dataGridViewTable.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            int sc = dataGridViewBill.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc; i++)
                thanhtien += float.Parse(dataGridViewBill.Rows[i].Cells[1].Value.ToString());
            //CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            //textBoxTotal.Text = thanhtien.ToString("c", culture);
            textBoxTotal.Text = thanhtien.ToString();
        }

        private void buttonSortFood_Click(object sender, EventArgs e)
        {
            LoadSortFood(dateTimePicker3.Value, dateTimePicker4.Value);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void bt_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void bt_sortThang_Click_1(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
        }

        private void bt_sortTuan_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
            dateTimePicker2.Value = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 7);
        }

        private void bt_sortThang2_Click(object sender, EventArgs e)
        {
            dateTimePicker3.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker4.Value = dateTimePicker3.Value.AddMonths(1).AddDays(-1);
        }

        private void bt_sortTuan2_Click(object sender, EventArgs e)
        {
            dateTimePicker3.Value = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
            dateTimePicker4.Value = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 7);
        }

        private void buttonViewMaterial_Click(object sender, EventArgs e)
        {
            LoadMaterialList();
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            string name = textBoxNameMaterial.Text;
            double soluong = Convert.ToDouble(textBoxSoluong.Text);

            if (MaterialDAO.Instance.InsertMaterial(name, soluong))
            {
                MessageBox.Show("Thêm nguyên liệu thành công");
                LoadMaterialList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nguyên liệu");
            }
        }

        private void buttonDeleteMaterial_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdMaterial.Text);

            if (MaterialDAO.Instance.DeleteMaterial(id))
            {
                MessageBox.Show("Xóa nguyên liệu thành công");
                LoadMaterialList();

            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa nguyên liệu");
            }
        }

        private void buttonEditMaterial_Click(object sender, EventArgs e)
        {
            string name = textBoxNameMaterial.Text;

            int id = Convert.ToInt32(textBoxIdMaterial.Text);
            double soluong = Convert.ToDouble(textBoxSoluong.Text);

            if (MaterialDAO.Instance.UpdateMaterial(id, name, soluong))
            {
                MessageBox.Show("Sửa nguyên liệu thành công");
                LoadMaterialList();

            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa nguyên liệu");
            }
        }

        private void dataGridViewMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewMaterial.CurrentCell.RowIndex;
            textBoxIdMaterial.Text = dataGridViewMaterial.Rows[index].Cells[1].Value.ToString();
            textBoxNameMaterial.Text = dataGridViewMaterial.Rows[index].Cells[0].Value.ToString();
            textBoxSoluong.Text = dataGridViewMaterial.Rows[index].Cells[2].Value.ToString();
        }

        private void buttonThemCT_Click(object sender, EventArgs e)
        {

            int idFood = (comboBoxNameFood.SelectedItem as Food).ID;
            int idNguyenlieu = (comboBoxMaterial.SelectedItem as Material).ID;
            double sl = Convert.ToDouble(textBoxSLNL.Text);
            if (FoodDAO.Instance.InsertCT(idFood, idNguyenlieu, sl))
            {
                MessageBox.Show("Thêm công thức thành công");
                LoadCongThuc();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm công thức");
            }
        }

        private void buttonviewSLM_Click(object sender, EventArgs e)
        {
            int slMon = 0;
            int id = (comboBoxFood.SelectedItem as Food).ID;
            string query = string.Format("SELECT sl FROM SoluongMon WHERE idFood=" + id);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            slMon = (int)result.Rows[0][0];

            List<int> listNguyenlieu = new List<int>();
            string query1 = string.Format("SELECT idNguyenlieu FROM Congthuc WHERE idFood=" + id);
            DataTable result1 = DataProvider.Instance.ExecuteQuery(query1);
            foreach (DataRow item in result1.Rows)
            {
                int t = (int)item["idNguyenLieu"];
                listNguyenlieu.Add(t);
            }
            int monThem = 0;

            for (int i = 0; i < listNguyenlieu.Count(); i++)
            {
                string query2 = string.Format("SELECT soluong FROM Congthuc WHERE idFood= {0} and idNguyenlieu = {1} ", id, listNguyenlieu[i]);
                DataTable result2 = DataProvider.Instance.ExecuteQuery(query2);
                //Console.WriteLine((double)result2.Rows[0][0]);
                string query3 = string.Format("SELECT soluong FROM Material WHERE id= {0}", listNguyenlieu[i]);
                DataTable result3 = DataProvider.Instance.ExecuteQuery(query3);
                //Console.WriteLine(15/ ((double)result2.Rows[0][0]));
                int monThem1 = Convert.ToInt32((double)result3.Rows[0][0] / (double)result2.Rows[0][0]);
                if (i == 0 || monThem1 < monThem)
                {
                    monThem = monThem1;
                }

            }
            for (int i = 0; i < listNguyenlieu.Count(); i++)
            {
                string query2 = string.Format("SELECT soluong FROM Congthuc WHERE idFood= {0} and idNguyenlieu = {1} ", id, listNguyenlieu[i]);
                DataTable result2 = DataProvider.Instance.ExecuteQuery(query2);
                //Console.WriteLine((double)result2.Rows[0][0]);
                string query3 = string.Format("SELECT soluong FROM Material WHERE id= {0}", listNguyenlieu[i]);
                DataTable result3 = DataProvider.Instance.ExecuteQuery(query3);
                Console.WriteLine((double)result3.Rows[0][0]);
                double soluongMoi = (double)result3.Rows[0][0] - monThem * (double)result2.Rows[0][0];
                string q = string.Format("UPDATE dbo.Material SET soluong = {0} Where id = {1}", soluongMoi, listNguyenlieu[i]);
                int result5 = DataProvider.Instance.ExecuteNonQuery(q);
            }
            //Console.WriteLine(monThem);
            slMon = slMon + monThem;
            string query4 = string.Format("UPDATE dbo.SoluongMon SET sl = {0} Where idFood={1}", slMon, id);
            int result4 = DataProvider.Instance.ExecuteNonQuery(query4);
            LoadSLMon();
        }

        private void dataGridViewFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewFood.CurrentRow.Cells[3].Value.ToString();
            textBoxNameFood.Text = dataGridViewFood.CurrentRow.Cells[2].Value.ToString();
            comboBoxCategory.SelectedValue = dataGridViewFood.CurrentRow.Cells[1].Value;
            numericUpDownFoodPrice.Value = Convert.ToInt32(dataGridViewFood.CurrentRow.Cells[0].Value);
        }
    }
}

