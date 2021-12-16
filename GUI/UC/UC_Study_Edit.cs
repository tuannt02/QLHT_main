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

// Author: Phúc

namespace GUI.UC
{
    // Khai báo kiểu dữ liệu delegate cho mục đích truyền dữ liệu từ UC sang fEdit
    public delegate void GetDataUCtoForm(string mssv, string namhoc, string hocky, string mamh, string QT, string GK, string TH, string CK);
    
    // Khai báo kiểu dữ liệu delegate cho mục đích truyền dữ liệu từ fEdit sang UC
    public delegate void GetValue(string QT, string GK, string TH, string CK);
    public partial class UC_Study : UserControl
    {
        GetDataUCtoForm _GetDataUCtoForm = null;

        // flag = true nếu form Edit đang tương tác
        public static bool flag = false;
        public UC_Study()
        {
            InitializeComponent();
            cb_NamHoc.SelectedIndex = 3;
            cb_HocKy.SelectedIndex = 0;
            cb_Khoa.SelectedIndex = 0;
            if(!fLogin.Login.ADMIN)
            {
                btn_Edit.Hide();
            }
        }

        #region Methods

        // Hàm nhận dữ liệu từ form Edit 
        public void ChangeInfo_dtgv(string QT, string GK, string TH, string CK)
        {
            dtgv.SelectedRows[0].Cells[3].Value = QT;
            dtgv.SelectedRows[0].Cells[4].Value = GK;
            dtgv.SelectedRows[0].Cells[5].Value = TH;
            dtgv.SelectedRows[0].Cells[6].Value = CK;
            //dtgv.SelectedRows[0].Cells[7].Value = (int.Parse(QT) * 0.1 + int.Parse(GK) * 0.2 + int.Parse(TH) * 0.2 + int.Parse(CK) * 0.5).ToString();

            if (QT == "" || GK == "" || TH == "" || CK == "")
                dtgv.SelectedRows[0].Cells[7].Value = "";
            else
                dtgv.SelectedRows[0].Cells[7].Value = (int.Parse(QT) * 0.1 + int.Parse(GK) * 0.2 + int.Parse(TH) * 0.2 + int.Parse(CK) * 0.5).ToString();
        }
        #endregion

        #region Events

        // Xử lí btn Search
        private void UC_Study_btn_Search_Click(object sender, EventArgs e)
        {
            //if (UC_Study_btn_ListKhoa.Text == "Danh sách")
            //{
                string cbNamHoc = cb_NamHoc.Text;
                string cbHocKy = cb_HocKy.Text;
                string cbKhoa = cb_Khoa.Text;
                string txbMSSV = txb_MSSV.Text;
                dtgv.Rows.Clear();
                if (Kqht_BUS.Instance.KQHT_Search_Check(cbNamHoc, cbHocKy, cbKhoa, txbMSSV))
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin cần tìm kiếm",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                else
                {
                    

                    List<KQHT> DS_kqht = BUS.Kqht_BUS.Instance.GetListKQHT(cbNamHoc, cbHocKy, cbKhoa, txbMSSV);

                    if (DS_kqht.Count > 0)
                        UC_Study_lab_Name.Text = DS_kqht[0].HOTEN;
                    else
                        UC_Study_lab_Name.Text = "Không tìm thấy";
                    foreach (KQHT item in DS_kqht)
                    {
                        dtgv.Rows.Add(new object[] {
                            item.MAMH,
                            item.TENMH,
                            item.SOTC,
                            item.QT,
                            item.GK,
                            item.TH,
                            item.CK,
                            item.TBMON,
                            item.TBMON == "" ? imageList.Images[2] : (float.Parse(item.TBMON) >= 5 ? imageList.Images[0] : imageList.Images[1])
                            });
                    }
                }
        }

        // Xử lí btn Edit
        private void UC_Study_btn_Edit_Click(object sender, EventArgs e)
        {
            fStudy_Edit fEdit = new fStudy_Edit(ChangeInfo_dtgv);

            // fEdit đang mở nên flag = true
            //flag = true;
            fStudy_Edit.flag = true;
            
            // Truyền dữ liệu sang form Edit
            _GetDataUCtoForm = fEdit.SetValue;
            fEdit.Show();
        }

        
        //public void ChangeInfo_dtgv(string QT, string GK, string TH, string CK)
        //{
        //    dtgv.SelectedRows[0].Cells[3].Value = QT;
        //    dtgv.SelectedRows[0].Cells[4].Value = GK;
        //    dtgv.SelectedRows[0].Cells[5].Value = TH;
        //    dtgv.SelectedRows[0].Cells[6].Value = CK;
        //    dtgv.SelectedRows[0].Cells[7].Value = (int.Parse(QT) * 0.1 + int.Parse(GK) * 0.2 + int.Parse(TH) * 0.2 + int.Parse(CK) * 0.5).ToString();
        //}

        // Mỗi lần người dùng click vào từng row sau đó truyền dữ liệu qua form Edit
        private void dtgv_SelectionChanged(object sender, EventArgs e)
        {
            if (fStudy_Edit.flag && dtgv.SelectedRows.Count > 0)
            {
                _GetDataUCtoForm(
                    txb_MSSV.Text,
                    cb_NamHoc.Text,
                    cb_HocKy.Text,
                    dtgv.SelectedRows[0].Cells[0].Value.ToString(),
                    dtgv.SelectedRows[0].Cells[3].Value.ToString(),
                    dtgv.SelectedRows[0].Cells[4].Value.ToString(),
                    dtgv.SelectedRows[0].Cells[5].Value.ToString(),
                    dtgv.SelectedRows[0].Cells[6].Value.ToString());

            }
        }

        #endregion
    }
}
