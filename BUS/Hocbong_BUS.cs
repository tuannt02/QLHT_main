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
    }
}
