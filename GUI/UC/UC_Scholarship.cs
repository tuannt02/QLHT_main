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

namespace GUI.UC
{
    // Khai báo delegate cho mục đích truyền dữ liệu từ UC sang form
    public delegate void GetDataUC_SCHOtoForm(string MAHB, string TENHB, string TRIGIA, string TGDK, string TGKT, string DVTT); 

    public partial class UC_Scholarship : UserControl
    {
        GetDataUC_SCHOtoForm _GetDataUC_SCHOtoForm = null;
        public static bool flag = false;
        public fScholarship_Authorize f1 = null;

        private int Recs;
        public UC_Scholarship()
        {
            InitializeComponent();
            LoadDataFull();
            //UC_AboutUs_btn_CheckAdmin.Hide();
            
        }
        #region Methods
        void LoadDataFull()
        {
            UC_AboutUs_dtgv_Show.Rows.Clear();
            List<HOCBONG> listHS = Hocbong_BUS.Instance.getListHBFull();
            Recs = listHS.Count;
            UC_AboutUs_lab_Rec.Text = "Records: " + listHS.Count.ToString();
            UC_AboutUs_lab_Fil.Text = "Filter: " + listHS.Count.ToString() + "/" + listHS.Count.ToString();

            foreach (HOCBONG item in listHS)
            {
                UC_AboutUs_dtgv_Show.Rows.Add(new object[]
                {
                    item.MAHB,
                    item.TENHB,
                    item.TRIGIA,
                    item.TGDK,
                    item.TGKT,
                    item.STATUS ? UC_AboutUs_imgList_ListImg.Images[1] : UC_AboutUs_imgList_ListImg.Images[0],
                    item.DVTT,
                }) ;
            }
        } 
        void LoadDataActive()
        {
            UC_AboutUs_dtgv_Show.Rows.Clear();
            List<HOCBONG> listHS = Hocbong_BUS.Instance.getListHBActive();
            Recs = listHS.Count;
            UC_AboutUs_lab_Rec.Text = "Records: " + listHS.Count.ToString();
            UC_AboutUs_lab_Fil.Text = "Filter: " + listHS.Count.ToString() + "/" + listHS.Count.ToString();
            foreach (HOCBONG item in listHS)
            {
                UC_AboutUs_dtgv_Show.Rows.Add(new object[]
                {
                    item.MAHB,
                    item.TENHB,
                    item.TRIGIA,
                    item.TGDK,
                    item.TGKT,
                    item.STATUS ? UC_AboutUs_imgList_ListImg.Images[1] : UC_AboutUs_imgList_ListImg.Images[0],
                    item.DVTT,
                });
            }
        }
        void LoadDataUnActive()
        {
            UC_AboutUs_dtgv_Show.Rows.Clear();
            List<HOCBONG> listHS = Hocbong_BUS.Instance.getListHBUnActive();

            Recs = listHS.Count;
            UC_AboutUs_lab_Rec.Text = "Records: " + listHS.Count.ToString();

            UC_AboutUs_lab_Fil.Text = "Filter: " + listHS.Count.ToString() + "/" + listHS.Count.ToString();

            foreach (HOCBONG item in listHS)
            {
                UC_AboutUs_dtgv_Show.Rows.Add(new object[]
                {
                    item.MAHB,
                    item.TENHB,
                    item.TRIGIA,
                    item.TGDK,
                    item.TGKT,
                    item.STATUS ? UC_AboutUs_imgList_ListImg.Images[1] : UC_AboutUs_imgList_ListImg.Images[0],
                    item.DVTT,
                });
            }
        }
        void LoadDataFilter()
        {
            UC_AboutUs_dtgv_Show.Rows.Clear();
            List<HOCBONG> listHS = Hocbong_BUS.Instance.getListHBFilter(UC_AboutUs_txb_Search.Text);

            UC_AboutUs_lab_Fil.Text = "Filter: " + listHS.Count.ToString() + "/" + Recs.ToString();

            foreach (HOCBONG item in listHS)
            {
                UC_AboutUs_dtgv_Show.Rows.Add(new object[]
                {
                    item.MAHB,
                    item.TENHB,
                    item.TRIGIA,
                    item.TGDK,
                    item.TGKT,
                    item.STATUS ? UC_AboutUs_imgList_ListImg.Images[1] : UC_AboutUs_imgList_ListImg.Images[0],
                    item.DVTT,
                });
            }
        }
        #endregion

        #region Events
        private void UC_AboutUs_btn_Search_Click(object sender, EventArgs e)
        {
            LoadDataFilter();
        }

        private void UC_AboutUs_btn_All_Click(object sender, EventArgs e)
        {
            LoadDataFull();
        }

        private void UC_AboutUs_btn_Active_Click(object sender, EventArgs e)
        {
            LoadDataActive();
        }

        private void UC_AboutUs_btn_OnLeave_Click(object sender, EventArgs e)
        {
            LoadDataUnActive();
        }

        private void UC_AboutUs_btn_CheckAdmin_Click(object sender, EventArgs e)
        {
            fScholarship_Authorize a = new fScholarship_Authorize();
            f1 = a;
            a.Show();
            
        }
        private void UC_AboutUs_dtgv_Show_SelectionChanged(object sender, EventArgs e)
        {
            if(fScholarship_Edit.flag && UC_AboutUs_dtgv_Show.Rows.Count > 0)
            {
                _GetDataUC_SCHOtoForm = f1.f2.SetData;
                _GetDataUC_SCHOtoForm(
                    UC_AboutUs_dtgv_Show.SelectedRows[0].Cells[0].Value.ToString(),
                    UC_AboutUs_dtgv_Show.SelectedRows[0].Cells[1].Value.ToString(),
                    UC_AboutUs_dtgv_Show.SelectedRows[0].Cells[2].Value.ToString(),
                    UC_AboutUs_dtgv_Show.SelectedRows[0].Cells[3].Value.ToString(),
                    UC_AboutUs_dtgv_Show.SelectedRows[0].Cells[4].Value.ToString(),
                    UC_AboutUs_dtgv_Show.SelectedRows[0].Cells[6].Value.ToString()
                    );
            }
        }
        #endregion

    }
}
