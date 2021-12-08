using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Setting_BUS
    {
        private static Setting_BUS instance;

        public static Setting_BUS Instance
        {
            get { if (instance == null) instance = new Setting_BUS(); return instance; }
            private set => instance = value;
        }

        private Setting_BUS() { }

        public SETTING Get_Info_from_Temp()
        {
            return SETTING_DAO.Instance.Get_Info_from_Temp();
        }


        public bool Check_Password(string password)
        {
            return SETTING_DAO.Instance.Check_Password(password).Rows.Count > 0;
        }





        public void Change_Password(string password)
        {
            SETTING_DAO.Instance.Change_Password(password);
        }





        public SETTING Update_SinhVien(string hoten, string quequan, bool gioitinh, DateTime ngaysinh, string makhoa)
        {
            return SETTING_DAO.Instance.Update_SinhVien(hoten, quequan, gioitinh, ngaysinh, makhoa);
        }





        public void Update_Image(string mssv, byte[] img)
        {
            SETTING_DAO.Instance.Update_Image(mssv, img);
        }





        //public void Insert_Image(string mssv, byte[] img)
        //{
        // SETTING_DAO.Instance.Insert_Image(mssv, img);
        //}





        public byte[] Get_Image(string mssv)
        {
            byte[] image = SETTING_DAO.Instance.Get_Image(mssv);



            return image;
        }
    }
}
