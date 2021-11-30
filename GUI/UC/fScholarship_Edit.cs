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

// Author: Tuấn

namespace GUI.UC
{
    public partial class fScholarship_Edit : Form
    {
        // Nếu form đang mở flag = true, tránh tràn lỗi từ form UC_Scho đổ qua.
        public static bool flag = false;

        // Thuộc tính kiểm tra người dùng có thay đổi MAHB
        private string firstMAHB;
        public fScholarship_Edit()
        {
            InitializeComponent();
        }

        #region Methods

        // Lấy dữ liệu từ UC_Study cho chức năng Edit
        public void SetData(string MAHB, string TENHB, string TRIGIA, string TGDK, string TGKT, string DVTT)
        {
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

        // Hàm in thông báo
        private void printInfo(string mes, bool flag)
        {
            timer.Enabled = true;

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

        // Ẩn thông báo sau 2s
        private void HideInfo(object sender, EventArgs e)
        {
            txt_info.Hide();
            timer.Enabled = false;
        }
        #endregion



        #region Events
        // Hủy sự kiện form Edit
        private void btn_back_Click(object sender, EventArgs e)
        {
            flag = false;
            Close();
        }

        //Xử lí btn xóa một dòng
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện, chỉ được xóa nếu MAHB ko rỗng và các trường còn lại rỗng
            if(txt_MAHB.Text != "" && txt_TENHB.Text == "" &&
                txt_TRIGIA.Text == "" && txt_DVTT.Text == "")
            {
                // Xuống BUS kiểm tra nếu MAHB tồn tại thì xóa
                if (Hocbong_BUS.Instance.DeleteOneRow(txt_MAHB.Text))
                {
                    // Sau khi xóa thì thông báo cho form UC_Scholarship cần update dtgv
                    UC_Scholarship.flagUpdate = true;
                    printInfo("Xóa thành công.", false);
                }
                else printInfo("MAHB không tồn tại.", true);
            }
            else printInfo("Nếu xóa vui lòng nhập duy nhất trường MAHB.", true);
        }

        //Xử lí btn thêm một dòng
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Kiểm tra đk, chỉ được thêm mới MAHB chưa tồn tại và các trường không rỗng
            if (!Hocbong_BUS.Instance.checkMAHBexits(txt_MAHB.Text) &&
                txt_TENHB.Text != "" &&
                txt_TRIGIA.Text!= "" &&
                txt_DVTT.Text!= "")
            {
                // Xuống BUS cập nhật CSDL
                Hocbong_BUS.Instance.InsertOneRow(txt_MAHB.Text, txt_TENHB.Text, txt_TRIGIA.Text, 
                    dtp_TGDK.Value,
                    dtp_TGKT.Value, 
                    txt_DVTT.Text);

                // Sau khi thêm thì thông báo cho form UC_Scholarship cần update dtgv
                UC_Scholarship.flagUpdate = true;


                printInfo("Thêm thành công.", false);
            }
            else
            {
                printInfo("Thêm thất bại.", true);
            }
        }

        // Xử lí btn chỉnh sửa một dòng
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có sửa MAHB hay không
            if(firstMAHB != txt_MAHB.Text) 
                printInfo("Không được sửa MAHB.", true);
            else if(txt_TENHB.Text == "" || txt_TRIGIA.Text == "" || txt_DVTT.Text == "")
            {
                printInfo("Vui lòng nhập đầy đủ thông tin các trường.", true);
                
            }
            else
            {
                // Xuống Bus cập nhật CSDL
                Hocbong_BUS.Instance.UpdateOneRow(txt_MAHB.Text, txt_TENHB.Text, txt_TRIGIA.Text, dtp_TGDK.Value,
                    dtp_TGKT.Value, txt_DVTT.Text);

                // Sau khi chỉnh sửa thì thông báo cho form UC_Scholarship cần update dtgv
                UC_Scholarship.flagUpdate = true;
                printInfo("Cập nhật thành công.", false);
                
            }
        }
        #endregion
    }
}
