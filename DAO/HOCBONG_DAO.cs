using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HOCBONG_DAO
    {
        private static HOCBONG_DAO instance;

        public static HOCBONG_DAO Instance
        {
            get { if (instance == null) instance = new HOCBONG_DAO(); return instance; }
            private set => instance = value;
        }

        private HOCBONG_DAO() { }

        #region Methods
        public List<HOCBONG> getListHBFullfromDB()
        {
            List<HOCBONG> listHBs = new List<HOCBONG>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from HOCBONG");

            foreach(DataRow item in data.Rows)
            {
                HOCBONG hb = new HOCBONG(item);
                listHBs.Add(hb);
            }

            return listHBs;
        }
        public List<HOCBONG> getListHBActivefromDB()
        {
            List<HOCBONG> listHBs = new List<HOCBONG>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from HOCBONG where TGKT > GetDate()");

            foreach (DataRow item in data.Rows)
            {
                HOCBONG hb = new HOCBONG(item);
                listHBs.Add(hb);
            }

            return listHBs;
        }
        public List<HOCBONG> getListHBUnActivefromDB()
        {
            List<HOCBONG> listHBs = new List<HOCBONG>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from HOCBONG where TGKT < GetDate()");

            foreach (DataRow item in data.Rows)
            {
                HOCBONG hb = new HOCBONG(item);
                listHBs.Add(hb);
            }

            return listHBs;
        }
        private string getQuery(int flag)
        {
            string query = "";
            if (flag == 0) query = "USP_UC_AboutUsFilter @key ";
            else if(flag == 1) query = "USP_UC_AboutUsFilter1 @key ";
            else if(flag == 2) query = "USP_UC_AboutUsFilter2 @key ";
            return query;
        }
        public List<HOCBONG> getListHBFilterfromDB(string key,int flag)
        {
            string query = getQuery(flag);
            DataTable data;
            List<HOCBONG> listHBs = new List<HOCBONG>();
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { key});

            foreach (DataRow item in data.Rows)
            {
                HOCBONG hb = new HOCBONG(item);
                listHBs.Add(hb);
            }

            return listHBs;
        }
        public bool DeleteOneRowDB(string MAHB)
        {
            string query1 = "select * from HOCBONG where MAHB = '" + MAHB + "'";
            string query2 = "delete from HOCBONG where MAHB = '" + MAHB + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query1);
            if (data.Rows.Count == 0) return false;
            else
            {
                DataProvider.Instance.ExecuteQuery(query2);
                return true;
            }
        }
        public bool CheckMAHBexitsDB(string MAHB)
        {
            string query = "select * from HOCBONG where MAHB = '" + MAHB + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0) return true;
            return false;
        }
        public bool InsertOneRowDB(string MAHB, string TENHB, string TRIGIA, DateTime TGDK, DateTime TGKT, string DVTT)
        {
            string query = "EXEC USP_InsertHOCBONG @MAHB , @TENHB , @TRIGIA , @TGDK , @TGKT , @DVTT ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {MAHB, TENHB, TRIGIA, TGDK, TGKT, DVTT });
            return true;
        }
        public bool UpdateOneRowDB(string MAHB, string TENHB, string TRIGIA, DateTime TGDK, DateTime TGKT, string DVTT)
        {
            string query = "USP_UpdateHOCBONG @MAHB , @TENHB , @TRIGIA , @TGDK , @TGKT , @DVTT ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAHB, TENHB, TRIGIA, TGDK, TGKT, DVTT });
            return true;
        }
        #endregion
    }
}
