using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HOCBONG
    {
        private string _MAHB;
        private string _TENHB;
        private string _TRIGIA;
        private DateTime _TGDK;
        private DateTime _TGKT;
        private string _DVTT;
        private bool _STATUS;

        public string MAHB { get => _MAHB; set => _MAHB = value; }
        public string TENHB { get => _TENHB; set => _TENHB = value; }
        public string TRIGIA { get => _TRIGIA; set => _TRIGIA = value; }
        public DateTime TGDK { get => _TGDK; set => _TGDK = value; }
        public DateTime TGKT { get => _TGKT; set => _TGKT = value; }
        public string DVTT { get => _DVTT; set => _DVTT = value; }
        public bool STATUS { get => _STATUS; set => _STATUS = value; }

        public HOCBONG(string MAHB, string TENHB, string TRIGIA, DateTime TGDK, DateTime TGKT, string DVTT)
        {
            this.MAHB = MAHB;
            this.TENHB = TENHB;
            this.TRIGIA = TRIGIA;
            this.TGDK = TGDK;
            this.TGKT = TGKT;
            this.DVTT = DVTT;
            this.STATUS = (DateTime.Now - TGKT).TotalDays > 0;
        }
        public HOCBONG(DataRow row)
        {
            this.MAHB = (string)row["MAHB"];
            this.TENHB = (string)row["TENHB"];
            this.TRIGIA = (string)row["TRIGIA"];
            this.TGDK = (DateTime)row["TGDK"];
            this.TGKT = (DateTime)row["TGKT"];
            this.DVTT = (string)row["DVTT"];
            this.STATUS = (DateTime.Now - (DateTime)row["TGKT"]).TotalDays > 0;
        }



    }
}
