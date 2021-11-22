using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class KQHT_DAO
    {
        private static KQHT_DAO instance;


        public static KQHT_DAO Instance
        {
            get { if (instance == null) instance = new KQHT_DAO(); return instance; }
            private set => instance = value;
        }



        private KQHT_DAO() { }



        public List<KQHT> GetListKQHTfromDB(string NamHoc, string HocKy, string Khoa, string MSSV)
        {
            List<KQHT> result = new List<KQHT>();
            string query = "USP_Load_Search_dtgv @NamHoc , @HocKy , @Khoa , @MSSV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,
                new object[] { NamHoc, HocKy, Khoa, MSSV });

            foreach(DataRow item in data.Rows)
            {
                KQHT kq = new KQHT(item);
                result.Add(kq);
            } 

            return result;
        }



        public int Edit_dtgv(float QT, float GK, float TH, float CK, string mssv, string namhoc, string hocky, string mamh)
        {
            string query = "USP_Edit_dtgv @QT , @GK , @TH , @CK , @MSSV , @NAMHOC , @HOCKY , @MAMH";

            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { QT, GK, TH, CK, mssv, namhoc, hocky, mamh });
        }
    }
}
