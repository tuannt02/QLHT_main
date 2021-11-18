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
    public partial class UC_Scholarship : UserControl
    {
        private int Recs;
        public UC_Scholarship()
        {
            InitializeComponent();
            LoadDataFull();
            //UC_AboutUs_btn_CheckAdmin.Hide();
            
        }
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

        }
    }
}
