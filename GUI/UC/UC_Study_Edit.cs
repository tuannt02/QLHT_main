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

namespace GUI.UC
{
    public delegate void GetDataUCtoForm(string mssv, string namhoc, string hocky, string mamh, string QT, string GK, string TH, string CK);
    public delegate void GetValue(string QT, string GK, string TH, string CK);
    public partial class UC_Study : UserControl
    {
        GetDataUCtoForm _GetDataUCtoForm = null;
        public static bool flag = false;
        public UC_Study()
        {
            InitializeComponent();
            cb_NamHoc.SelectedIndex = 3;
            cb_HocKy.SelectedIndex = 0;
            cb_Khoa.SelectedIndex = 0;
            //dtgv_Show1.Hide();
        }


        #region Events
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
                        UC_Study_lab_Name.Text = "Not found";
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
                            null
                            });
                    }
                //}
            }
        }

        private void UC_Study_btn_Edit_Click(object sender, EventArgs e)
        {
            fStudy_Edit fEdit = new fStudy_Edit(ChangeInfo_dtgv);

            flag = true;
            _GetDataUCtoForm = fEdit.SetValue;
            fEdit.Show();
        }

        
        public void ChangeInfo_dtgv(string QT, string GK, string TH, string CK)
        {
            dtgv.SelectedRows[0].Cells[3].Value = QT;
            dtgv.SelectedRows[0].Cells[4].Value = GK;
            dtgv.SelectedRows[0].Cells[5].Value = TH;
            dtgv.SelectedRows[0].Cells[6].Value = CK;
            dtgv.SelectedRows[0].Cells[7].Value = (int.Parse(QT) * 0.1 + int.Parse(GK) * 0.2 + int.Parse(TH) * 0.2 + int.Parse(CK) * 0.5).ToString();
        }
        #endregion

        private void dtgv_SelectionChanged(object sender, EventArgs e)
        {
            if (flag && dtgv.SelectedRows.Count > 0)
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

        private void txb_MSSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
