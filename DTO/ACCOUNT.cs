using System;
using System.Collections.Generic;
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

        public string USERNAME { get => _USERNAME; set => _USERNAME = value; }
        public string PASSWORD { get => _PASSWORD; set => _PASSWORD = value; }
        public string DISPLAYNAME { get => _DISPLAYNAME; set => _DISPLAYNAME = value; }
        public string MSSV { get => _MSSV; set => _MSSV = value; }

        public ACCOUNT(string USERNAME, string PASSWORD, string DISPLAYNAME, string MSSV)
        {
            this.USERNAME = USERNAME;
            this.PASSWORD = PASSWORD;
            this.DISPLAYNAME = DISPLAYNAME;
            this.MSSV = MSSV;
        }
    }
}
