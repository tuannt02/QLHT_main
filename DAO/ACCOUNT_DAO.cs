using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ACCOUNT_DAO
    {

        private static ACCOUNT_DAO instance;

        public static ACCOUNT_DAO Instance 
        { 
            get { if (instance == null) instance = new ACCOUNT_DAO(); return instance; } 
            private set => instance = value; 
        }

        private ACCOUNT_DAO() { }

        public bool Login(string username, string password)
        {
            string query = "USP_Login @USERNAME , @PASSWORD";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            return result.Rows.Count > 0;
        }
    }
}
