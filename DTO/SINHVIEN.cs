using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SINHVIEN
    {
        private string _MSSV;
        private string _TENTRUONG;
        private string _TENLOP;
        private string _TENNGANH;
        private int _KHOA;
        private string _TINH;

        public string MSSV { get => _MSSV; set => _MSSV = value; }
        public string TENTRUONG { get => _TENTRUONG; set => _TENTRUONG = value; }
        public string TENLOP { get => _TENLOP; set => _TENLOP = value; }
        public string TENNGANH { get => _TENNGANH; set => _TENNGANH = value; }
        public int KHOA { get => _KHOA; set => _KHOA = value; }
        public string TINH { get => _TINH; set => _TINH = value; }

        public SINHVIEN(string MSSV, string TENTRUONG, string TENLOP, string TENNGANH, int KHOA, string TINH)
        {
            this.MSSV = MSSV;
            this.TENTRUONG = TENTRUONG;
            this.TENLOP = TENLOP;
            this.TENNGANH = TENNGANH;
            this.KHOA = KHOA;
            this.TINH = TINH;
        }
    }
}
