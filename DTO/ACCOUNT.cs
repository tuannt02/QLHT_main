using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ACCOUNT
    {
        private string _USERNAME;
        private string _PASSWORD;
        private string _DISPLAYNAME;
        private string _MSSV;
        private bool _ADMIN;

        public string USERNAME { get => _USERNAME; set => _USERNAME = value; }
        public string PASSWORD { get => _PASSWORD; set => _PASSWORD = value; }
        public string DISPLAYNAME { get => _DISPLAYNAME; set => _DISPLAYNAME = value; }
        public string MSSV { get => _MSSV; set => _MSSV = value; }
        public bool ADMIN { get => _ADMIN; set => _ADMIN = value; }

        public ACCOUNT(string USERNAME, string PASSWORD, string DISPLAYNAME, string MSSV, bool ADMIN)
        {
            this.USERNAME = USERNAME;
            this.PASSWORD = PASSWORD;
            this.DISPLAYNAME = DISPLAYNAME;
            this.MSSV = MSSV;
            this.ADMIN = ADMIN;
        }

        public ACCOUNT(DataRow row)
        {
            this.USERNAME = (string)row["USERNAME"];
            this.PASSWORD = (string)row["PASSWORD"];
            this.DISPLAYNAME = (string)row["DISPLAYNAME"];
            this.MSSV = (string)row["MSSV"];
            this.ADMIN = (bool)row["ADMIN"];
        }
    }
}
