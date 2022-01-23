using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyQuanAn
{
    
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm Af = new AdminForm();
            Af.InsertFood += f_InsertFood;
            Af.DeleteFood += f_DeleteFood;
            Af.UpdateFood += f_UpdateFood;
            Af.ShowDialog();
        }
        void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((comboBoxCategory.SelectedItem as Category).ID);
            if (listViewBill.Tag != null)
                ShowBill((listViewBill.Tag as Table).ID);
        }

        void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((comboBoxCategory.SelectedItem as Category).ID);
            if (listViewBill.Tag != null)
                ShowBill((listViewBill.Tag as Table).ID);
            LoadTable();
        }

        void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((comboBoxCategory.SelectedItem as Category).ID);
            if (listViewBill.Tag != null)
                ShowBill((listViewBill.Tag as Table).ID);
        }
        void LoadTable()
        {
            flowLayoutPanelTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.GreenYellow;
                        break;
                    default:
                        btn.BackColor = Color.Bisque;
                        break;
                }

                flowLayoutPanelTable.Controls.Add(btn);
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            listViewBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        void ShowBill(int id)
        {
            listViewBill.Items.Clear();
            List <Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                listViewBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            //textBoxTotalPrice.Text = totalPrice.ToString("c", culture);
            textBoxTotalPrice.Text = totalPrice.ToString();

        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            comboBoxCategory.DataSource = listCategory;
            comboBoxCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            comboBoxFood.DataSource = listFood;
            comboBoxFood.DisplayMember = "Name";
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            Table table = listViewBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (comboBoxFood.SelectedItem as Food).ID;
            int count = (int)numericUpDown1.Value;
            string query = string.Format("SELECT sl FROM SoluongMon WHERE idFood=" + foodID);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int slMon = (int)result.Rows[0][0];
            if (slMon > count)
            {
                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(table.ID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
                }

                ShowBill(table.ID);
                string query4 = string.Format("UPDATE dbo.SoluongMon SET sl = {0} Where idFood={1}", slMon-count, foodID);
                int result4 = DataProvider.Instance.ExecuteNonQuery(query4);

                LoadTable();
            }
            else
            {
                MessageBox.Show("Món không đủ số lượng");
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            Table table = listViewBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            //double totalPrice = Convert.ToDouble(textBoxTotalPrice.Text.Split(',')[0]);
            double totalPrice = Convert.ToDouble(textBoxTotalPrice.Text);
            if (idBill !=-1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}\n Tổng tiền: {1}", table.Name, totalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) 
                {
                    BillDAO.Instance.CheckOut(idBill, (float)totalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }
        }

        private void bt_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
