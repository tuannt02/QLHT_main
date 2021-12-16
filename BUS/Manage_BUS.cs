using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAO;

namespace BUS
{
    public class Manage_BUS
    {
        private static Manage_BUS instance;

        public static Manage_BUS Instance 
        { 
            get { if (instance == null) instance = new Manage_BUS(); return instance; }
            private set => instance = value; 
        }

        private Manage_BUS() { }

        public List<ACCOUNT> getListACCOUNT()
        {
            return MANAGE_DAO.Instance.getListACCOUNT();
        }

        public bool InsertAcc(string USERNAME, string PASSWORD, string DISPLAYNAME, string MSSV, bool ADMIN)
        {
            return MANAGE_DAO.Instance.InsertAcc(USERNAME, PASSWORD, DISPLAYNAME, MSSV, ADMIN);
        }
        public bool DeleteAcc(string USERNAME)
        {
            return MANAGE_DAO.Instance.DeleteAcc(USERNAME);
        }
        public bool UpdateAcc(string USERNAME, string PASSWORD, string DISPLAYNAME, string MSSV, bool ADMIN)
        {
            return MANAGE_DAO.Instance.UpdateAcc(USERNAME, PASSWORD, DISPLAYNAME, MSSV, ADMIN);
        }
    }
}
