﻿using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_HRM.US;
using BKI_HRM.DS;
using BKI_HRM.DS.CDBNames;

namespace BKI_HRM
{
    public partial class f201_DM_NHAN_SU_DE : Form
    {
    #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public f201_DM_NHAN_SU_DE()
        {
            InitializeComponent();
            format_controls();
        }
        public void display_for_insert(){
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            m_cbo_gioi_tinh.SelectedIndex = 0;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_NHAN_SU ip_us_dm_nhan_su){
            m_us_dm_nhan_su = ip_us_dm_nhan_su;
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_object_to_form();
            this.ShowDialog();
        }
        public void display_for_view(US_DM_NHAN_SU ip_us_dm_nhan_su)
        {
            m_us_dm_nhan_su = ip_us_dm_nhan_su;
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_object_to_form();
            m_txt_ma_nhan_vien.Enabled = false;
            m_txt_ho_dem.Enabled = false;
            m_txt_ten.Enabled = false;
            m_cbo_gioi_tinh.Enabled = false;
            m_dat_ngay_sinh.Enabled = false;
            m_txt_noi_sinh.Enabled = false;
            m_txt_nguyen_quan.Enabled = false;
            m_txt_cmnd.Enabled = false;
            m_dat_ngay_cap.Enabled = false;
            m_txt_noi_cap.Enabled = false;
            m_txt_ton_giao.Enabled = false;
            m_txt_dan_toc.Enabled = false;
            m_chk_trang_thai.Enabled = false;
            m_txt_trinh_do.Enabled = false;
            m_txt_noi_dao_tao.Enabled = false;
            m_txt_nam_tot_nghiep.Enabled = false;
            m_txt_chuyen_nganh.Enabled = false;
            m_txt_email_ca_nhan.Enabled = false;
            m_txt_email_co_quan.Enabled = false;
            m_txt_dia_chi.Enabled = false;
            m_txt_ho_khau.Enabled = false;
            m_txt_sdt_lien_he.Enabled = false;
            m_txt_so_dtdd.Enabled = false;
            m_txt_sdt_nha_rieng.Enabled = false;
            m_txt_nguoi_lien_he.Enabled = false;
            m_txt_quan_he.Enabled = false;
            m_txt_ma_so_thue.Enabled = false;

            m_cmd_refresh.Visible = false;
            m_cmd_save.Visible = false;
            this.ShowDialog();
        }
    #endregion

    #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_NHAN_SU m_us_dm_nhan_su = new US_DM_NHAN_SU();
    #endregion

