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
        public List<HOCBONG> getListHBFilterfromDB(string key)
        {
            string query = "USP_UC_AboutUsFilter @key ";
            List<HOCBONG> listHBs = new List<HOCBONG>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { key});

            foreach (DataRow item in data.Rows)
            {
                HOCBONG hb = new HOCBONG(item);
                listHBs.Add(hb);
            }

            return listHBs;
        }
    }
}
