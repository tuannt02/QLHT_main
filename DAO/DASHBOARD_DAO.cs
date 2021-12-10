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
            string query = "select MAMH, NOIDUNG from DEADLINE where MSSV = '" + MSSV+ "' and NGKT = '" + now.ToString() + "'";

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

        public string GetMSSV()
        {
            string query = "select top 1 MSSV from TEMP_TABLE";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            string MSSV = (string)(data.Rows[0]["MSSV"]);

            return MSSV;
        }

        public int GetSLHB()
        {
            string query = "select * from HOCBONG where TGKT >= GETDATE()";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows.Count;
        }

        public int GetDLHT(int month)
        {
            string query = "select * from DEADLINE where HOANTHANH = 1 and MONTH(NGKT) = " + month.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count;
        }

        public int GetSUMDL(int month)
        {
            string query = "select * from DEADLINE where MONTH(NGKT) = " + month.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count;
        }

        public string Load_GHICHU(string MSSV)
        {
            string query = "select GHICHU from SINHVIEN where MSSV = " + MSSV;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            string GHICHU;

            if((data.Rows[0]["GHICHU"]) != DBNull.Value)
                GHICHU = (string)(data.Rows[0]["GHICHU"]);
            else
            {
                GHICHU = "";
            }

            return GHICHU;
        }

        public bool AddDL(string MSSV, string MAMH, DateTime time, string mes, int ch)
        {
            string query = "INSERT_DL  @MSSV , @MAMH , @NGKT , @NOIDUNG , @HOANTHANH ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                MSSV,
                MAMH,
                time,
                mes,
                ch
            });

            return true;

        }

        public List<DLinfo> GetlistDLinfo(string MSSV)
        {
            List<DLinfo> dsDLinfo = new List<DLinfo>();
            string query = "select	MAMH, NOIDUNG, (Day(NGKT) - Day(GETDATE())) as NGCL from DEADLINE where MSSV = '" + MSSV + "' and NGKT >= GETDATE() ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DLinfo resen = new DLinfo(item);
                dsDLinfo.Add(resen);
            }

            return dsDLinfo;
        }

        public bool UpdateGhiChu(string MSSV ,string mes)
        {
            string query = "update SINHVIEN set GHICHU = N'" + mes + "' where MSSV = '"+ MSSV + "'";

            DataProvider.Instance.ExecuteNonQuery(query);


            return true;
        }

    }
}
