using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GMAIL
    {
        private string _MSSV;
        private string _HOTEN;

        public string MSSV { get => _MSSV; set => _MSSV = value; }
        public string HOTEN { get => _HOTEN; set => _HOTEN = value; }

        public GMAIL(DataRow row)
        {
            MSSV = (string)row["MSSV"];
            HOTEN = (string)row["HOTEN"];
        }
    }
}
