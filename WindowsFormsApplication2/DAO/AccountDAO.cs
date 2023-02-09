using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get {
                if (instance==null)
                    instance = new AccountDAO();
                return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
        public bool Login(string user, string pass)
        {
            string query = " EXEC USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { user, pass });
            return result.Rows.Count > 0;
        }
    }
}
