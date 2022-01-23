using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyQuanAn
{
    public partial class KitchenForm : Form
    {
        public KitchenForm()
        {
            InitializeComponent();
            LoadList();
        }
        void LoadList()
        {
            dataGridViewKitchen.DataSource = BillDAO.Instance.GetKitchen();
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            dataGridViewKitchen.DataSource = BillDAO.Instance.GetKitchen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewKitchen.DataSource = BillDAO.Instance.GetKitchen();
        }
        int Billid;
        private void dataGridViewKitchen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewKitchen.CurrentCell.RowIndex;
            Billid= Convert.ToInt32(dataGridViewKitchen.Rows[index].Cells[0].Value.ToString());
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            BillDAO.Instance.CheckOrder(Billid);
            LoadList();
        }

        private void bt_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}