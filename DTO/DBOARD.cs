using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DBOARD
    {

    }
    public class Job
    {
        private string _NOIDUNG;
        private string _MAMH;
        private DateTime _NGKT;


        public string NOIDUNG { get => _NOIDUNG; set => _NOIDUNG = value; }
        public string MAMH { get => _MAMH; set => _MAMH = value; }
        public DateTime NGKT { get => _NGKT; set => _NGKT = value; }



        public Job(string NOIDUNG, string MAMH, DateTime NGKT)
        {
            this.NOIDUNG = NOIDUNG;
            this.MAMH = MAMH;
            this.NGKT = NGKT;
        }
        public Job(DataRow row)
        {
            this.NOIDUNG = (string)row["NOIDUNG"];
            this.MAMH = (string)row["MAMH"];
            this.NGKT = (DateTime)row["NGKT"];
        }
    }

    public class DLNOW
    {
        private string _NOIDUNG;
        private string _MAMH;

        public string NOIDUNG { get => _NOIDUNG; set => _NOIDUNG = value; }
        public string MAMH { get => _MAMH; set => _MAMH = value; }

        public DLNOW(string NOIDUNG, string MAMH, DateTime NGKT)
        {
            this.NOIDUNG = NOIDUNG;
            this.MAMH = MAMH;
        }
        public DLNOW(DataRow row)
        {
            NOIDUNG = (string)row["NOIDUNG"];
            MAMH = (string)row["MAMH"];
        }
    }
}
