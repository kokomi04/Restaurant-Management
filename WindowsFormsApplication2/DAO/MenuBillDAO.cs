using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2.DTO;

namespace WindowsFormsApplication2.DAO
{
    public class MenuBillDAO
    {
        private static MenuBillDAO instance;

        public static MenuBillDAO Instance
        {
            get { if (instance == null) instance = new MenuBillDAO(); return MenuBillDAO.instance; }
            set { MenuBillDAO.instance = value; }
        }
        private MenuBillDAO() { }

        public List<MenuBill> GetListMenu(int id)
        {
            List<MenuBill> MenuBill = new List<MenuBill>();

            string query = "SELECT f.name, bi.count, f.price, bi.count*f.price as totalPrice FROM dbo.Bill as b, dbo.BillInfo as bi, dbo.Food as f Where bi.idBill=b.id and bi.idFood=f.id and b.status=0 and b.idTable =" + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuBill menu = new MenuBill(item);
                MenuBill.Add(menu);
            }

            return MenuBill;
        }
    }
}
