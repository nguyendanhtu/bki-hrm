﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_HRM
{
    public partial class f400_Main : Form
    {
        public f400_Main()
        {
            InitializeComponent();
        }

        public void display(ref IP.Core.IPCommon.IPConstants.HowUserWantTo_Exit_MainForm v_exitmode)
        {
            this.ShowDialog();
        }
        private void quáTrìnhLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f200_V_GD_QUA_TRINH_LAM_VIEC frm = new f200_V_GD_QUA_TRINH_LAM_VIEC();
            frm.Show();
        }

        private void trạngTháiLaoĐộngToolStripMenuItem_Click(object sender, EventArgs e) {
           f100_V_GD_TRANG_THAI_LAO_DONG frm = new f100_V_GD_TRANG_THAI_LAO_DONG();
            frm.Show();
        }

        private void hợpĐồngLaoĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f300_V_GD_HOP_DONG_LAO_DONG frm = new f300_V_GD_HOP_DONG_LAO_DONG();
            frm.Show();
        }

        
    }
}
