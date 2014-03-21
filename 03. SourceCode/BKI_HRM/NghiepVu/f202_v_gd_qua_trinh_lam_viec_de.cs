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
using System.Diagnostics;

namespace BKI_HRM
{
    public partial class f202_v_gd_qua_trinh_lam_viec_de : Form
    {
        #region Public Interfaces
        public void display()
        {
            this.ShowDialog();
        }
        public f202_v_gd_qua_trinh_lam_viec_de()
        {
            InitializeComponent();
            format_controls();
        }
        public void display_for_insert(US_V_GD_QUA_TRINH_LAM_VIEC ip_us_qua_trinh_lam_viec,string ip_str_loai_cv)
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            m_us_v_qua_trinh_lam_viec = ip_us_qua_trinh_lam_viec;
            us_object_to_form(ip_str_loai_cv);
            this.ShowDialog();
        }
        public void display_for_update(US_V_GD_QUA_TRINH_LAM_VIEC ip_us_qua_trinh_lam_viec)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_v_qua_trinh_lam_viec = ip_us_qua_trinh_lam_viec;
            us_object_to_form("");
            this.ShowDialog();
        }
#endregion

#region Members
        DataEntryFormMode m_e_form_mode;
        US_V_GD_QUA_TRINH_LAM_VIEC m_us_v_qua_trinh_lam_viec = new US_V_GD_QUA_TRINH_LAM_VIEC();
        DS_V_GD_QUA_TRINH_LAM_VIEC m_ds_v_qua_trinh_lam_viec = new DS_V_GD_QUA_TRINH_LAM_VIEC();
        US_GD_CHI_TIET_CHUC_VU m_us_chi_tiet_chuc_vu = new US_GD_CHI_TIET_CHUC_VU();
        US_DM_DON_VI m_us_dm_don_vi = new US_DM_DON_VI();
        US_DM_QUYET_DINH m_us_quyet_dinh = new US_DM_QUYET_DINH();
        DS_DM_QUYET_DINH m_ds_quyet_dinh = new DS_DM_QUYET_DINH();
        bool check_quyet_dinh_null = false;
#endregion

