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

        bool flagNewPW = false, flagReNewPW = false;

        public UC_Setting()
        {
            InitializeComponent();
            Get_Info_from_Temp();
            Load_picbox();
        }

        #region Methods
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
                ptb_Anhthe.Image = Properties.Resources.userdefault;
        }


        //Load du lieu vao control
        public void Get_Info_from_Temp()
        {
            SETTING info = Setting_BUS.Instance.Get_Info_from_Temp();
            txb_MSSV.Text = info.MSSV;
            txb_HoTen.Text = info.HOTEN;
            txb_QueQuan.Text = info.QUEQUAN;

            cb_Khoa.SelectedIndex = cb_Khoa.FindStringExact(info.MAKHOA);

            if (info.GIOITINH == true)
                ckb_gt1.Checked = true;
            else
            {
                ckb_gt0.Checked = true;
            }
            //CultureInfo cultureInfo = new CultureInfo("vi-VN");
            //dtpk_NGSINH.Value = Convert.ToDateTime(info.NGAYSINH.ToString(), cultureInfo);
            dtpk_NGSINH.Value = DateTime.Parse(info.NGAYSINH.ToString());
        }

        //In thông tin
        private void printInfo(string mes,bool flag, int status,bool retrive)
        {
            // flag = true: thông báo lỗi
            // status = 1: typepass, 2: retype
            // retrive: mật khẩu để trống

            if (retrive)
            {
                if (status == 1)
                {
                    flagNewPW = false;
                    txb_newpass_info.Text = "";
                    txb_New_Password.IconRight = null;
                }
                if (status == 2)
                {
                    flagReNewPW = false;
                    txb_retype_info.Text = "";
                    txb_RePassword.IconRight = null;
                }
            }
            else
            {
                if (flag)
                {
                    if (status == 1)
                    {
                        flagNewPW = false;
                        txb_newpass_info.Text = mes;
                        txb_New_Password.IconRight = Properties.Resources.close;
                    }
                    if (status == 2)
                    {
                        flagReNewPW = false;
                        txb_retype_info.Text = mes;
                        txb_RePassword.IconRight = Properties.Resources.close;
                    }

                }
                else
                {
                    if (status == 1)
                    {
                        flagNewPW = true;
                        txb_newpass_info.Text = "";
                        txb_New_Password.IconRight = Properties.Resources.checkLG;
                    }
                    if (status == 2)
                    {
                        flagReNewPW = true;
                        txb_retype_info.Text = "";
                        txb_RePassword.IconRight = Properties.Resources.checkLG;
                    }
                }
            }

        }

        #endregion


        #region Events
        //Xu ly button thay doi password
        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            if (txb_Old_Password.Text == "" || txb_New_Password.Text == "" || txb_RePassword.Text == "")
                MessageBox.Show("Nhập chưa đủ thông tin");

            else if (txb_New_Password.Text != txb_RePassword.Text)
                MessageBox.Show("Kiểm tra lại mật khẩu mới");

            else if (!(flagNewPW && flagReNewPW))
                MessageBox.Show("Chưa thỏa điều kiện");

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

            Setting_BUS.Instance.Update_SinhVien(txb_HoTen.Text, txb_QueQuan.Text, flag, dtpk_NGSINH.Value, cb_Khoa.SelectedItem.ToString());

            MessageBox.Show("Đã cập nhật thông tin");
        }

        //Xu ly button thay doi va luu anh vao database
        private void btn_ChangeImage_Click(object sender, EventArgs e)
        {
            //Load ảnh lên picturebox
            openFileDialog_setting.Filter = "files JPG (*.jpg)|*.jpg|files PNG (*.png)|*.png|All files(*.*)|*.*";
            openFileDialog_setting.Title = "Chọn ảnh đại diện";

            if(openFileDialog_setting.ShowDialog() == DialogResult.OK)
            {
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

                Setting_BUS.Instance.Update_Image(txb_MSSV.Text, img);

                MessageBox.Show("Thay đổi ảnh thành công");
            }

        }
        private void txb_New_Password_TextChanged(object sender, EventArgs e)
        {
            string NewPW = txb_New_Password.Text;
            if (Login_BUS.Instance.LoginSignUp_CheckPassword(NewPW) == 0)
                printInfo("", true, 1, true);
            else if (Login_BUS.Instance.LoginSignUp_CheckPassword(NewPW) == 1)
                printInfo("Mật khẩu tối thiểu là 8 ký tự", true, 1, false);
            else if (Login_BUS.Instance.LoginSignUp_CheckPassword(NewPW) == 2)
                printInfo("Mật khẩu phải bao gồm ký tự và chữ cái", true, 1, false);
            else
                printInfo("Đạt", false, 1, false);
        }
        private void txb_RePassword_TextChanged(object sender, EventArgs e)
        {
            string ReNewPW = txb_RePassword.Text;
            if (Login_BUS.Instance.LoginSignUp_CheckPassword(ReNewPW) == 0)
                printInfo("", true, 2, true);
            else if (Login_BUS.Instance.LoginSignUp_CheckPassword(ReNewPW) == 1)
                printInfo("Mật khẩu tối thiểu là 8 ký tự", true, 2, false);
            else if (Login_BUS.Instance.LoginSignUp_CheckPassword(ReNewPW) == 2)
                printInfo("Mật khẩu phải bao gồm ký tự và chữ cái", true, 2, false);
            else
                printInfo("Đạt", false, 2, false);

        }

        #endregion

    }
}
