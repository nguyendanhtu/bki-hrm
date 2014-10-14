﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using IP.Core.IPCommon;
using DevExpress.XtraBars.Docking;
using GuiDev;
using DevExpress.XtraTab;
using BKI_HRM.HeThong;
using BKI_HRM.UCControl;
using IP.Core.IPSystemAdmin;
using System.Diagnostics;
using BKI_HRM.US;
using BKI_HRM.DS;
using BKI_HRM.NghiepVu;
namespace BKI_HRM {
    public partial class f002_main_form : DevComponents.DotNetBar.OfficeForm {
        public f002_main_form() {
            InitializeComponent();
            add_thong_bao();
            format_control();
        }
        #region Public Interfaces
        public void display(ref IPConstants.HowUserWantTo_Exit_MainForm v_exitmode) {
            try {
                ShowDialog();
                v_exitmode = m_exitmode;
                
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }
        #endregion

        #region Members
        IPConstants.HowUserWantTo_Exit_MainForm m_exitmode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
        TabAdd m_obj_tab = new TabAdd();
        #endregion

        #region Private Methods
        public void refresh() {
            nhan_vien_hien_tai();
        }
        private void close_tab_A(bool ip_y_n) {
            if(ip_y_n == true)
                m_xtab_control.TabPages.RemoveAt(m_xtab_control.SelectedTabPageIndex);
        }
        private void add_thong_bao() {
            DockPanel v_pnl = dockManager1.AddPanel(DockingStyle.Left);
            v_pnl.Text = "THÔNG BÁO";

            v_pnl.ControlContainer.Controls.Add(m_pnl_thong_bao);
            m_pnl_thong_bao.Dock = DockStyle.Fill;
            v_pnl.Options.ShowCloseButton = false;
            v_pnl.Visibility = DockVisibility.AutoHide;
            v_pnl.DockManager.DockingOptions.HideImmediatelyOnAutoHide = true;
        }
        private void format_control() {
            set_define_events();
        }
        private void nhan_vien_hien_tai() {
            US_V_DM_DU_LIEU_NHAN_VIEN v_us = new US_V_DM_DU_LIEU_NHAN_VIEN();
            DS_V_DM_DU_LIEU_NHAN_VIEN v_ds = new DS_V_DM_DU_LIEU_NHAN_VIEN();
            decimal v_dc_so_luong_nv_hien_tai = 0;
            v_us.count_nhan_vien(v_ds, "hiện tại",
                CAppContext_201.getCurrentIDPhapnhan(),
                ref v_dc_so_luong_nv_hien_tai);

            //toolStripStatusLabel2.Text = "Số lượng nhân viên hiện tại: " + v_dc_so_luong_nv_hien_tai;
        }
        private void thu_viec_sap_het_han() {
            US_V_DM_DU_LIEU_NHAN_VIEN v_us = new US_V_DM_DU_LIEU_NHAN_VIEN();
            DS_V_DM_DU_LIEU_NHAN_VIEN v_ds = new DS_V_DM_DU_LIEU_NHAN_VIEN();
            decimal v_dc_so_luong_nv = 0;
            //  f103_bao_cao_tra_cuu_nhan_su v_frm = new f103_bao_cao_tra_cuu_nhan_su();
            v_us.count_nhan_vien(v_ds, "thử việc hết hạn"
                , CAppContext_201.getCurrentIDPhapnhan()
                , ref v_dc_so_luong_nv);
            if(v_dc_so_luong_nv <= 0) {
                m_lbl_thu_viec_sap_het_han.Text = @"Không có Thử việc sắp hết hạn";
            }
            else {
                m_lbl_thu_viec_sap_het_han.Text = @"Có " + v_dc_so_luong_nv.ToString() +
                                                  " Thử việc sắp hết hạn!";
            }
            // v_frm.display_thu_viec_sap_het_han();
        }
        private void nhan_vien_chinh_thuc() {
            US_V_GD_QUA_TRINH_LAM_VIEC_2 v_us = new US_V_GD_QUA_TRINH_LAM_VIEC_2();
            DS_V_GD_QUA_TRINH_LAM_VIEC_2 v_ds = new DS_V_GD_QUA_TRINH_LAM_VIEC_2();
            decimal v_dc_so_luong_nv = 0;
            //  f103_bao_cao_tra_cuu_nhan_su v_frm = new f103_bao_cao_tra_cuu_nhan_su();
            v_us.count_nhan_vien_chinh_thuc(v_ds, DateTime.Now
                , ref v_dc_so_luong_nv, CAppContext_201.getCurrentIDPhapnhan());

            m_lbl_nv_chinh_thuc.Text = @"Có " + v_dc_so_luong_nv.ToString() +
                                                  " nhân viên chính thức trên 6 tháng.";

            // v_frm.display_thu_viec_sap_het_han();
        }
        private void nghi_viec_sap_quay_lai() {
            US_V_DM_DU_LIEU_NHAN_VIEN v_us = new US_V_DM_DU_LIEU_NHAN_VIEN();
            DS_V_DM_DU_LIEU_NHAN_VIEN v_ds = new DS_V_DM_DU_LIEU_NHAN_VIEN();
            //f103_bao_cao_tra_cuu_nhan_su v_frm = new f103_bao_cao_tra_cuu_nhan_su();
            decimal v_dc_so_luong_nv = 0;
            v_us.count_nhan_vien(v_ds, "nghỉ việc quay lại"
                , CAppContext_201.getCurrentIDPhapnhan()
                , ref v_dc_so_luong_nv);
            if(v_dc_so_luong_nv <= 0) {
                m_lbl_sap_quay_lai.Text = @"Không có Nghỉ sắp quay lại";
            }
            else {
                m_lbl_sap_quay_lai.Text = @"Có " + v_dc_so_luong_nv.ToString() +
                                                  " Nhân viên đang nghỉ!";
            }
            //v_frm.display_nghi_sap_quay_lai();
        }
        private void canh_bao_hop_dong() {
            f702_bao_cao_hdld frm = new f702_bao_cao_hdld();
            m_lbl_thong_bao_hop_dong_sap_het_han.Text =
                string.Format("Có {0} hợp đồng sắp hết hạn!", frm.count_record_bao_cao_sap_het_han());
            m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky.Text =
                string.Format("Có {0} hợp đồng đã quá hạn và chưa ký mới!",
                              frm.count_record_bao_cao_het_han_nhung_chua_ky_moi());
        }
        #endregion

        #region Events
        private void set_define_events() {
            m_xtab_control.CloseButtonClick += m_xtab_control_CloseButtonClick;
            m_cmd_phan_quyen_chi_tiet.ItemClick +=m_cmd_phan_quyen_chi_tiet_ItemClick;
            m_cmd_phan_quyen_he_thong.ItemClick += m_cmd_phan_quyen_he_thong_ItemClick;
            m_cmd_phan_quyen_cho_nhom.ItemClick += m_cmd_phan_quyen_cho_nhom_ItemClick;
            m_cmd_nguoi_su_dung.ItemClick += m_cmd_nguoi_su_dung_ItemClick;
            m_cmd_nhom_nguoi_su_dung.ItemClick += m_cmd_nhom_nguoi_su_dung_ItemClick;
            m_cmd_danh_muc_control.ItemClick += m_cmd_danh_muc_control_ItemClick;
            m_cmd_tu_dien_he_thong.ItemClick += m_cmd_tu_dien_he_thong_ItemClick;
            m_cmd_backup_recovery.ItemClick += m_cmd_backup_recovery_ItemClick;
            m_cmd_huong_dan_su_dung.ItemClick += m_cmd_huong_dan_su_dung_ItemClick;

            //Danh mục
            m_cmd_ql_chuc_vu.ItemClick += m_cmd_ql_chuc_vu_ItemClick;
            m_cmd_ql_cap_bac.ItemClick += m_cmd_ql_cap_bac_ItemClick;
            m_cmd_ql_don_vi.ItemClick += m_cmd_ql_don_vi_ItemClick;
            m_cmd_ql_phap_nhan.ItemClick += m_cmd_ql_phap_nhan_ItemClick;
            m_cmd_ql_quyet_dinh.ItemClick += m_cmd_ql_quyet_dinh_ItemClick;
            m_cmd_ky.ItemClick += m_cmd_ky_ItemClick;

            //Nghiệp vụ
            m_cmd_ho_so_nhan_su.ItemClick += m_cmd_ho_so_nhan_su_ItemClick;
            m_cmd_thay_doi_chuc_vu_don_vi.ItemClick += m_cmd_thay_doi_chuc_vu_don_vi_ItemClick;
            m_cmd_trang_thai_lao_dong.ItemClick += m_cmd_trang_thai_lao_dong_ItemClick;
            m_cmd_chi_tiet_cap_bac.ItemClick += m_cmd_chi_tiet_cap_bac_ItemClick;
            m_cmd_qua_trinh_di_cong_tac.ItemClick += m_cmd_qua_trinh_di_cong_tac_ItemClick;
            m_cmd_thong_tin_du_an.ItemClick += m_cmd_thong_tin_du_an_ItemClick;
            m_cmd_hop_dong_lao_dong.ItemClick += m_cmd_hop_dong_lao_dong_ItemClick;
            m_cmd_luongqd.ItemClick += m_cmd_luongqd_ItemClick;
            m_cmd_import_luong_theo_qd.ItemClick += m_cmd_import_luong_theo_qd_ItemClick;
            m_cmd_bao_cao_du_an.ItemClick += m_cmd_bao_cao_du_an_ItemClick;
        }

        void m_cmd_bao_cao_du_an_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f502_bao_cao_du_an v_frm = new f502_bao_cao_du_an();
                v_frm.close_tab_B = new f502_bao_cao_du_an.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_bc_du_an", v_frm.Text, v_uc);

                f502_bao_cao_du_an frm502 = new f502_bao_cao_du_an();
                m_lbl_du_an_sap_kt.Text = string.Format("Có {0} dự án sắp kết thúc. Click để xem chi tiết!",
                                                        frm502.count_record_du_an_sap_ket_thuc());
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_import_luong_theo_qd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f801_import_excel_luong_theo_qd v_frm = new f801_import_excel_luong_theo_qd();
                v_frm.close_tab_B = new f801_import_excel_luong_theo_qd.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_import_luong", v_frm.Text, v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_luongqd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f301_V_GD_LUONG_THEO_QD v_frm = new f301_V_GD_LUONG_THEO_QD();
                v_frm.close_tab_B = new f301_V_GD_LUONG_THEO_QD.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_luong_theo_qd", v_frm.Text, v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_hop_dong_lao_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f701_v_hop_dong_lao_dong v_frm = new f701_v_hop_dong_lao_dong();
                v_frm.close_tab_B = new f701_v_hop_dong_lao_dong.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_hop_dong_lao_dong", v_frm.Text, v_uc);

                f702_bao_cao_hdld frm2 = new f702_bao_cao_hdld();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thong_tin_du_an_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                F500_DM_DU_AN v_frm = new F500_DM_DU_AN();
                v_frm.close_tab_B = new F500_DM_DU_AN.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_dm_du_an", v_frm.Text, v_uc);

                f502_bao_cao_du_an frm502 = new f502_bao_cao_du_an();
                m_lbl_du_an_sap_kt.Text = string.Format("Có {0} dự án sắp kết thúc!",
                                                        frm502.count_record_du_an_sap_ket_thuc());
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_qua_trinh_di_cong_tac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f206_v_gd_cong_tac v_frm = new f206_v_gd_cong_tac();
                v_frm.close_tab_B = new f206_v_gd_cong_tac.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_qua_trinh_di_cong_tac", v_frm.Text, v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chi_tiet_cap_bac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f105_v_gd_chi_tiet_cap_bac v_frm = new f105_v_gd_chi_tiet_cap_bac();
                v_frm.close_tab_B = new f105_v_gd_chi_tiet_cap_bac.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_chi_tiet_cap_bac", v_frm.Text, v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_trang_thai_lao_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f203_v_gd_trang_thai_lao_dong v_frm = new f203_v_gd_trang_thai_lao_dong(this);
                v_frm.close_tab_B = new f203_v_gd_trang_thai_lao_dong.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_trang_thai_lao_dong", v_frm.Text, v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thay_doi_chuc_vu_don_vi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f202_V_GD_QUA_TRINH_LAM_VIEC v_frm = new f202_V_GD_QUA_TRINH_LAM_VIEC(this);
                v_frm.close_tab_B = new f202_V_GD_QUA_TRINH_LAM_VIEC.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_thay_doi_chuc_vu", v_frm.Text, v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_ho_so_nhan_su_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f201_dm_nhan_su v_frm = new f201_dm_nhan_su();
                v_frm.close_tab_B = new f201_dm_nhan_su.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_ho_so_nhan_su", v_frm.Text, v_uc);

                nhan_vien_hien_tai();
                thu_viec_sap_het_han();
                nghi_viec_sap_quay_lai();
                canh_bao_hop_dong();
                nhan_vien_chinh_thuc();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_ky_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f300_DM_KY v_frm = new f300_DM_KY();
                v_frm.close_tab_B = new f300_DM_KY.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_dm_ky", v_frm.Text, v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_ql_quyet_dinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                F205_V_GD_QUYET_DINH v_frm = new F205_V_GD_QUYET_DINH();
                v_frm.close_tab_B = new F205_V_GD_QUYET_DINH.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_gd_quyet_dinh", v_frm.Text, v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_ql_phap_nhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f703_dm_phap_nhan v_frm = new f703_dm_phap_nhan();
                v_frm.close_tab_B = new f703_dm_phap_nhan.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_dm_phap_nhan", v_frm.Text, v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_ql_don_vi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f101_v_dm_don_vi v_frm = new f101_v_dm_don_vi();
                v_frm.close_tab_B = new f101_v_dm_don_vi.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_dm_don_vi", v_frm.Text, v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_ql_cap_bac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                F604_v_dm_cap_bac v_frm = new F604_v_dm_cap_bac();
                v_frm.close_tab_B = new F604_v_dm_cap_bac.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_ql_cap_bac", "F604 - Quản lý danh mục cấp bậc", v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_ql_chuc_vu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f401_V_DM_CHUC_VU v_frm = new f401_V_DM_CHUC_VU();
                v_frm.close_tab_B = new f401_V_DM_CHUC_VU.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_dm_chuc_vu", "F401 - Danh mục chức vụ", v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_huong_dan_su_dung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                ProcessStartInfo sInfo = new ProcessStartInfo("http://1drv.ms/XzwLat");
                Process.Start(sInfo);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_backup_recovery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f400_dialog v_frm = new f400_dialog();
                v_frm.ShowDialog();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tu_dien_he_thong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f100_TuDien v_frm = new f100_TuDien();
                v_frm.ShowDialog();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_danh_muc_control_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f991_v_ht_control_in_form v_frm = new f991_v_ht_control_in_form();
                v_frm.close_tab_B = new f991_v_ht_control_in_form.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_dm_control", "F991 - Danh mục Control", v_uc);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhom_nguoi_su_dung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f997_ht_nhom_nguoi_su_dung v_frm = new f997_ht_nhom_nguoi_su_dung();
                v_frm.close_tab_B = new f997_ht_nhom_nguoi_su_dung.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_nhom_nguoi_sd", "F997 - Thông tin nhóm người sử dụng", v_uc);
            }
            catch(Exception v_e) {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nguoi_su_dung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f999_ht_nguoi_su_dung v_frm = new f999_ht_nguoi_su_dung();
                v_frm.close_tab_B = new f999_ht_nguoi_su_dung.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_ht_nguoi_su_dung", "F999 - Thông tin người sử dụng", v_uc);
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_phan_quyen_cho_nhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f995_ht_phan_quyen_cho_nhom v_frm = new f995_ht_phan_quyen_cho_nhom();
                v_frm.close_tab_B = new f995_ht_phan_quyen_cho_nhom.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_phan_quyen_cho_nhom", "F995 - Phân quyền cho nhóm", v_uc);
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_phan_quyen_he_thong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f993_phan_quyen_he_thong v_frm = new f993_phan_quyen_he_thong();
                v_frm.close_tab_B = new f993_phan_quyen_he_thong.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_phan_quyen_he_thong", "F993 - Phân quyền hệ thống", v_uc);
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_chi_tiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                f994_phan_quyen_detail v_frm = new f994_phan_quyen_detail();
                v_frm.close_tab_B = new f994_phan_quyen_detail.close_tab(close_tab_A);
                uc_for_form v_uc = new uc_for_form();
                m_obj_tab.AddFormToUC(v_frm, v_uc);
                m_obj_tab.AddTab(m_xtab_control, "tab_phan_quyen_chi_tiet", "F994 - Phân quyền chi tiết", v_uc);
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_xtab_control_CloseButtonClick(object sender, EventArgs e) {
            try {
                m_xtab_control.TabPages.RemoveAt(m_xtab_control.SelectedTabPageIndex);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void f002_main_form_Load(object sender, EventArgs e) {
            try {
                
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}