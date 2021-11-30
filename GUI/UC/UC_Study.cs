﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Tuấn

namespace GUI.UC
{
    public partial class UC_Study_Main : UserControl
    {
        public UC_Study_Main()
        {
            InitializeComponent();
        }


        #region Events

        // SubMenu btn Edit
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            uC_Study1.BringToFront();
        }

        // SubMenu btn DanhSach
        private void btn_DanhSach_Click(object sender, EventArgs e)
        {
            uC_Study_ListKhoa1.BringToFront();
        }

        #endregion
    }
}
