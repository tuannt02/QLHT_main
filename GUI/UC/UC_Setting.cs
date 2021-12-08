using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using DTO;
using BUS;
using System.Globalization;

namespace GUI.UC
{
    public partial class UC_Setting : UserControl
    {
        public UC_Setting()
        {
            InitializeComponent();
            Get_Info_from_Temp();
            Load_picbox();
        }


        //Load du lieu vao picturebox
        private void Load_picbox()
        {
            byte[] img = Setting_BUS.Instance.Get_Image(txb_MSSV.Text);



            if (img != null)
            {
                MemoryStream ms = new MemoryStream(img);
                ptb_Anhthe.Image = Image.FromStream(ms);
            }



            else
                ptb_Anhthe.Image = Properties.Resources.about_us;
        }





        //Load du lieu vao control
        public void Get_Info_from_Temp()
        {
            SETTING info = Setting_BUS.Instance.Get_Info_from_Temp();
            txb_MSSV.Text = info.MSSV;
            txb_HoTen.Text = info.HOTEN;
            txb_MAKH.Text = info.MAKHOA;
            txb_QueQuan.Text = info.QUEQUAN;
            if (info.GIOITINH == true)
                ckb_gt1.Checked = true;
            else
            {
                ckb_gt0.Checked = true;
            }
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            dtpk_NGSINH.Value = Convert.ToDateTime(info.NGAYSINH.ToString(), cultureInfo);
        }





        //Xu ly button thay doi password
        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            if (txb_Old_Password.Text == "" || txb_New_Password.Text == "" || txb_RePassword.Text == "")
                MessageBox.Show("Nhập chưa đủ thông tin");



            else if (txb_New_Password.Text != txb_RePassword.Text)
                MessageBox.Show("Kiểm tra lại mật khẩu mới");

            else
            {
                if (Setting_BUS.Instance.Check_Password(txb_Old_Password.Text))
                {
                    Setting_BUS.Instance.Change_Password(txb_New_Password.Text);



                    MessageBox.Show("Đã thay đổi mật khẩu");
                }



                else
                    MessageBox.Show("Mật khẩu sai");
            }
        }





        //Xu ly button thay doi thong tin sinh vien
        private void btn_ChangeInfo_Click(object sender, EventArgs e)
        {
            bool flag = ckb_gt1.Checked ? true : false;



            Setting_BUS.Instance.Update_SinhVien(txb_HoTen.Text, txb_QueQuan.Text, flag, dtpk_NGSINH.Value, txb_MAKH.Text);



            MessageBox.Show("Đã cập nhật thông tin");
        }





        //Xu ly button thay doi va luu anh vao database
        private void btn_ChangeImage_Click(object sender, EventArgs e)
        {
            //Load ảnh lên picturebox



            openFileDialog_setting.ShowDialog();



            string file_img = openFileDialog_setting.FileName;

            if (string.IsNullOrEmpty(file_img))
                return;

            Image image = Image.FromFile(file_img);



            ptb_Anhthe.Image = image;

            //Save picture to database

            byte[] img = null;
            FileStream fs = new FileStream(file_img, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);


            //if (Setting_BUS.Instance.Get_Image(txb_MSSV.Text) == null)
            //
            // Setting_BUS.Instance.Insert_Image(txb_MSSV.Text, img);
            //
            //else
            Setting_BUS.Instance.Update_Image(txb_MSSV.Text, img);


            MessageBox.Show("Thay đổi ảnh thành công");
        }
    }
}
