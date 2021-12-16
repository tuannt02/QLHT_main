using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAO
{
    public class SETTING_DAO
    {
        private static SETTING_DAO instance;

        public static SETTING_DAO Instance
        {
            get { if (instance == null) instance = new SETTING_DAO(); return instance; }
            private set => instance = value;
        }

        private SETTING_DAO() { }

        public SETTING Get_Info_from_Temp()
        {
            string query = "USP_Load_Info_from_Temp";

            DataTable Data = DataProvider.Instance.ExecuteQuery(query);
            DataRow row = Data.Rows[0];
            SETTING item = new SETTING(row);
            return item;
        }

        public DataTable Check_Password(string password)
        {
            string query = "USP_CheckPassword @Password";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { password });
        }

        public void Change_Password(string password)
        {
            string query = "USP_ChangePassword @NewPass";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { password });
        }

        public SETTING Update_SinhVien(string hoten, string quequan, bool gioitinh, DateTime ngaysinh, string makhoa)
        {
            string query = "USP_UPDATE_SV @HOTEN , @QUEQUAN , @NGSINH , @GIOITINH , @MAKHOA ";
            DataTable Data = DataProvider.Instance.ExecuteQuery(query, new object[] { hoten, quequan, ngaysinh, gioitinh, makhoa });
            return Get_Info_from_Temp();
        }

        public void Update_Image(string mssv, byte[] img)
        {
            string query = "UPDATE_IMG @MSSV , @IMG";
            DataTable Data = DataProvider.Instance.ExecuteQuery(query, new object[] { mssv, img });
        }


        public byte[] Get_Image(string mssv)
        {
            DataTable Data = DataProvider.Instance.ExecuteQuery("select ANH from SINHVIEN where MSSV = " + mssv);



            DataRow row = Data.Rows[0];

            if (row["ANH"] != DBNull.Value)
                return (byte[])row["ANH"];



            return null;
        }
    }
}
