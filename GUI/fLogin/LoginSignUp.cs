using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI.fLogin
{
    public partial class LoginSignUp : Form
    {
        //Accept MSSV, Username, Password
        bool flagMSSV = false;
        bool flagUsername = false;
        bool flagPassword = false;

        public LoginSignUp()
        {
            InitializeComponent();
        }


        #region Methods
        private void printInfo(string mes, bool flag, int status, bool retrive)
        {
            //timer.Enabled = true;
            // flag = true : Thông báo lỗi
            // status (0: MSSV, 1: username, 2: password)
            // retrive = true: Người dùng chưa nhập gì cả

            if (retrive)
            {
                if (status == 0)
                {
                    flagMSSV = false;
                    txb_MSSV_info.Text = "";
                    txb_mssv.IconRight = null;
                }
                if (status == 1)
                {
                    flagUsername = false;
                    txb_username_info.Text = "";
                    txb_username.IconRight = null;
                }
                if (status == 2)
                {
                    flagPassword = false;
                    txb_password_info.Text = "";
                    txb_password.IconRight = null;
                }
            }
            else
            {
                if (flag)
                {
                    if (status == 0)
                    {
                        flagMSSV = false;
                        txb_MSSV_info.Text = mes;
                        txb_mssv.IconRight = Properties.Resources.close;
                    }
                    if (status == 1)
                    {
                        flagUsername = false;
                        txb_username_info.Text = mes;
                        txb_username.IconRight = Properties.Resources.close;
                    }
                    if (status == 2)
                    {
                        flagPassword = false;
                        txb_password_info.Text = mes;
                        txb_password.IconRight = Properties.Resources.close;
                    }

                }
                else
                {

                    if (status == 0)
                    {
                        flagMSSV = true;
                        txb_MSSV_info.Text = "";
                        txb_mssv.IconRight = Properties.Resources.checkLG;
                    }
                    if (status == 1)
                    {
                        flagUsername = true;
                        txb_username_info.Text = "";
                        txb_username.IconRight = Properties.Resources.checkLG;
                    }
                    if (status == 2)
                    {
                        flagPassword = true;
                        txb_password_info.Text = "";
                        txb_password.IconRight = Properties.Resources.checkLG;
                    }
                }
            }

        }
        #endregion


        #region Events

        // Nút trở về form Login
        private void fLogin_LoginSignUp_btn_backto_Click(object sender, EventArgs e)
        {
            Hide();
            Login.Instance.Show();
        }

        // Nút tạo Account
        private void fLogin_LoginSignUp_btn_creAcc_Click(object sender, EventArgs e)
        {
            string MSSV = txb_mssv.Text;
            string username = txb_username.Text;
            string password = txb_password.Text;
            //if(Login_BUS.Instance.LoginSignUp_Check(MSSV, username, password))
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    if (Login_BUS.Instance.LoginSignUp_CheckMSSVExitst(MSSV))
            //        MessageBox.Show("MSSV đã tồn tại", "Thông báo",
            //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    else
            //    {
            //        Login_BUS.Instance.InsertAcc(MSSV, username, password);
            //        MessageBox.Show("Đăng kí thành công", "Thông báo",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    } 
            //}
            if(flagMSSV && flagUsername && flagPassword)
            {
                Login_BUS.Instance.InsertAcc(MSSV, username, password);
                        MessageBox.Show("Đăng kí thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Đăng kí không thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Hiển thị thời gian thực chấp nhận MSSV đó hay không
        private void txb_mssv_TextChanged(object sender, EventArgs e)
        {
            string MSSV = txb_mssv.Text;
            if (MSSV.Length == 0) 
                printInfo("", true, 0,true);
            else if (MSSV.Length < 8) 
                printInfo("MSSV phải trên 8 kí tự !", true, 0,false);
            else if (Login_BUS.Instance.LoginSignUp_CheckMSSVExitst(MSSV))
                printInfo("MSSV đã tồn tại !", true, 0, false);
            else
                printInfo("Đạt", false, 0, false);
        }

        // Hiển thị thời gian thực chấp nhận username đó hay không
        private void txb_username_TextChanged(object sender, EventArgs e)
        {
            string username = txb_username.Text;
            if (username.Length == 0) 
                printInfo("", true, 1, true);
            else if (username.Length < 6)
                printInfo("Username phải trên 6 kí tự !", true, 1, false);
            else if (Login_BUS.Instance.LoginSignUp_CheckUsernameExists(username))
                printInfo("Username đã tồn tại !", true, 1, false);
            else
                printInfo("Đạt", false, 1, false);
        }

        // Hiển thị thời gian thực chấp nhận password đó hay không
        private void txb_password_TextChanged(object sender, EventArgs e)
        {
            string password = txb_password.Text;
            if (Login_BUS.Instance.LoginSignUp_CheckPassword(password) == 0)
                printInfo("", true, 2, true);
            else if (Login_BUS.Instance.LoginSignUp_CheckPassword(password) == 1)
                printInfo("Mật khẩu tối thiểu là 8 ký tự", true, 2, false);
            else if (Login_BUS.Instance.LoginSignUp_CheckPassword(password) == 2)
                printInfo("Mật khẩu phải bao gồm ký tự và chữ cái", true, 2, false);
            else
                printInfo("Đạt", false, 2, false);
        }
        #endregion
    }
}
