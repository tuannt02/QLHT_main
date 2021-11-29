using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Gmail_BUS
    {
        private static Gmail_BUS instance;

        public static Gmail_BUS Instance 
        { 
            get { if (instance == null) instance = new Gmail_BUS(); return instance; } 
            private set => instance = value; 
        }

        private Gmail_BUS() { }

        public List<GMAIL> GetListSV(string MAKHOA)
        {
            return DAO.GMAIL_DAO.Instance.GetListSVfromDB(MAKHOA);
        }
    }
}
