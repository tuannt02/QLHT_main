using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;


namespace DAO
{
    public class MANAGE_DAO
    {
        private static MANAGE_DAO instance;

        public static MANAGE_DAO Instance 
        {
            get { if (instance == null) instance = new MANAGE_DAO(); return instance; } 
            private set => instance = value; 
        }

        private MANAGE_DAO() { }

        public List<ACCOUNT> getListACCOUNT()
        {
            List<ACCOUNT> listAccount = new List<ACCOUNT>();

            string query = "select * from ACCOUNT";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                ACCOUNT acc = new ACCOUNT(item);
                listAccount.Add(acc);
            }


            return listAccount;
        }

        public bool InsertAcc(string USERNAME, string PASSWORD, string DISPLAYNAME, string MSSV, bool ADMIN)
        {
            string query = "ACC_Insert @USERNAME , @PASSWORD , @DISPLAYNAME , @MSSV , @ADMIN";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { USERNAME, PASSWORD, DISPLAYNAME, MSSV, ADMIN });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteAcc(string USERNAME)
        {
            string query = "delete from ACCOUNT where USERNAME = '" + USERNAME + "'";

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateAcc(string USERNAME, string PASSWORD, string DISPLAYNAME, string MSSV, bool ADMIN)
        {
            string query = "update ACCOUNT set PASSWORD = '"+ PASSWORD +"', DISPLAYNAME = '"+ 
                DISPLAYNAME +"' , MSSV = '"+ MSSV +"' , ADMIN = " + (ADMIN ? "1" : "0") +
                "where USERNAME = '"+ USERNAME +"'";

            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
