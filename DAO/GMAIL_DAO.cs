using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class GMAIL_DAO
    {
        private static GMAIL_DAO instance;

        public static GMAIL_DAO Instance 
        { 
            get { if (instance == null) instance = new GMAIL_DAO(); return instance; } 
            private set => instance = value; 
        }

        private GMAIL_DAO() { }

        public List<GMAIL> GetListSVfromDB(string MAKHOA)
        {
            List<GMAIL> result = new List<GMAIL>();
            string query = "select MSSV, HOTEN from SINHVIEN where MAKHOA = '" + MAKHOA +"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                GMAIL kq = new GMAIL(item);
                result.Add(kq);
            }

            return result;
        }
    }
}