    #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.KeyPreview = true;
        }
        private void us_object_to_form(){
            m_txt_ma_nhan_vien.Text = m_us_dm_nhan_su.strMA_NV;
            m_txt_ho_dem.Text = m_us_dm_nhan_su.strHO_DEM;
            m_txt_ten.Text = m_us_dm_nhan_su.strTEN;
            m_cbo_gioi_tinh.SelectedIndex = (m_us_dm_nhan_su.strGIOI_TINH.Equals("Nam") == true) ? 1 : 2;
            m_dat_ngay_sinh.Value = m_us_dm_nhan_su.datNGAY_SINH;
            m_txt_noi_sinh.Text = m_us_dm_nhan_su.strNOI_SINH;
            m_txt_nguyen_quan.Text = m_us_dm_nhan_su.strNGUYEN_QUAN;
            m_txt_cmnd.Text = m_us_dm_nhan_su.strCMND;
            m_dat_ngay_cap.Value = m_us_dm_nhan_su.datNGAY_CAP_CMND;
            m_txt_noi_cap.Text = m_us_dm_nhan_su.strNOI_CAP_CMND;
            m_txt_ton_giao.Text = m_us_dm_nhan_su.strTON_GIAO;
            m_txt_dan_toc.Text = m_us_dm_nhan_su.strDAN_TOC;
            m_chk_trang_thai.Checked = (m_us_dm_nhan_su.strTRANG_THAI.Equals("Y") == true) ? true : false;
            m_txt_trinh_do.Text = m_us_dm_nhan_su.strTRINH_DO;
            m_txt_noi_dao_tao.Text = m_us_dm_nhan_su.strNOI_DAO_TAO;
            m_txt_chuyen_nganh.Text = m_us_dm_nhan_su.strCHUYEN_NGANH;
            m_txt_nam_tot_nghiep.Text = CIPConvert.ToStr(m_us_dm_nhan_su.dcNAM_TOT_NGHIEP);
            m_txt_email_co_quan.Text = m_us_dm_nhan_su.strEMAIL_CQ;
            m_txt_email_ca_nhan.Text = m_us_dm_nhan_su.strEMAIL_CA_NHAN;
            m_txt_sdt_nha_rieng.Text = m_us_dm_nhan_su.strDT_NHA;
            m_txt_ma_so_thue.Text = m_us_dm_nhan_su.strMA_SO_THUE;
            m_txt_dia_chi.Text = m_us_dm_nhan_su.strCHO_O;
            m_txt_ho_khau.Text = m_us_dm_nhan_su.strHO_KHAU;
            m_txt_nguoi_lien_he.Text = m_us_dm_nhan_su.strNGUOI_LIEN_HE;
            m_txt_sdt_lien_he.Text = m_us_dm_nhan_su.strDI_DONG_LIEN_HE;
            m_txt_quan_he.Text = m_us_dm_nhan_su.strQUAN_HE;
        }
        private void form_to_us_object(){
            m_us_dm_nhan_su.strMA_NV = m_txt_ma_nhan_vien.Text;
            m_us_dm_nhan_su.strHO_DEM = m_txt_ho_dem.Text;
            m_us_dm_nhan_su.strTEN = m_txt_ten.Text;
            m_us_dm_nhan_su.strGIOI_TINH = ((m_cbo_gioi_tinh.SelectedIndex == 1) ? "Nam" : "Nữ");
            m_us_dm_nhan_su.datNGAY_SINH = m_dat_ngay_sinh.Value;
            m_us_dm_nhan_su.strNOI_SINH = m_txt_noi_sinh.Text;
            m_us_dm_nhan_su.strNGUYEN_QUAN = m_txt_nguyen_quan.Text;
            m_us_dm_nhan_su.strCMND = m_txt_cmnd.Text;
            m_us_dm_nhan_su.datNGAY_CAP_CMND = m_dat_ngay_cap.Value;
            m_us_dm_nhan_su.strNOI_CAP_CMND = m_txt_noi_cap.Text;
            m_us_dm_nhan_su.strTON_GIAO = m_txt_ton_giao.Text;
            m_us_dm_nhan_su.strDAN_TOC = m_txt_dan_toc.Text;
            m_us_dm_nhan_su.strTRANG_THAI = ((m_chk_trang_thai.Checked == true) ? "Y" : "N");
            m_us_dm_nhan_su.strTRINH_DO = m_txt_trinh_do.Text;
            m_us_dm_nhan_su.strNOI_DAO_TAO = m_txt_noi_dao_tao.Text;
            m_us_dm_nhan_su.strCHUYEN_NGANH = m_txt_chuyen_nganh.Text;
            m_us_dm_nhan_su.dcNAM_TOT_NGHIEP = CIPConvert.ToDecimal(m_txt_nam_tot_nghiep.Text);
            m_us_dm_nhan_su.strEMAIL_CQ = m_txt_email_co_quan.Text;
            m_us_dm_nhan_su.strEMAIL_CA_NHAN = m_txt_email_ca_nhan.Text;
            m_us_dm_nhan_su.strDT_NHA = m_txt_sdt_nha_rieng.Text;
            m_us_dm_nhan_su.strMA_SO_THUE = m_txt_ma_so_thue.Text;
            m_us_dm_nhan_su.strCHO_O = m_txt_dia_chi.Text;
            m_us_dm_nhan_su.strHO_KHAU = m_txt_ho_khau.Text;
            m_us_dm_nhan_su.strNGUOI_LIEN_HE = m_txt_nguoi_lien_he.Text;
            m_us_dm_nhan_su.strDI_DONG_LIEN_HE = m_txt_sdt_lien_he.Text;
            m_us_dm_nhan_su.strQUAN_HE = m_txt_quan_he.Text;
        }
        private bool check_validate_data_is_ok(){
            if (!CValidateTextBox.IsValid(m_txt_ma_nhan_vien, DataType.NumberType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_ho_dem, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_ten, DataType.StringType, allowNull.NO, true))
                return false;
            if (m_cbo_gioi_tinh.SelectedIndex == 0)
            {
                BaseMessages.MsgBox_Warning(6);
                return false;
            }
            if ((m_dat_ngay_sinh.Checked == true) && (DateTime.Today.Year - m_dat_ngay_sinh.Value.Year) < 15)
                return false;
            if (!CValidateTextBox.IsValid(m_txt_noi_sinh, DataType.StringType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_cmnd, DataType.NumberType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_noi_cap, DataType.StringType, allowNull.YES, true))
                return false;
            if (m_dat_ngay_cap.Value.Year < (m_dat_ngay_sinh.Value.Year + 14))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_ton_giao, DataType.StringType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_dan_toc, DataType.StringType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_nam_tot_nghiep, DataType.NumberType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_email_ca_nhan, DataType.StringType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_email_co_quan, DataType.StringType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_so_dtdd, DataType.NumberType, allowNull.YES, true) || (m_txt_so_dtdd.Text.Trim(' ').Length != 10 && m_txt_so_dtdd.Text.Trim(' ').Length != 11))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_sdt_nha_rieng, DataType.NumberType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_ma_so_thue, DataType.NumberType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_dia_chi, DataType.StringType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_ho_khau, DataType.StringType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_nguoi_lien_he, DataType.StringType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_sdt_lien_he, DataType.NumberType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_quan_he, DataType.StringType, allowNull.YES, true))
                return false;
            return true;
        }

        private void save_data(){
            if (check_validate_data_is_ok() == false) 
                return;
            form_to_us_object();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_nhan_su.Update();
                    break;
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_nhan_su.Insert();
                    break;
                default:
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhât!");
            this.Close();
        }
        private void xoa_trang(){
            m_txt_ma_nhan_vien.Text = "";
            m_txt_ho_dem.Text = "";
            m_txt_ten.Text = "";
            m_cbo_gioi_tinh.SelectedIndex = 0;
            m_dat_ngay_sinh.Value = DateTime.Today;
            m_txt_noi_sinh.Text = "";
            m_txt_nguyen_quan.Text = "";
            m_txt_cmnd.Text = "";
            m_dat_ngay_cap.Value = DateTime.Today;
            m_txt_noi_cap.Text = "";
            m_txt_ton_giao.Text = "";
            m_txt_dan_toc.Text = "";
            m_chk_trang_thai.Checked = false;
            m_txt_trinh_do.Text = "";
            m_txt_noi_dao_tao.Text = "";
            m_txt_chuyen_nganh.Text = "";
            m_txt_nam_tot_nghiep.Text = "";
            m_txt_email_co_quan.Text = "";
            m_txt_email_ca_nhan.Text = "";
            m_txt_sdt_nha_rieng.Text = "";
            m_txt_ma_so_thue.Text = "";
            m_txt_dia_chi.Text = "";
            m_txt_ho_khau.Text = "";
            m_txt_nguoi_lien_he.Text = "";
            m_txt_sdt_lien_he.Text = "";
            m_txt_quan_he.Text = "";
        }
        private void set_inital_form_load()
        {
            
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.UpdateDataState:
                    us_object_to_form();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                case DataEntryFormMode.InsertDataState:
                    
                    break;
                default:
                    break;
            }
        }
        
        private void set_define_event(){
            this.Load += new EventHandler(f201_DM_NHAN_SU_DE_Load);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_refresh.Click += new EventHandler(m_cmd_refresh_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            
        }
        
    #endregion

    #region Event Hanlders
        private void f201_DM_NHAN_SU_DE_Load(object sendrer, EventArgs e){
            try
            {
            	set_inital_form_load();
            }
            catch (Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_save_Click(object sender, EventArgs e){
            try
            {
            	save_data();
            }
            catch (Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle( v_e);
            }
        }
        private void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                xoa_trang();
            }
            catch (Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle( v_e);
            }
        }
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle( v_e);
            }
        }
        
        
    #endregion

    }
}
