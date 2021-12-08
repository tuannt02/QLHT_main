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

        public bool CheckMSSV(string MSSV)
        {
            string query = "USP_CheckMSSV @MSSV ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MSSV });

            return result.Rows.Count > 0;
        }

        public bool CheckUsername(string username)
        {
            string query = "select * from ACCOUNT where USERNAME = '" + username + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }


        public void InsertAcc(string MSSV, string username, string password)
        {
            string query = "USP_InsertAcc @USERNAME , @PASSWORD , @MSSV ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {MSSV, username, password });
        }

        public void Insert_Table_Temp(string username)
        {
            string query = "USP_insert_Temp_Table @USERNAME ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { username });
        }
    }
}
