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
using System.Net.Mail;
using System.Net;
using System.IO;

namespace GUI.UC
{
    public partial class UC_Gmail : UserControl
    {
        Attachment attach = null;
        string attachPath = "";
        public UC_Gmail()
        {
            InitializeComponent();
        }

        // Author: Tuấn

        #region Method

        // Xử lí danh sách Gmail chuyển đi
        private string DSGuiDi()
        {
            string str="";
            foreach (DataGridViewRow item in dtgv.Rows)
            {
                DataGridViewCheckBoxCell chk = item.Cells[2] as DataGridViewCheckBoxCell;
                string toValue = item.Cells[0].Value.ToString() + "@gm.uit.edu.vn, ";
                if (Convert.ToBoolean(chk.Value) == true) str += toValue;
            }
            str = str.Substring(0,str.Length-2);
            return str;
        }

        // Khi gửi thì cần xử lí những thông tin gì
        private void SendMail(string from, string to, string subject, string mes, Attachment file = null)
        {
            if(from!="" && to!="" && subject!="" && mes!="")
                try
                {
                    MailMessage mess = new MailMessage(from, to, subject, mes);

                    if(file!=null)  mess.Attachments.Add(file);

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;

                    client.Credentials = new NetworkCredential(txb_username.Text, txb_password.Text);

                    client.Send(mess);
                    printInfo("Gửi thành công.", false);
                }
                catch
                {
                    printInfo("Gửi không thành công.", true);
                }
            else
            {
                printInfo("Vui lòng nhập đầy đủ các thông tin.", true);
            }
            
        }

        // In thông báo
        private void printInfo(string mes, bool flag)
        {
            //timer.Enabled = true;
            // flag = true : Thông báo lỗi
            if (flag)
            {

                txt_info.IconLeft = Properties.Resources.close;
                txt_info.ForeColor = Color.Red;
                txt_info.Text = mes;
                txt_info.Show();

            }
            else
            {
                txt_info.IconLeft = Properties.Resources.check;
                txt_info.ForeColor = Color.FromArgb(59, 181, 74);
                txt_info.Text = mes;
                txt_info.Show();
            }

        }
        #endregion



        #region Events
        // Tìm kiếm danh sách SV của các khoa.
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dtgv.Rows.Clear();

            List<GMAIL> DSSV = Gmail_BUS.Instance.GetListSV(cb_Khoa.Text);

            foreach(GMAIL item in DSSV)
            {
                dtgv.Rows.Add(new object[]
                {
                    item.MSSV,
                    item.HOTEN
                });
            }
        }

        // Xử lí nút SEND
        private void btn_send_Click(object sender, EventArgs e)
        {
            // Bắt lỗi nếu mở file không thành công.
            try
            {
                FileInfo file = new FileInfo(attachPath);
                attach = new Attachment(attachPath);
            }
            catch (Exception)
            {
                // Nếu không mở được thì không làm gì cả
                //MessageBox.Show("Sai đường dẫn", "Thông báo");
            }

            //Gửi một người
            if (!ToggleSwitch.Checked)
                SendMail(txb_username.Text, txb_to.Text, txb_subject.Text, txb_mes.Text, attach);
            //Gửi nhiều người
            else
            {
                string DS = DSGuiDi();
                SendMail(txb_username.Text, DS, txb_subject.Text, txb_mes.Text, attach);
                
            }
        }

        // Xử lí btn làm rỗng nội dung
        private void btn_empty_Click(object sender, EventArgs e)
        {
            txb_mes.Text = "";
        }


        // Xử lí btn đính kèm file 
        private void btn_attach_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                attachPath = openFile.FileName;
            }   
        }
        #endregion
    }
}
