using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DASHBOARD_DAO
    {
        private static DASHBOARD_DAO instance;



        public static DASHBOARD_DAO Instance
        {
            get { if (instance == null) instance = new DASHBOARD_DAO(); return instance; }
            private set => instance = value;
        }



        private DASHBOARD_DAO() { }




        public string Job_QuantiTy(string mssv, DateTime date)
        {
            string query = "USP_Job_QuantiTy @MSSV , @DATE";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { mssv, date });

            return data.Rows[0].ItemArray[0].ToString();
        }





        public List<Job> Job_Content(string mssv, DateTime date)
        {
            List<Job> listjob = new List<Job>();
            string query = "USP_Job_Content @MSSV , @DATE";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { mssv, date });



            foreach (DataRow item in data.Rows)
            {
                Job jb = new Job(item);
                listjob.Add(jb);
            }



            return listjob;
        }



        public List<object[]> DS(string mssv, DateTime date, int days)
        {
            List<object[]> listjob = new List<object[]>();

            string query = "USP_DS_Object @MSSV , @DATE";



            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { mssv, date });

            for (int i = 0; i < days + 1; i++)
            {
                listjob.Add(new object[3]);
            }

            foreach (DataRow item in data.Rows)
            {
                DateTime a = (DateTime)item["NGKT"];

                listjob[a.Date.Day] = new object[] { (DateTime)item["NGKT"], (string)item["MAMH"], (string)item["NOIDUNG"] };

            }

            return listjob;
        }

        public List<DLNOW>GetlistDLnowDB(string MSSV, DateTime now)
        {
            List<DLNOW> dsDLnow = new List<DLNOW>();
            string query = "select MAMH, NOIDUNG from DEADLINE where MSSV = '20521711' and NGKT = '2021-12-03'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                DLNOW resen = new DLNOW(item);
                dsDLnow.Add(resen);
            }

            return dsDLnow;
        }

        public void Delete_TempTable()
        {
            DataProvider.Instance.ExecuteNonQuery("delete from temp_table");
        }
    }
}
