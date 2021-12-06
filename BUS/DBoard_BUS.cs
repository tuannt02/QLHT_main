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
    }
}
