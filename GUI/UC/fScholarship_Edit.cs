using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Globalization;

namespace GUI.UC
{
    public partial class fScholarship_Edit : Form
    {
        public static bool flag = false;
        private string firstMAHB;
        public fScholarship_Edit()
        {
            InitializeComponent();
        }

        #region Methods

        // Lấy dữ liệu từ UC_Study cho chức năng Edit
        public void SetData(string MAHB, string TENHB, string TRIGIA, string TGDK, string TGKT, string DVTT)
        {
            //10/31/2020 12:00:00 AM
            //DateTime _TGDK = DateTime.Parse(TGDK,"dd/MM/yyyy HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
            CultureInfo culture = new CultureInfo("en-US");
            DateTime _TGDK = Convert.ToDateTime(TGDK, culture);
            DateTime _TGKT = Convert.ToDateTime(TGKT, culture);
            txt_MAHB.Text = MAHB;
            txt_TENHB.Text = TENHB;
            txt_TRIGIA.Text = TRIGIA;
            dtp_TGDK.Value = _TGDK;
            dtp_TGKT.Value = _TGKT;
            txt_DVTT.Text = DVTT;
            firstMAHB = MAHB;
        }
        #endregion



        #region Events
        private void btn_back_Click(object sender, EventArgs e)
        {
            flag = false;
            Close();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(txt_MAHB.Text != "" && txt_TENHB.Text == "" &&
                txt_TRIGIA.Text == "" && txt_DVTT.Text == "")
            {
                if (Hocbong_BUS.Instance.DeleteOneRow(txt_MAHB.Text))
                {
                    UC_Scholarship.flagUpdate = true;
                    printInfo("Xóa thành công.", false);
                    //txt_info.IconLeft = Properties.Resources.check;
                    //txt_info.ForeColor = Color.FromArgb(59, 181, 74);
                    //txt_info.Text = "Xóa thành công.";
                }
                else
                {
                    printInfo("MAHB không tồn tại.", true);
                    //txt_info.IconLeft = Properties.Resources.close;
                    //txt_info.ForeColor = Color.Red;
                    //txt_info.Text = "MAHB không tồn tại.";
                }
            }
            else
            {
                printInfo("Nếu xóa vui lòng nhập duy nhất trường MAHB.", true);
                //txt_info.IconLeft = Properties.Resources.close;
                //txt_info.ForeColor = Color.Red;
                //txt_info.Text = "Nếu xóa vui lòng nhập duy nhất trường MAHB.";
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!Hocbong_BUS.Instance.checkMAHBexits(txt_MAHB.Text) &&
                txt_TENHB.Text != "" &&
                txt_TRIGIA.Text!= "" &&
                txt_DVTT.Text!= "")
            {
                UC_Scholarship.flagUpdate = true;

                Hocbong_BUS.Instance.InsertOneRow(txt_MAHB.Text, txt_TENHB.Text, txt_TRIGIA.Text, dtp_TGDK.Value,
                    dtp_TGKT.Value, txt_DVTT.Text);
                printInfo("Thêm thành công.", false);
                //txt_info.IconLeft = Properties.Resources.check;
                //txt_info.ForeColor = Color.FromArgb(59, 181, 74);
                //txt_info.Text = "Thêm thành công.";
            }
            else
            {
                printInfo("Thêm thất bại.", true);
                //txt_info.IconLeft = Properties.Resources.close;
                //txt_info.ForeColor = Color.Red;
                //txt_info.Text = "Thêm thất bại.";
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if(firstMAHB != txt_MAHB.Text)
            {
                printInfo("Không được sửa MAHB.", true);
                //txt_info.IconLeft = Properties.Resources.close;
                //txt_info.ForeColor = Color.Red;
                //txt_info.Text = "Không được sửa MAHB.";
            }
            else if(txt_TENHB.Text == "" || txt_TRIGIA.Text == "" || txt_DVTT.Text == "")
            {
                printInfo("Vui lòng nhập đầy đủ thông tin các trường.", true);
                //txt_info.IconLeft = Properties.Resources.close;
                //txt_info.ForeColor = Color.Red;
                //txt_info.Text = "Vui lòng nhập đầy đủ thông tin các trường.";
            }
            else
            {
                UC_Scholarship.flagUpdate = true;
                Hocbong_BUS.Instance.UpdateOneRow(txt_MAHB.Text, txt_TENHB.Text, txt_TRIGIA.Text, dtp_TGDK.Value,
                    dtp_TGKT.Value, txt_DVTT.Text);
                printInfo("Cập nhật thành công.", false);
                //txt_info.IconLeft = Properties.Resources.check;
                //txt_info.ForeColor = Color.FromArgb(59, 181, 74);
                //txt_info.Text = "Cập nhật thành công.";
            }
        }
        #endregion
        private void printInfo(string mes, bool flag)
        {
            timer.Enabled = true;

            if(flag)
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
        private void HideInfo(object sender, EventArgs e)
        {
            txt_info.Hide();
            timer.Enabled = false;
        }
    }
}
