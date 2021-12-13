using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KQHT
    {
        #region field
        private string _HOTEN;
        private string _MAMH;
        private string _TENMH;
        private int _SOTC;
        private string _QT;
        private string _GK;
        private string _TH;
        private string _CK;
        private string _TBMON;
        private int _NAMHOC;
        private string _HOCKY;
        #endregion

        #region property
        public string HOTEN { get => _HOTEN; set => _HOTEN = value; }
        public string MAMH { get => _MAMH; set => _MAMH = value; }
        public string TENMH { get => _TENMH; set => _TENMH = value; }
        public int SOTC { get => _SOTC; set => _SOTC = value; }
        public string QT { get => _QT; set => _QT = value; }
        public string GK { get => _GK; set => _GK = value; }
        public string TH { get => _TH; set => _TH = value; }
        public string CK { get => _CK; set => _CK = value; }
        public string TBMON { get => _TBMON; set => _TBMON = value; }
        public int NAMHOC { get => _NAMHOC; set => _NAMHOC = value; }
        public string HOCKY { get => _HOCKY; set => _HOCKY = value; }
        #endregion


        #region method
        public KQHT(string hoten, string mamh, string tenmh, int sotc, string qt, string gk, string th, string ck, string tbmon, int namhoc, string hocky)
        {
            this.HOTEN = hoten;
            this.MAMH = mamh;
            this.TENMH = tenmh;
            this.SOTC = sotc;
            this.QT = qt;
            this.GK = gk;
            this.TH = th;
            this.CK = ck;
            this.TBMON = tbmon;
            this.NAMHOC = namhoc;
            this.HOCKY = hocky;
        }


        public KQHT(DataRow row)
        {
            //this.HOTEN = (string)row["HOTEN"];
            //this.MAMH = (string)row["MAMH"];
            //this.TENMH = (string)row["TENMH"];
            //this.SOTC = (int)row["SOTC"];
            //this.QT =       float.Parse(row["QT"].ToString());
            //this.GK =       float.Parse(row["GK"].ToString());
            //this.TH =       float.Parse(row["TH"].ToString());
            //this.CK =       float.Parse(row["CK"].ToString());
            //this.TBMON =    float.Parse(row["TBMON"].ToString());

            this.HOTEN = (string)row["HOTEN"];
            this.MAMH = (string)row["MAMH"];
            this.TENMH = (string)row["TENMH"];
            this.SOTC = (int)row["SOTC"];
            if (row["QT"] == DBNull.Value)
                this.QT = "";
            else
                this.QT = row["QT"].ToString();
            if (row["GK"] == DBNull.Value)
                this.GK = "";
            else
                this.GK = row["GK"].ToString();
            if (row["TH"] == DBNull.Value)
                this.TH = "";
            else
                this.TH = row["TH"].ToString();
            if (row["CK"] == DBNull.Value)
                this.CK = "";
            else
                this.CK = row["CK"].ToString();
            if (row["TBMON"] == DBNull.Value)
                this.TBMON = "";
            else
                this.TBMON = row["TBMON"].ToString();
        }
        #endregion
    }
    public class DTK
    {
        
        private string _MSSV;
        private string _HOTEN;
        private float _TBKH1;
        private float _TBHK2;
        private float _TBNAM;
        
        
        
        public string MSSV { get => _MSSV; set => _MSSV = value; }
        public string HOTEN { get => _HOTEN; set => _HOTEN = value; }
        public float TBKH1 { get => _TBKH1; set => _TBKH1 = value; }
        public float TBHK2 { get => _TBHK2; set => _TBHK2 = value; }
        public float TBNAM { get => _TBNAM; set => _TBNAM = value; }
        
        
        
        public DTK(DataRow row)
        {
            this.MSSV = (string)row["MSSV"];
            this.HOTEN = (string)row["HOTEN"];
            this.TBKH1 = float.Parse(row["TBHK1"].ToString());
            this.TBHK2 = float.Parse(row["TBHK2"].ToString());
            this.TBNAM = (TBKH1 + TBHK2) / 2;
        }
    }
}
