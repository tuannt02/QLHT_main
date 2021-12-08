using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SETTING
    {
        private string _MSSV;
        private string _HOTEN;
        private string _QUEQUAN;
        private bool _GIOITINH;
        private DateTime _NGAYSINH;
        private string _MAKHOA;




        public string MSSV { get => _MSSV; set => _MSSV = value; }
        public string HOTEN { get => _HOTEN; set => _HOTEN = value; }
        public string QUEQUAN { get => _QUEQUAN; set => _QUEQUAN = value; }
        public bool GIOITINH { get => _GIOITINH; set => _GIOITINH = value; }
        public DateTime NGAYSINH { get => _NGAYSINH; set => _NGAYSINH = value; }
        public string MAKHOA { get => _MAKHOA; set => _MAKHOA = value; }




        public SETTING(string mSSV, string hOTEN, string qUEQUAN, bool gIOITINH, DateTime nGAYSINH, string mAKHOA)
        {
            _MSSV = mSSV;
            _HOTEN = hOTEN;
            _QUEQUAN = qUEQUAN;
            _GIOITINH = gIOITINH;
            _NGAYSINH = nGAYSINH;
            _MAKHOA = mAKHOA;
        }




        public SETTING(DataRow row)
        {
            _MSSV = (string)row["MSSV"];
            _HOTEN = (string)row["HOTEN"];
            _QUEQUAN = (string)row["QUEQUAN"];
            _GIOITINH = (bool)row["GIOITINH"];
            _NGAYSINH = (DateTime)row["NGAYSINH"];
            _MAKHOA = (string)row["MAKHOA"];
        }
    }
}
