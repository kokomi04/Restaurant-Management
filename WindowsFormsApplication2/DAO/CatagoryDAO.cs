using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2.DTO;

namespace WindowsFormsApplication2.DAO
{
        public class CatagoryDAO
        {
            private static CatagoryDAO instance;

            public static CatagoryDAO Instance
            {
                get { if (instance == null) instance = new CatagoryDAO(); return CatagoryDAO.instance; }
                private set { CatagoryDAO.instance = value; }
            }
            private CatagoryDAO() { }

            public List<Catagory> GetListCata()
            {
                List<Catagory> catagory = new List<Catagory>();

                string query = "SELECT * FROM dbo.FoodCategory";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    Catagory cata = new Catagory(item);
                    catagory.Add(cata);
                }

                return catagory;
            }
        }
    }
