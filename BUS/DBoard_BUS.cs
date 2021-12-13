using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAO;

namespace BUS
{
    public class DBoard_BUS
    {
        private static DBoard_BUS instance;



        public static DBoard_BUS Instance
        {
            get { if (instance == null) instance = new DBoard_BUS(); return instance; }
            private set => instance = value;
        }

        private DBoard_BUS() { }

        public string Job_QuantiTy(string mssv)
        {
            return DASHBOARD_DAO.Instance.Job_QuantiTy(mssv, DateTime.Now);
        }

        public List<string> Job_Content(string mssv, DateTime date)
        {
            List<string> listDln = new List<string>();
            List<Job> listJobs = DASHBOARD_DAO.Instance.Job_Content(mssv, date);
            foreach (Job job in listJobs)
            {
                string item = job.MAMH + ": " + job.NOIDUNG;
                listDln.Add(item);
            }
            return listDln;
        }


        public List<object[]> list_GetJobs(string mssv, DateTime date, int daysInMonth)
        {
            return DASHBOARD_DAO.Instance.DS(mssv, date, daysInMonth);
        }

        public List<DLNOW> GetlistDLnow(string MSSV, DateTime now)
        {
            return DAO.DASHBOARD_DAO.Instance.GetlistDLnowDB(MSSV, now);
        }

        public void Delete_TempTable()
        {
            DASHBOARD_DAO.Instance.Delete_TempTable();
        }

        public string GetMSSV()
        {
            return DASHBOARD_DAO.Instance.GetMSSV();
        }

        public int GetSLHB()
        {
            return DASHBOARD_DAO.Instance.GetSLHB();
        }

        public int GetDLHT(int month)
        {
            return DASHBOARD_DAO.Instance.GetDLHT(month);
        }

        public int GetSUMDL(int month)
        {
            return DASHBOARD_DAO.Instance.GetSUMDL(month);
        }

        public string Load_GHICHU(string MSSV)
        {
            return DASHBOARD_DAO.Instance.Load_GHICHU(MSSV);
        }

        public bool AddDL(string MSSV, string MAMH, DateTime time, string mes, int ch)
        {
            return DASHBOARD_DAO.Instance.AddDL(MSSV, MAMH, time, mes, ch);
        }

        public List<DLinfo> GetlistDLinfo(string MSSV)
        {
            return DAO.DASHBOARD_DAO.Instance.GetlistDLinfo(MSSV);
        }

        public bool UpdateGhiChu(string MSSV,string mes)
        {
            return DASHBOARD_DAO.Instance.UpdateGhiChu(MSSV,mes);
        }

        public string Load_Name(string MSSV)
        {
            return DASHBOARD_DAO.Instance.Load_Name(MSSV);
        }

        public bool UpdateName(string MSSV, string DISPLAYNAME)
        {
            return DASHBOARD_DAO.Instance.UpdateName(MSSV, DISPLAYNAME);
        }

        public bool Update_BREADCRUMB(string MSSV, string BREADCRUMB)
        {
            return DASHBOARD_DAO.Instance.Update_BREADCRUMB(MSSV, BREADCRUMB);
        }

        public string GetBREADCRUMB(string MSSV)
        {
            return DASHBOARD_DAO.Instance.GetBREADCRUMB(MSSV);
        }


        public string Diem(int muctieu, string namhoc, string hocky)
        {
            float x = DASHBOARD_DAO.Instance.Diem(muctieu, namhoc, hocky);
            if (!(x == 0))
                return "Bạn cần thêm " + x.ToString() + " điểm để đạt mục tiêu";
            return "Bạn đã hoàn thành mục tiêu";
        }
    }
}
