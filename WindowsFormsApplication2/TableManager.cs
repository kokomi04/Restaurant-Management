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
using WindowsFormsApplication2.DAO;
using WindowsFormsApplication2.DTO;

namespace WindowsFormsApplication2
{
	public partial class TableManager : Form
	{
		public TableManager()
		{
			InitializeComponent();
            LoadTable();
            LoadCatagory();
		}

        #region Method
        void LoadCatagory()
        {
            List<Catagory> listCata = CatagoryDAO.Instance.GetListCata();

            comboBox1.DataSource = listCata;
            comboBox1.DisplayMember = "Name";
        }
        void LoadFood(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetListFood(id);
            comboBox2.DataSource = listFood;
            comboBox2.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Table> TableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in TableList)
            {

                Button btn = new Button() {Width = 85, Height = 85 };                
                flowLayoutPanel1.Controls.Add(btn);
                btn.Text = item.Name + "\n" + item.StatusTable;
                switch (item.StatusTable)
	            {
		            case "TRỐNG":
                        btn.BackColor = Color.DarkOrange;
                        break;
                    default:
                        btn.BackColor = Color.DarkCyan;
                        break;
	            }
                btn.Click += btn_Click;
                btn.Tag = item;
            }
        }

        void ShowBill(int id)
        {
            Add.Items.Clear();
            float total = 0;
            List<MenuBill> listMenu = MenuBillDAO.Instance.GetListMenu(id);
            foreach (MenuBill item in listMenu)
            {
                ListViewItem lvItem = new ListViewItem(item.Name);
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.TotalPrice.ToString());
                Add.Items.Add(lvItem);
                total += item.TotalPrice;
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = culture;
            textBox1.Text = total.ToString("c", culture);

        }
       
        #endregion

        #region Events

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 info = new Form2();
			info.ShowDialog();

		}

		private void Admin_Click_1(object sender, EventArgs e)
		{
			fAdmin ad = new fAdmin();
			ad.ShowDialog();
        }
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            Add.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCatagory = 0;
            //  ComboBox cb = sender as ComboBox;
            //if (cb.SelectedItem == null)
            //    return;
            //  Catagory sl = cb.SelectedItem as Catagory;

            Catagory sl = (sender as ComboBox).SelectedItem as Catagory;
            idCatagory = sl.Id;
            LoadFood(idCatagory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table table = Add.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int idFood = (comboBox2.SelectedItem as Food).Id;
            int count = (int)NumberUpDown.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxId(), idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
            }

            ShowBill(table.ID);
            LoadTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdTable = (int)(Add.Tag as Table).ID;
            int IdBill = BillDAO.Instance.GetUncheckBillIDByTableID(IdTable);
            //if (IdBill != -1)
            //{
                BillDAO.Instance.CheckOut(IdBill);

                ShowBill(IdTable);
                LoadTable();
           // }
            
        }
        #endregion

        
    }
}
