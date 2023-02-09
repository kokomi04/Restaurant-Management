using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2.DAO;
using WindowsFormsApplication2.DTO;

namespace WindowsFormsApplication2.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if(instance==null) instance =new TableDAO(); return TableDAO.instance; }
            set { TableDAO.instance = value; }
        }
        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> TableList = new List<Table>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TableFood");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                TableList.Add(table);              
            }

            return TableList;
        }
    }
}
