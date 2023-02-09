using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2.DTO;

namespace WindowsFormsApplication2.DAO
{
    class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            set { BillDAO.instance = value; }
        }
        private BillDAO() { }

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT *FROM dbo.Bill WHERE idTable = " + id + "and status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void InsertBill(int id)
        {
            int check = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBill @idTable", new object[] { id });
        }

        public int GetMaxId()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT Max(ID) FROM dbo.Bill");
            }
            catch
            {            
                return 1;
            }
        }

        public void CheckOut(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("Update dbo.Bill Set status = 1 Where id = " + id);

        }
    }
}
