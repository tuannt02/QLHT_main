using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;


namespace BUS
{
    public class Kqht_BUS
    {
        private static Kqht_BUS instance;



        public static Kqht_BUS Instance
        {
            get { if (instance == null) instance = new Kqht_BUS(); return instance; }
            private set => instance = value;
        }



        private Kqht_BUS() { }

        public bool KQHT_Search_Check(string NamHoc, string HocKy, string Khoa, string MSSV)
        {
            if (NamHoc == "" | HocKy == "" | Khoa == "" | MSSV == "")
                return true;
            return false;
        }
        //public bool KQHT_XemDS_Check(string NamHoc, string Khoa)
        //{
        // if (NamHoc == "" | Khoa == "")
        // return true;
        // return false;
        //}



        public List<KQHT> GetListKQHT(string NamHoc, string HocKy, string Khoa, string MSSV)
        {
            return DAO.KQHT_DAO.Instance.GetListKQHTfromDB(NamHoc, HocKy, Khoa, MSSV);
        }



        //public DataTable Load_XemDS_dtgv(int NamHoc, string Khoa)
        //{
        // return DAO.KQHT_DAO.Instance.Load_XemDS_dtgv(NamHoc, Khoa);
        //}

        public int Edit_dtgv(float QT, float GK, float TH, float CK, string mssv, int namhoc, string hocky, string mamh)
        {
            return KQHT_DAO.Instance.Edit_dtgv(QT, GK, TH, CK, mssv, namhoc, hocky, mamh);
        }
    }
}
