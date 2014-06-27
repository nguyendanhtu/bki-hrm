﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_HRM.DS;
using BKI_HRM.DS.CDBNames;
using BKI_HRM.US;
using IP.Core.IPCommon;
using IP.Core.IPData;
using IP.Core.IPUserService;
using System.IO;
namespace BKI_HRM.DanhMuc
{
    public partial class F600_V_DM_QUYET_DINH_DE : Form
    {
        #region Public Interfaces
        public F600_V_DM_QUYET_DINH_DE()
        {
            InitializeComponent();
            /*Load Combobox Loai quyet dinh*/
            WinFormControls.load_data_to_cbo_tu_dien(WinFormControls.eLOAI_TU_DIEN.LOAI_QUYET_DINH,
                WinFormControls.eTAT_CA.NO,
                m_cbo_loai_quyet_dinh);
            
            m_cbo_loai_quyet_dinh.SelectedIndex = 0;
            format_control();
        }
        public void get_us(ref US_DM_QUYET_DINH op_us)
        {
            op_us = m_us;
        }
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_V_DM_QUYET_DINH ip_m_us_v_dm_quyet_dinh)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            
            us_object_2_form(ip_m_us_v_dm_quyet_dinh);
            this.ShowDialog();
        }
        #endregion
        #region Data Structures
        #endregion
        #region Members
        private DataEntryFormMode m_e_form_mode;
        private US_V_DM_QUYET_DINH m_v_us = new US_V_DM_QUYET_DINH();
        private DS_V_DM_QUYET_DINH m_v_ds = new DS_V_DM_QUYET_DINH();
        private US_DM_QUYET_DINH m_us = new US_DM_QUYET_DINH();
        private DS_DM_QUYET_DINH m_ds = new DS_DM_QUYET_DINH();
        private string m_str_to = ConfigurationSettings.AppSettings["DESTINATION_NAME"];
        private string m_str_username_share = ConfigurationSettings.AppSettings["USERNAME_SHARE"];
        private string m_str_password_share = ConfigurationSettings.AppSettings["PASSWORD_SHARE"];
        private string m_str_domain = ConfigurationSettings.AppSettings["DOMAIN"];
        private string m_str_destination = ConfigurationSettings.AppSettings["DESTINATION_NAME"];
        private string m_str_path = "";
        private string m_str_file_name = "";
        private string m_str_from = "";
        private string m_str_time_now = DateTime.Now.Ticks.ToString();
        private string m_str_file_name_old = "";
        private bool m_b_status = false;
        private string m_str_origination = "";
        private string m_str_old_path = "";
        #endregion
        #region Private Methods

        private bool check_trung_ma_quyet_dinh(string ip_str_ma_quyet_dinh)
        {
            DS_V_DM_QUYET_DINH v_ds = new DS_V_DM_QUYET_DINH();
            decimal count_ma_quyet_dinh;
            m_v_us.FillDataset_By_Ma_qd(v_ds, ip_str_ma_quyet_dinh);
            count_ma_quyet_dinh = v_ds.V_DM_QUYET_DINH.Count;
            if (count_ma_quyet_dinh > 0)
                return true;
            return false;
        }
        private void us_object_2_form(US_V_DM_QUYET_DINH ip_us_v_dm_quyet_dinh)
        {
            m_us.dcID = ip_us_v_dm_quyet_dinh.dcID;

            //m_txt_link.Text = ip_us_v_dm_quyet_dinh.strLINK;
            string[] v_arstr = ip_us_v_dm_quyet_dinh.strMA_QUYET_DINH.Trim().Split('/');
            m_txt_ma_quyet_dinh.Text = v_arstr[0];
            BKI_HRM.US.US_CM_DM_TU_DIEN v_us = new BKI_HRM.US.US_CM_DM_TU_DIEN();
            BKI_HRM.DS.DS_CM_DM_TU_DIEN v_ds = new BKI_HRM.DS.DS_CM_DM_TU_DIEN();
            decimal v_dc_id = 0;
            v_us.FillDatasetByName(v_ds, v_arstr[v_arstr.Length - 1], ref v_dc_id);
            m_cbo_ma_quyet_dinh.SelectedValue = v_dc_id;
            m_txt_noi_dung.Text = ip_us_v_dm_quyet_dinh.strNOI_DUNG;
            if (ip_us_v_dm_quyet_dinh.datNGAY_HET_HIEU_LUC.Year > 1900)
                m_dat_ngay_het_hieu_luc.Value = ip_us_v_dm_quyet_dinh.datNGAY_HET_HIEU_LUC;
            else
                m_dat_ngay_het_hieu_luc.Checked = false;
            if (ip_us_v_dm_quyet_dinh.datNGAY_CO_HIEU_LUC.Year > 1900)
                m_dat_ngay_co_hieu_luc.Value = ip_us_v_dm_quyet_dinh.datNGAY_CO_HIEU_LUC;
            else
                m_dat_ngay_co_hieu_luc.Checked = false;
            if (ip_us_v_dm_quyet_dinh.datNGAY_KY.Year > 1900)
                m_dat_ngay_ky.Value = ip_us_v_dm_quyet_dinh.datNGAY_KY;
            else
                m_dat_ngay_ky.Checked = false;
            
            m_cbo_loai_quyet_dinh.SelectedValue = ip_us_v_dm_quyet_dinh.dcID_LOAI_QD;
            m_str_file_name_old = ip_us_v_dm_quyet_dinh.strLINK;
            if (ip_us_v_dm_quyet_dinh.strLINK == "") return;
            string[] v_strs = ip_us_v_dm_quyet_dinh.strLINK.Split('\\');
           
        }
        private void generate_ma_quyet_dinh()
        {
            m_lbl_ma_qd.Text = string.Format("{0}/{1}/{2}", m_txt_ma_quyet_dinh.Text,
                                                                  m_dat_ngay_ky.Value.Year,
                                                                  m_cbo_ma_quyet_dinh.Text);
        }
        private void open_file()
        {
            Process.Start("explorer.exe", m_ofd_chon_file.FileName);
        }
        private void chon_file()
        {
            m_ofd_chon_file.Filter = "(*.*)|*.*";
            m_ofd_chon_file.Multiselect = false;
            m_ofd_chon_file.Title = "Chọn tài liệu đính kèm";
            m_ofd_chon_file.FileName = "";
            DialogResult result = m_ofd_chon_file.ShowDialog();
            if (result != DialogResult.OK) return;

            if (new FileInfo(m_ofd_chon_file.FileName).Length > 5096000)
            {
                BaseMessages.MsgBox_Infor("File đính kèm quá lớn. \nVui lòng chọn file có dung lượng < 5Mb");
                return;
            }
            m_str_file_name = m_ofd_chon_file.SafeFileName;
            m_lbl_file_name.Text = m_str_file_name;
            m_str_from = m_ofd_chon_file.FileName;
            var v_i_index = m_str_from.Trim().LastIndexOf("\\");
            m_str_path = m_str_from.Trim().Substring(0, v_i_index + 1);
        }
        private bool existed_file(string ip_str_path)
        {
            if (File.Exists(ip_str_path))
                return true;
            return false;
        }

        private void upload_file()
        {
            if (m_str_file_name == "")
            {
                m_us.strLINK = "";
                return;
            }
            modify_name_file(m_str_from, m_str_path + m_str_time_now + "-" + m_str_file_name);

            var oNetworkCredential =
                    new System.Net.NetworkCredential()
                    {
                        Domain = m_str_domain,
                        UserName = m_str_domain + "\\" + m_str_username_share,
                        Password = m_str_password_share
                    };

            using (new RemoteAccessHelper.NetworkConnection(@"\\" + m_str_domain, oNetworkCredential))
            {
                File.Move(m_str_path + m_str_time_now + "-" + m_str_file_name,
                            m_str_to + m_str_time_now + "-" + m_str_file_name);
            }

            m_us.strLINK = m_str_time_now + "-" + m_str_file_name;
            m_b_status = true;
        }

        private void modify_name_file(string ip_str_source_file_name, string ip_str_desination_file_name)
        {
            //Coppy file mới
            File.Copy(ip_str_source_file_name, m_str_path + "topica" + m_str_file_name);
            //Đổi tên file mới
            File.Move(m_str_path + "topica" + m_str_file_name, ip_str_desination_file_name);
        }

        private void delete_file(string ip_str_path)
        {
            if (existed_file(m_str_from))
            {
                File.Delete(ip_str_path);
                return;
            }
            BaseMessages.MsgBox_Infor("File không tồn tại.");
        }
        private bool check_data_is_ok()
        {
            //if (check_trung_ma_quyet_dinh(m_txt_ma_quyet_dinh.Text.Trim()))
            //{
            //    BaseMessages.MsgBox_Error("Đã có mã Quyết định này!");
            //    return false;
            //}
            //return CValidateTextBox.IsValid(m_txt_ma_quyet_dinh, DataType.StringType, allowNull.NO, true) && kiem_tra_ngay_truoc_sau();

            if (!CValidateTextBox.IsValid(m_txt_ma_quyet_dinh, DataType.StringType, allowNull.NO, true))
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập mã quyết định");
                return false;
            }
            

         

            return  kiem_tra_ngay_truoc_sau(); 
        }
        private bool kiem_tra_ngay_truoc_sau()
        {
            if (m_dat_ngay_co_hieu_luc.Value.Date >= m_dat_ngay_het_hieu_luc.Value.Date 
                && m_dat_ngay_co_hieu_luc.Checked == true && m_dat_ngay_het_hieu_luc.Checked == true
                )
            {
               BaseMessages.MsgBox_Error("Ngày có hiệu lực phải trước ngày hết hiệu lực!");
                return false;
            }
            return true;
        }
        private void form_2_us_object()
        {
            m_us.strMA_QUYET_DINH = m_lbl_ma_qd.Text.Trim();
            //m_us.strLINK = m_txt_link.Text.Trim();
            m_us.strNOI_DUNG = m_txt_noi_dung.Text.Trim();
            m_us.datNGAY_CO_HIEU_LUC = m_dat_ngay_co_hieu_luc.Value.Date;
           
            if (m_dat_ngay_het_hieu_luc.Checked)
            {
                m_us.datNGAY_HET_HIEU_LUC = m_dat_ngay_het_hieu_luc.Value.Date;
            }
            else
            {
                m_us.SetNGAY_HET_HIEU_LUCNull();
            }
           m_us.datNGAY_KY = m_dat_ngay_ky.Value.Date;
            m_us.dcID_LOAI_QD = CIPConvert.ToDecimal(m_cbo_loai_quyet_dinh.SelectedValue.ToString());
            m_us.strLINK = m_str_time_now + "-" + m_str_file_name;

        }
        private void save_data()
        {
            if (existed_file(m_str_to + m_str_time_now + "-" + m_str_file_name))
            {
                BaseMessages.MsgBox_Infor("Tên file đã tồn tại, vui lòng đổi tên khác.");
                return;
            }
            upload_file();
            switch (m_e_form_mode)
            {

                case DataEntryFormMode.UpdateDataState:
                    if (check_data_is_ok() == false)
                    
                        return;
                   
                    else
                    {
                        form_2_us_object();
                        if (m_b_status == true && m_str_file_name_old != "")
                            delete_file(m_str_to + m_str_file_name_old);
                        m_us.Update();
                    }
                    
                    break;
                case DataEntryFormMode.InsertDataState:
                    if (check_trung_ma_quyet_dinh(m_txt_ma_quyet_dinh.Text))
                    {
                        BaseMessages.MsgBox_Warning(216);
                        m_txt_ma_quyet_dinh.BackColor = Color.Bisque;
                        m_txt_ma_quyet_dinh.Focus();
                        m_txt_ma_quyet_dinh.SelectAll();
                        return;
                    }
                    else
                    {
                        m_txt_ma_quyet_dinh.BackColor = Color.White;
                        if (check_data_is_ok() == false)
                            return;
                        else
                        {
                            form_2_us_object();
                            m_us.Insert();
                        }

                    }

                    break;
                default: break;
            }
            BaseMessages.MsgBox_Infor("Cập nhật dữ liệu thành công!");
            this.Close();
        }
        private void load_cbo_ma_quyet_dinh()
        {
            WinFormControls.load_data_to_cbo_tu_dien(WinFormControls.eLOAI_TU_DIEN.MA_QUYET_DINH
                , WinFormControls.eTAT_CA.NO
                , m_cbo_ma_quyet_dinh);
        }
        private void format_control()
        {
            CControlFormat.setFormStyle(this);
            load_cbo_ma_quyet_dinh();
            set_define_events();
        }

        #endregion
        #region Events
        protected void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            //m_txt_link.Text = "";
            m_txt_ma_quyet_dinh.Text = "";
            m_txt_noi_dung.Text = "";
            m_dat_ngay_co_hieu_luc.Value = DateTime.Today;
            m_dat_ngay_het_hieu_luc.Value = DateTime.Today;
            m_dat_ngay_ky.Value = DateTime.Today;
            m_cbo_loai_quyet_dinh.SelectedIndex = 0;
        }
        private void set_define_events()
        {
            this.m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            this.m_cmd_refresh.Click += new EventHandler(m_cmd_refresh_Click);
            this.m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
        }
        
        
        

        
        protected void m_cmd_save_Click(object sender, EventArgs e)
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
        protected void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        


        internal void display(US_V_DM_QUYET_DINH m_us)
        {
            throw new NotImplementedException();
        }

        private void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_data_is_ok() == false) return;
                chon_file();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_xem_Click(object sender, EventArgs e)
        {
            try
            {
                open_file();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        


        #endregion

        private void generate_ma_quyet_dinh_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                generate_ma_quyet_dinh();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

     




    }
}
