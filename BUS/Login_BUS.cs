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
        public bool LoginSignUp_Check(string MSSV, string username, string password)
        {
            if (MSSV == "" || username == "" || password == "") return true;
            return false;
        }

        // Check MSSV đã tồn tại
        public bool LoginSignUp_CheckMSSVExitst(string MSSV)
        {
            return ACCOUNT_DAO.Instance.CheckMSSV(MSSV);
        }

        // Check username đã tồn tại
        public bool LoginSignUp_CheckUsernameExists(string username)
        {
            return ACCOUNT_DAO.Instance.CheckUsername(username);
        }

        // Check password
        public int LoginSignUp_CheckPassword(string password)
        {
            // Check password: (0: pw để trống, 1: đủ 8 kí tự,
            // 2: đủ kí tự và chữ cái, 3: thỏa tất cả đk)

            if (password.Length == 0)
                return 0;
            else if (password.Length < 8)
                return 1;
            else if (!CheckDk3(password))
                return 2;
            else 
                return 3;
        }

        // Check dk 3
        public bool CheckDk3(string password)
        {
            bool flagNum = false, flagAlpha = false;
            foreach(char c in password)
            {
                int ch = Convert.ToInt32(c);
                if (ch >= 48 && ch <= 57) flagNum = true;
                if ((ch >= 65 && ch <= 90) || (ch >= 97 && ch <= 122))
                    flagAlpha = true;
            }
                
            return flagNum && flagAlpha;
        }


        public bool Login(string username, string password)
        {
            return ACCOUNT_DAO.Instance.Login(username, password);
        }
        public void InsertAcc(string MSSV, string username, string password)
        {
            ACCOUNT_DAO.Instance.InsertAcc(MSSV, username, password);
        }
    }
}
