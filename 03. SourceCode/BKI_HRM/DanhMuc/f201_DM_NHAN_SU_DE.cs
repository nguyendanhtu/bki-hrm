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
using System.Net.Mail;
using System.Text.RegularExpressions;

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
            m_txt_ma_nhan_vien.Focus();
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
            m_ptb_anh.Image = m_ptb_anh.ErrorImage;
        }
        private void chon_anh()
        {
            m_ofd_chon_anh.Filter = "(*.jpg)|*.jpg";
            m_ofd_chon_anh.Multiselect = false;
            m_ofd_chon_anh.Title = "Chọn ảnh";
            DialogResult result = m_ofd_chon_anh.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_ptb_anh.SizeMode = PictureBoxSizeMode.Zoom;
                m_ptb_anh.Image = new Bitmap(m_ofd_chon_anh.FileName);
            }
        }
        private void us_object_to_form(){
            m_txt_ma_nhan_vien.Text = m_us_dm_nhan_su.strMA_NV;
            m_txt_ho_dem.Text = m_us_dm_nhan_su.strHO_DEM;
            m_txt_ten.Text = m_us_dm_nhan_su.strTEN;
            m_cbo_gioi_tinh.SelectedIndex = (m_us_dm_nhan_su.strGIOI_TINH.Equals("Nam") == true) ? 1 : 2;
            if (m_us_dm_nhan_su.datNGAY_SINH.Year > 1900)
                m_dat_ngay_sinh.Value = m_us_dm_nhan_su.datNGAY_SINH;
            else
                m_dat_ngay_sinh.Checked = false;
            m_txt_noi_sinh.Text = m_us_dm_nhan_su.strNOI_SINH;
            m_txt_nguyen_quan.Text = m_us_dm_nhan_su.strNGUYEN_QUAN;
            m_txt_cmnd.Text = m_us_dm_nhan_su.strCMND;
            if (m_us_dm_nhan_su.datNGAY_CAP_CMND.Year > 1900)
                m_dat_ngay_cap.Value = m_us_dm_nhan_su.datNGAY_CAP_CMND;
            else
                m_dat_ngay_cap.Checked = false;
            m_txt_noi_cap.Text = m_us_dm_nhan_su.strNOI_CAP_CMND;
            m_txt_ton_giao.Text = m_us_dm_nhan_su.strTON_GIAO;
            m_txt_dan_toc.Text = m_us_dm_nhan_su.strDAN_TOC;
            
            m_ofd_chon_anh.FileName = m_us_dm_nhan_su.strANH;
            if (m_us_dm_nhan_su.strANH != "")
                m_ptb_anh.Image = new Bitmap(m_ofd_chon_anh.FileName);
            
            m_txt_trinh_do.Text = m_us_dm_nhan_su.strTRINH_DO;
            m_txt_noi_dao_tao.Text = m_us_dm_nhan_su.strNOI_DAO_TAO;
            m_txt_chuyen_nganh.Text = m_us_dm_nhan_su.strCHUYEN_NGANH;
            m_txt_nam_tot_nghiep.Text = (m_us_dm_nhan_su.dcNAM_TOT_NGHIEP>0)?CIPConvert.ToStr(m_us_dm_nhan_su.dcNAM_TOT_NGHIEP):"";
            m_txt_email_co_quan.Text = m_us_dm_nhan_su.strEMAIL_CQ;
            m_txt_email_ca_nhan.Text = m_us_dm_nhan_su.strEMAIL_CA_NHAN;
            m_txt_so_dtdd.Text = m_us_dm_nhan_su.strDI_DONG;
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
            m_us_dm_nhan_su.strANH = m_ofd_chon_anh.FileName;
            if(m_dat_ngay_sinh.Checked == true)
                m_us_dm_nhan_su.datNGAY_SINH = m_dat_ngay_sinh.Value;
            m_us_dm_nhan_su.strNOI_SINH = m_txt_noi_sinh.Text;
            m_us_dm_nhan_su.strNGUYEN_QUAN = m_txt_nguyen_quan.Text;
            m_us_dm_nhan_su.strCMND = m_txt_cmnd.Text;
            if(m_dat_ngay_cap.Checked == true)
                m_us_dm_nhan_su.datNGAY_CAP_CMND = m_dat_ngay_cap.Value;
            m_us_dm_nhan_su.strNOI_CAP_CMND = m_txt_noi_cap.Text;
            m_us_dm_nhan_su.strTON_GIAO = m_txt_ton_giao.Text;
            m_us_dm_nhan_su.strDAN_TOC = m_txt_dan_toc.Text;
            m_us_dm_nhan_su.strTRINH_DO = m_txt_trinh_do.Text;
            m_us_dm_nhan_su.strNOI_DAO_TAO = m_txt_noi_dao_tao.Text;
            m_us_dm_nhan_su.strCHUYEN_NGANH = m_txt_chuyen_nganh.Text;
            if (m_txt_nam_tot_nghiep.Text.Trim().Length > 0)
                m_us_dm_nhan_su.dcNAM_TOT_NGHIEP = CIPConvert.ToDecimal(m_txt_nam_tot_nghiep.Text);
            m_us_dm_nhan_su.strEMAIL_CQ = m_txt_email_co_quan.Text;
            m_us_dm_nhan_su.strEMAIL_CA_NHAN = m_txt_email_ca_nhan.Text;
            m_us_dm_nhan_su.strDI_DONG = m_txt_so_dtdd.Text;
            m_us_dm_nhan_su.strDT_NHA = m_txt_sdt_nha_rieng.Text;
            m_us_dm_nhan_su.strMA_SO_THUE = m_txt_ma_so_thue.Text;
            m_us_dm_nhan_su.strCHO_O = m_txt_dia_chi.Text;
            m_us_dm_nhan_su.strHO_KHAU = m_txt_ho_khau.Text;
            m_us_dm_nhan_su.strNGUOI_LIEN_HE = m_txt_nguoi_lien_he.Text;
            m_us_dm_nhan_su.strDI_DONG_LIEN_HE = m_txt_sdt_lien_he.Text;
            m_us_dm_nhan_su.strQUAN_HE = m_txt_quan_he.Text;
        }
        private bool check_trung_ma_nv(string ip_str_ma_nv)
        {
           
            DS_DM_NHAN_SU v_ds = new DS_DM_NHAN_SU();
            decimal count_ma_nv;
            m_us_dm_nhan_su.FillDataset_search_by_ma_nv(v_ds, ip_str_ma_nv);
            count_ma_nv = v_ds.DM_NHAN_SU.Count;
            if (count_ma_nv > 0)
                return true;
            return false;
        }
        private bool check_validate_data_is_ok(){
            if (!CValidateTextBox.IsValid(m_txt_ma_nhan_vien, DataType.NumberType, allowNull.NO, true)){
                BaseMessages.MsgBox_Warning(201);
                return false;
            }
            
            if (!CValidateTextBox.IsValid(m_txt_ho_dem, DataType.StringType, allowNull.NO, true) || CIPConvert.is_valid_number(m_txt_ho_dem)){
                BaseMessages.MsgBox_Warning(202);
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ten, DataType.StringType, allowNull.NO, true) || CIPConvert.is_valid_number(m_txt_ten))
            {
                BaseMessages.MsgBox_Warning(203);
                return false;
            }
            if (m_cbo_gioi_tinh.SelectedIndex == 0)
            {
                BaseMessages.MsgBox_Warning(204);
                return false;
            }
            if ((m_dat_ngay_sinh.Checked == true) && (DateTime.Today.Year - m_dat_ngay_sinh.Value.Year) < 15){
                BaseMessages.MsgBox_Warning(205);
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_noi_sinh, DataType.StringType, allowNull.YES, true)){
                BaseMessages.MsgBox_Warning(206);
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_cmnd, DataType.NumberType, allowNull.YES, true)){
                BaseMessages.MsgBox_Warning(208);
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_noi_cap, DataType.StringType, allowNull.YES, true))
                return false;
            
            if ((m_dat_ngay_cap.Checked == true) && (m_dat_ngay_cap.Value.Year < (m_dat_ngay_sinh.Value.Year + 14))){
                BaseMessages.MsgBox_Warning(209);
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ton_giao, DataType.StringType, allowNull.YES, true)){
                
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_dan_toc, DataType.StringType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_nam_tot_nghiep, DataType.NumberType, allowNull.YES, true)
                || ((m_txt_nam_tot_nghiep.Text.Trim().Length > 0)&&(CIPConvert.ToDecimal(m_txt_nam_tot_nghiep.Text) > DateTime.Today.Year))){
                //BaseMessages.MsgBox_Warning(211);
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_email_ca_nhan, DataType.StringType, allowNull.YES, true) || !check_validate_email(m_txt_email_ca_nhan.Text))
            {
                BaseMessages.MsgBox_Warning(211);
                m_txt_email_ca_nhan.BackColor = Color.Bisque;
                m_txt_email_ca_nhan.Focus();
                m_txt_email_ca_nhan.SelectAll();
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_email_co_quan, DataType.StringType, allowNull.YES, true) || !check_validate_email(m_txt_email_co_quan.Text))
            {
                BaseMessages.MsgBox_Warning(211);
                m_txt_email_co_quan.BackColor = Color.Bisque;
                m_txt_email_co_quan.Focus();
                m_txt_email_co_quan.SelectAll();
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_so_dtdd, DataType.StringType, allowNull.YES, true))
            {
               
                BaseMessages.MsgBox_Warning(210);
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_sdt_nha_rieng, DataType.StringType, allowNull.YES, true)){
                BaseMessages.MsgBox_Warning(210);
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ma_so_thue, DataType.NumberType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_dia_chi, DataType.StringType, allowNull.YES, true)){
                BaseMessages.MsgBox_Warning(210);
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ho_khau, DataType.StringType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_nguoi_lien_he, DataType.StringType, allowNull.YES, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_sdt_lien_he, DataType.StringType, allowNull.YES, true)){
                BaseMessages.MsgBox_Warning(210);
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_quan_he, DataType.StringType, allowNull.YES, true))
                return false;
            return true;
        }

        private void save_data(){
            
            switch (m_e_form_mode)
            {
                    
                case DataEntryFormMode.UpdateDataState:
                    if (check_validate_data_is_ok() == false)
                        return;
                    else
                    {
                        form_to_us_object();
                        m_us_dm_nhan_su.Update();
                    }
                        
                    break;
                case DataEntryFormMode.InsertDataState:
                    if (check_trung_ma_nv(m_txt_ma_nhan_vien.Text))
                    {
                        BaseMessages.MsgBox_Warning(212);
                        m_txt_ma_nhan_vien.BackColor = Color.Bisque;
                        m_txt_ma_nhan_vien.Focus();
                        m_txt_ma_nhan_vien.SelectAll();
                        return;
                    }
                    else
                    {
                        m_txt_ma_nhan_vien.BackColor = Color.White;
                        if (check_validate_data_is_ok() == false)
                            return;
                        else
                        {
                            form_to_us_object();
                            m_us_dm_nhan_su.Insert();
                        }
                        
                    }
                    
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
            m_txt_trinh_do.Text = "";
            m_txt_noi_dao_tao.Text = "";
            m_txt_chuyen_nganh.Text = "";
            m_txt_nam_tot_nghiep.Text = "";
            m_txt_email_co_quan.Text = "";
            m_txt_email_ca_nhan.Text = "";
            m_txt_so_dtdd.Text = "";
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
        private bool check_validate_email(string emailaddress)
        {
            if (emailaddress == "") return true;
            string MatchEmailPattern =
            @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
            + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
              + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
            + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";


           
             return Regex.IsMatch(emailaddress, MatchEmailPattern);
                
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
      

        private void m_ptb_anh_Click(object sender, EventArgs e)
        {
            try
            {
                chon_anh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_ma_nhan_vien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                )
            {
                e.Handled = true;
            }


        }

        private void m_txt_cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        )
            {
                e.Handled = true;
            }


        }

        private void m_txt_nam_tot_nghiep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        )
            {
                e.Handled = true;
            }
            
            if ((sender as TextBox).Text.Length > 3)
            {
                e.Handled = true;
            }
        }

        private void m_txt_so_dtdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }


        }

        private void m_txt_sdt_nha_rieng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }


        }

        private void m_txt_sdt_lien_he_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }


        }

        private void m_txt_ho_dem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {

                e.Handled = true;
            }


        }

        private void m_txt_ten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void m_txt_ton_giao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {

                e.Handled = true;
            }
        }

        private void m_txt_dan_toc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {

                e.Handled = true;
            }
        }

        private void m_txt_noi_cap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {

                e.Handled = true;
            }
        }

        private void m_txt_ma_so_thue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void m_txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsLetterOrDigit(e.KeyChar) 
        && e.KeyChar != '.' && e.KeyChar != '@' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
            // only allow one @
            if (e.KeyChar == '@'
                && (sender as TextBox).Text.IndexOf('@') > -1)
            {
                e.Handled = true;
            }
            
        }
        private void m_ptb_anh_MouseHover(object sender, EventArgs e)
        {
            m_ptb_anh.Image = m_ptb_anh.ErrorImage;
        }

        private void m_ptb_anh_MouseLeave(object sender, EventArgs e)
        {
            if (m_ofd_chon_anh.FileName != "")
                m_ptb_anh.Image = new Bitmap(m_ofd_chon_anh.FileName);
        }

    #endregion

       
        
        
    }
}