#region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.KeyPreview = true;
            load_data_to_cbo();
            
        }
        private void chon_file()
        {
            m_ofd_openfile.Filter = "(*.pdf)|*.pdf|(*.doc)|*.doc|(*.docx)|*.docx|(*.xls)|*.xls|(*.xlsx)|*.xlsx";
            m_ofd_openfile.Multiselect = false;
            m_ofd_openfile.Title = "Chọn tài liệu đính kèm";
            DialogResult result = m_ofd_openfile.ShowDialog();
        }
        private void mo_file()
        {
            Process.Start("explorer.exe", m_ofd_openfile.FileName);
        }
        private void load_data_to_cbo()
        {
            WinFormControls.load_data_to_cbo_tu_dien(WinFormControls.eLOAI_TU_DIEN.LOAI_QUYET_DINH,
              WinFormControls.eTAT_CA.NO,
              m_cbo_loai_quyet_dinh);
            WinFormControls.load_data_to_cbo_tu_dien(WinFormControls.eLOAI_TU_DIEN.LOAI_CHUC_VU,
                WinFormControls.eTAT_CA.NO,
                m_cbo_loai_chuc_vu);

            DS_DM_CHUC_VU v_ds_chuc_vu = new DS_DM_CHUC_VU();
            US_DM_CHUC_VU v_us_chuc_vu = new US_DM_CHUC_VU();
            v_us_chuc_vu.FillDataset(v_ds_chuc_vu);
            m_cbo_chuc_vu_moi.DataSource = v_ds_chuc_vu.DM_CHUC_VU;
            m_cbo_chuc_vu_moi.DisplayMember = DM_CHUC_VU.TEN_CV;
            m_cbo_chuc_vu_moi.ValueMember = DM_CHUC_VU.ID;

            m_cbo_ma_chuc_vu_moi.DataSource = v_ds_chuc_vu.DM_CHUC_VU;
            m_cbo_ma_chuc_vu_moi.DisplayMember = DM_CHUC_VU.MA_CV;
            m_cbo_ma_chuc_vu_moi.ValueMember = DM_CHUC_VU.ID;
        }
        private void us_object_to_form(string i_str_loai_cv)
        {
            m_txt_ma_nv.Text = m_us_v_qua_trinh_lam_viec.strMA_NV;
            m_txt_ho_ten.Text = m_us_v_qua_trinh_lam_viec.strHO_DEM + " " + m_us_v_qua_trinh_lam_viec.strTEN;

            m_txt_ma_nv.BackColor = SystemColors.Info;
            m_txt_ma_nv.ReadOnly = true;
            m_txt_ho_ten.BackColor = SystemColors.Info;
            m_txt_ho_ten.ReadOnly = true;
            


            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    if (i_str_loai_cv == "thang_chuc")
                    {
                        m_cbo_loai_chuc_vu.SelectedValue = 650;

                    }
                    else
                    {
                        if (i_str_loai_cv == "bo_nhiem")
                        {
                            m_cbo_loai_chuc_vu.SelectedValue = 651;
                        }
                    }
                    m_cbo_loai_chuc_vu.Enabled = false;
                    break;
                case DataEntryFormMode.UpdateDataState:
                    //m_us_dm_don_vi.dcID = m_us_v_qua_trinh_lam_viec.dcID_DON_VI;
                    
                    //m_txt_don_vi_moi.Text = m_us_dm_don_vi.strMA_DON_VI + " - " + m_us_dm_don_vi.strTEN_DON_VI;

                    m_dat_ngay_bat_dau.Value = m_us_v_qua_trinh_lam_viec.datNGAY_BAT_DAU;
                    //if (m_us_v_qua_trinh_lam_viec.datNGAY_KET_THUC > DateTime.Parse("01/01/1900"))
                    //    m_dat_ngay_ket_thuc.Value = m_us_v_qua_trinh_lam_viec.datNGAY_KET_THUC;
                    //else
                    //    m_dat_ngay_ket_thuc.Checked = false;
                    m_lbl_ngay_ket_thuc.Text = "Ngày miễn nhiệm";
                    m_lbl_chuc_vu_moi.Text = "Chức vụ miễn nhiệm";
                    m_cbo_chuc_vu_moi.Enabled = false;
                    m_cbo_ma_chuc_vu_moi.Enabled = false;
                    m_lbl_ma_chuc_vu_moi.Text = "Mã chức vụ miễn nhiệm";
                    m_lbl_don_vi_moi.Text = "Đơn vị hiện tại";
                    m_txt_don_vi_moi.Enabled = false;
                    m_cmd_chon_don_vi.Enabled = false;
                    m_cbo_loai_chuc_vu.Enabled = false;
                    m_dat_ngay_bat_dau.Enabled = false;
                    if (m_us_v_qua_trinh_lam_viec.dcID_QUYET_DINH != null)
                    {
                        m_us_quyet_dinh.FillDataset_By_Ma_qd(m_ds_quyet_dinh, m_us_v_qua_trinh_lam_viec.strMA_QUYET_DINH);
                        if (m_ds_quyet_dinh.DM_QUYET_DINH.Select("MA_QUYET_DINH is not null").Length > 0)
                        {
                            m_ofd_openfile.FileName = m_us_quyet_dinh.strLINK;
                            m_txt_ma_quyet_dinh.Text = m_us_v_qua_trinh_lam_viec.strMA_QUYET_DINH;
                            m_us_quyet_dinh.DataRow2Me((DataRow)m_ds_quyet_dinh.DM_QUYET_DINH.Rows[0]);
                            m_cbo_loai_quyet_dinh.SelectedValue = m_us_quyet_dinh.dcID_LOAI_QD;
                            m_dat_ngay_ky.Value = m_us_quyet_dinh.datNGAY_KY;
                            if (m_us_quyet_dinh.datNGAY_CO_HIEU_LUC > DateTime.Parse("01/01/1900"))
                                m_dat_ngay_co_hieu_luc_qd.Value = m_us_quyet_dinh.datNGAY_CO_HIEU_LUC;
                            else
                                m_dat_ngay_co_hieu_luc_qd.Checked = false;
                            //if (m_us_quyet_dinh.datNGAY_HET_HIEU_LUC > DateTime.Parse("01/01/1900"))
                            //    m_dat_ngay_het_hieu_luc_qd.Value = m_us_quyet_dinh.datNGAY_HET_HIEU_LUC;
                            //else
                            //    m_dat_ngay_het_hieu_luc_qd.Checked = false;
                            m_txt_noi_dung.Text = m_us_quyet_dinh.strNOI_DUNG;
                            m_ofd_openfile.FileName = m_us_quyet_dinh.strLINK;
                        }
                        else
                        {
                            m_txt_ma_quyet_dinh.Text = "";
                            m_cbo_loai_quyet_dinh.SelectedIndex = 0;
                            m_dat_ngay_ky.Checked = false;
                            m_dat_ngay_co_hieu_luc_qd.Checked = false;
                            //m_dat_ngay_het_hieu_luc_qd.Checked = false;
                            m_txt_noi_dung.Text = "";
                            m_ofd_openfile.FileName = "";
                        }
                    }
                    else
                    {
                        check_quyet_dinh_null = true;
                    }
                    break;
                default: break;
            }
        }
        private void form_to_us_object_chi_tiet_chuc_vu()
        {
            m_us_chi_tiet_chuc_vu = new US_GD_CHI_TIET_CHUC_VU();
           
            m_us_chi_tiet_chuc_vu.dcID_NHAN_SU = m_us_v_qua_trinh_lam_viec.dcID_NHAN_SU;
            m_us_chi_tiet_chuc_vu.dcID_CHUC_VU = CIPConvert.ToDecimal(m_cbo_chuc_vu_moi.SelectedValue);
            m_us_chi_tiet_chuc_vu.dcID_LOAI_CV = CIPConvert.ToDecimal(m_cbo_loai_chuc_vu.SelectedValue);
            m_us_chi_tiet_chuc_vu.dcID_DON_VI = m_us_dm_don_vi.dcID;
            if (m_txt_ma_quyet_dinh.Text != "")
                m_us_chi_tiet_chuc_vu.dcID_QUYET_DINH = m_us_quyet_dinh.dcID;
            m_us_chi_tiet_chuc_vu.datNGAY_BAT_DAU = m_dat_ngay_bat_dau.Value;
            if (m_dat_ngay_ket_thuc.Checked)
                m_us_chi_tiet_chuc_vu.datNGAY_KET_THUC = m_dat_ngay_ket_thuc.Value;
            //else
            //    m_us_chi_tiet_chuc_vu.datNGAY_KET_THUC = System.DBNull.Value;
            m_us_chi_tiet_chuc_vu.strTRANG_THAI_CV = "Y";
            switch (m_e_form_mode)
            {

                case DataEntryFormMode.UpdateDataState:
                    m_us_chi_tiet_chuc_vu.dcID = m_us_v_qua_trinh_lam_viec.dcID;
                    m_us_chi_tiet_chuc_vu.dcID_QUYET_DINH_MIEN_NHIEM = m_us_quyet_dinh.dcID;
                    m_us_chi_tiet_chuc_vu.strTRANG_THAI_CV = "N";
                    break;
                
                default:
                    break;
            }
        }
        private void form_to_us_object_quyet_dinh()
        {
            m_us_quyet_dinh.strMA_QUYET_DINH = m_txt_ma_quyet_dinh.Text;
            m_us_quyet_dinh.strNOI_DUNG = m_txt_noi_dung.Text;
            m_us_quyet_dinh.strLINK = m_ofd_openfile.FileName;
            m_us_quyet_dinh.dcID_LOAI_QD = CIPConvert.ToDecimal(m_cbo_loai_quyet_dinh.SelectedValue);
            m_us_quyet_dinh.datNGAY_KY = m_dat_ngay_ky.Value;
            m_us_quyet_dinh.datNGAY_CO_HIEU_LUC = m_dat_ngay_co_hieu_luc_qd.Value;
            if (m_dat_ngay_het_hieu_luc_qd.Checked)
                m_us_quyet_dinh.datNGAY_HET_HIEU_LUC = m_dat_ngay_het_hieu_luc_qd.Value;
            
        }
        
        private bool check_validate_data_is_ok()
        {
            
            return true;
        }
        private void save_data()
        {
            switch (m_e_form_mode)
            {

                case DataEntryFormMode.UpdateDataState:
                    if (check_validate_data_is_ok() == false)
                        return;
                    else
                    {
                        
                        form_to_us_object_quyet_dinh();
                        if (check_quyet_dinh_null)
                        {
                            m_us_quyet_dinh.Insert();
                        }
                        else
                        {
                            m_us_quyet_dinh.Update();
                        }
                        
                        form_to_us_object_chi_tiet_chuc_vu();
                        
                        m_us_chi_tiet_chuc_vu.Update();

                    }

                    break;
                case DataEntryFormMode.InsertDataState:

                    if (check_validate_data_is_ok() == false)
                        return;
                    else
                    {
                        if (m_txt_ma_quyet_dinh.Text != "")
                        {
                            form_to_us_object_quyet_dinh();
                            m_us_quyet_dinh.Insert();
                        }
                        form_to_us_object_chi_tiet_chuc_vu();
                        m_us_chi_tiet_chuc_vu.Insert();
                    }

                    break;
                default:
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhât!");
            this.Close();
        }
        private void xoa_trang()
        {
            m_cbo_chuc_vu_moi.SelectedIndex = 0;
            m_cbo_loai_quyet_dinh.SelectedIndex = 0;
            m_cbo_ma_chuc_vu_moi.SelectedIndex = 0;
            m_cbo_loai_chuc_vu.SelectedIndex = 0;
            m_txt_don_vi_moi.Text = "";
            m_txt_ma_quyet_dinh.Text = "";
            m_txt_noi_dung.Text = "";
            m_dat_ngay_bat_dau.Value = DateTime.Today;
            m_dat_ngay_co_hieu_luc_qd.Value = DateTime.Today;
            m_dat_ngay_het_hieu_luc_qd.Value = DateTime.Today;
            m_dat_ngay_ky.Value = DateTime.Today;
            m_dat_ngay_ket_thuc.Value = DateTime.Today;
            m_dat_ngay_ket_thuc.Checked = false;
            m_dat_ngay_het_hieu_luc_qd.Checked = false;
        }
        private void set_inital_form_load()
        {
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.UpdateDataState:
                    us_object_to_form("");
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                case DataEntryFormMode.InsertDataState:
                    break;
                default:
                    break;
            }
        }
        private void set_define_event()
        {

        }
#endregion

       
#region Event Hanlders
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                xoa_trang();
            }
            catch (Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f202_v_gd_qua_trinh_lam_viec_de_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_chon_don_vi_Click(object sender, EventArgs e)
        {
            try
            {
                f101_v_dm_don_vi v_frm = new f101_v_dm_don_vi();
                v_frm.select_data(ref m_us_dm_don_vi);
                m_txt_don_vi_moi.Text = m_us_dm_don_vi.strMA_DON_VI + " - " + m_us_dm_don_vi.strTEN_DON_VI;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                chon_file();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xem_file_Click(object sender, EventArgs e)
        {
            try
            {
                mo_file();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
#endregion

        

    }
}