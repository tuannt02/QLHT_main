using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;


namespace BUS
{
    public class Hocbong_BUS
    {
        private static Hocbong_BUS instance;

        public static Hocbong_BUS Instance 
        { 
            get { if (instance == null) instance = new Hocbong_BUS(); return instance; } 
            private set => instance = value; 
        }

        #region Methods
        public List<HOCBONG> getListHBFull()
        {
            List<HOCBONG> listHBs = new List<HOCBONG>();
            listHBs = HOCBONG_DAO.Instance.getListHBFullfromDB();

            return listHBs;
        }
        public List<HOCBONG> getListHBActive()
        {
            List<HOCBONG> listHBs = new List<HOCBONG>();
            listHBs = HOCBONG_DAO.Instance.getListHBActivefromDB();

            return listHBs;
        }
        public List<HOCBONG> getListHBUnActive()
        {
            List<HOCBONG> listHBs = new List<HOCBONG>();
            listHBs = HOCBONG_DAO.Instance.getListHBUnActivefromDB();

            return listHBs;
        }
        public List<HOCBONG> getListHBFilter(string key)
        {
            List<HOCBONG> listHBs = new List<HOCBONG>();
            listHBs = HOCBONG_DAO.Instance.getListHBFilterfromDB(key);

            return listHBs;
        }
        public bool DeleteOneRow(string MAHB)
        {
            return HOCBONG_DAO.Instance.DeleteOneRowDB(MAHB);
        }
        public bool checkMAHBexits(string MAHB)
        {
            return HOCBONG_DAO.Instance.CheckMAHBexitsDB(MAHB);
        }
        public bool InsertOneRow(string MAHB, string TENHB, string TRIGIA, DateTime TGDK, DateTime TGKT, string DVTT)
        {
            return HOCBONG_DAO.Instance.InsertOneRowDB(MAHB, TENHB, TRIGIA, TGDK, TGKT, DVTT);
        }
        public bool UpdateOneRow(string MAHB, string TENHB, string TRIGIA, DateTime TGDK, DateTime TGKT, string DVTT)
        {
            return HOCBONG_DAO.Instance.UpdateOneRowDB(MAHB, TENHB, TRIGIA, TGDK, TGKT, DVTT);
        }
        #endregion
    }
}
