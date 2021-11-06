using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;


namespace BUS
{
    public class Login_BUS
    {
        private static Login_BUS instance;

        public static Login_BUS Instance { 
            get { if (instance == null) instance = new Login_BUS(); return instance; } 
            private set => instance = value; }

        public bool Login_Check(string username, string password)
        {
            if (username == "" || password == "")
                return true;
            return false;
        }
        public bool Login(string username, string password)
        {
            return ACCOUNT_DAO.Instance.Login(username, password);
        }
    }
}
