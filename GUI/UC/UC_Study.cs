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

    public partial class UC_Study : UserControl
    {
        GetDataUCtoForm _GetDataUCtoForm = null;
        public static bool flag = false;
        public UC_Study()
        {
            InitializeComponent();
            
        }


        #region Events
        private void UC_Study_btn_Search_Click(object sender, EventArgs e)
        {
            //if (UC_Study_btn_ListKhoa.Text == "Danh sách")
            //{
                string cbNamHoc = UC_Study_cb_NamHoc.Text;
                string cbHocKy = UC_Study_cb_HocKy.Text;
                string cbKhoa = UC_Study_cb_Khoa.Text;
                string txbMSSV = UC_Study_txb_MSSV.Text;
                UC_Study_dtgv_Show1.Rows.Clear();
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
                        UC_Study_dtgv_Show1.Rows.Add(new object[] {
                            item.MAMH,
                            item.TENMH,
                            item.SOTC,
                            item.QT,
                            item.GK,
                            item.TH,
                            item.CK,
                            item.TBMON
                            });
                    }
                //}
            }
        }

        private void UC_Study_btn_Edit_Click(object sender, EventArgs e)
        {
            fStudy_Edit fEdit = new fStudy_Edit();
            flag = true;
            _GetDataUCtoForm = fEdit.SetValue;
            fEdit.Show();
        }

        private void UC_Study_dtgv_Show1_SelectionChanged(object sender, EventArgs e)
        {
            if(flag && UC_Study_dtgv_Show1.SelectedRows.Count>0)
            {
                _GetDataUCtoForm(
                    UC_Study_txb_MSSV.Text,
                    UC_Study_cb_NamHoc.Text,
                    UC_Study_cb_HocKy.Text,
                    UC_Study_dtgv_Show1.SelectedRows[0].Cells[0].Value.ToString(),
                    UC_Study_dtgv_Show1.SelectedRows[0].Cells[3].Value.ToString(),
                    UC_Study_dtgv_Show1.SelectedRows[0].Cells[4].Value.ToString(),
                    UC_Study_dtgv_Show1.SelectedRows[0].Cells[5].Value.ToString(),
                    UC_Study_dtgv_Show1.SelectedRows[0].Cells[6].Value.ToString());

            }   
        }

        #endregion

    }
}
