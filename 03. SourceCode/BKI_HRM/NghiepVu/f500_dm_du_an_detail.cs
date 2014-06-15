﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using BKI_HRM.DS;
using BKI_HRM.US;
using IP.Core.IPCommon;
//using BKI_HRM.US;
//using BKI_HRM.DS;
using IP.Core.IPData;
using IP.Core.IPUserService;
using BKI_HRM.DS.CDBNames;
using System.Collections;
using IP.Core.IPSystemAdmin;

namespace BKI_HRM.NghiepVu
{
    public partial class f500_dm_du_an_detail : Form
    {
        #region publicInterface

        public f500_dm_du_an_detail()
        {
            InitializeComponent();
            format_control();
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_DM_DU_AN ip_us_dm_du_an)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_2_form_du_an(ip_us_dm_du_an);
            us_to_form_quyet_dinh(ip_us_dm_du_an);
            m_dc_id_du_an_old = ip_us_dm_du_an.dcID;
            this.ShowDialog();
        }

        #endregion

        #region Member
        decimal m_dc_id_du_an;
        int m_dc_index_row;
        private decimal m_dc_id_du_an_old;
        ITransferDataRow m_obj_trans;
        DataEntryFormMode m_e_form_mode;
        US_DM_DU_AN m_us_dm_du_an = new US.US_DM_DU_AN();
        US_DM_QUYET_DINH m_us_quyet_dinh = new US.US_DM_QUYET_DINH();
        DS_V_DM_NHAN_SU_DU_AN m_ds_nsda = new DS.DS_V_DM_NHAN_SU_DU_AN();

        bool m_b_check_quyet_dinh_save;
        bool m_b_check_quyet_dinh_null = false;
        private string m_str_ma_qd = "";

        private string m_str_to = ConfigurationSettings.AppSettings["DESTINATION_NAME"];
        private string m_str_username_share = ConfigurationSettings.AppSettings["USERNAME_SHARE"];
        private string m_str_password_share = ConfigurationSettings.AppSettings["PASSWORD_SHARE"];
        private string m_str_domain = ConfigurationSettings.AppSettings["DOMAIN"];
        private string m_str_from = "";
        private string m_str_file_name = "";
        private string m_str_path = "";
        private string m_str_time_now = DateTime.Now.Ticks.ToString();
        private string m_str_file_name_old = "";
        private bool m_b_status = false;

        enum cm_dm_tu_dien
        {
            TRANG_THAI = 10,
            LOAI_DU_AN = 9,
            CO_CHE = 8,
            THANH_LAP_DU_AN = 679
        }
        private enum e_col_Number
        {
            MA_DU_AN = 1
                ,
            TEN_DU_AN = 2
                ,
            MA_NV = 4
                ,
            HO_DEM = 5
                ,
            TEN = 6
                ,
            MA_CV = 7
                ,
            TEN_CV = 8
                ,
            MA_DON_VI = 9
                ,
            TEN_DON_VI = 10
                ,
            VI_TRI = 11
                ,
            THOI_DIEM_TG = 12
                ,
            THOI_DIEM_KT = 13
                ,
            THOI_GIAN_TG = 14
                ,
            DANH_HIEU = 15
                ,
            MO_TA = 18
                ,
            TRANG_THAI_CV = 19
        }
        #endregion

        #region privateMethod
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_NHAN_SU_DU_AN.VI_TRI, e_col_Number.VI_TRI);

            v_htb.Add(V_DM_NHAN_SU_DU_AN.MA_NV, e_col_Number.MA_NV);

            v_htb.Add(V_DM_NHAN_SU_DU_AN.MA_DU_AN, e_col_Number.MA_DU_AN);

            v_htb.Add(V_DM_NHAN_SU_DU_AN.DANH_HIEU, e_col_Number.DANH_HIEU);

            v_htb.Add(V_DM_NHAN_SU_DU_AN.MO_TA, e_col_Number.MO_TA);

            v_htb.Add(V_DM_NHAN_SU_DU_AN.THOI_DIEM_KT, e_col_Number.THOI_DIEM_KT);

            v_htb.Add(V_DM_NHAN_SU_DU_AN.TEN, e_col_Number.TEN);

            v_htb.Add(V_DM_NHAN_SU_DU_AN.THOI_DIEM_TG, e_col_Number.THOI_DIEM_TG);

            v_htb.Add(V_DM_NHAN_SU_DU_AN.HO_DEM, e_col_Number.HO_DEM);

            v_htb.Add(V_DM_NHAN_SU_DU_AN.TEN_DU_AN, e_col_Number.TEN_DU_AN);

            v_htb.Add(V_DM_NHAN_SU_DU_AN.THOI_GIAN_TG, e_col_Number.THOI_GIAN_TG);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_nsda.V_DM_NHAN_SU_DU_AN.NewRow());
            return v_obj_trans;
        }

        public void form_2_us_du_an()
        {
            m_us_dm_du_an.strMA_DU_AN = m_txt_ma_du_an.Text;
            m_us_dm_du_an.dcID_LOAI_DU_AN = CIPConvert.ToDecimal(m_cbo_loai_du_an.SelectedValue);
            m_us_dm_du_an.strTEN_DU_AN = m_txt_ten_du_an.Text;

            m_us_dm_du_an.datNGAY_BAT_DAU = m_dat_ngay_bd.Value;
            if (m_dat_ngay_kt.Checked)
                m_us_dm_du_an.datNGAY_KET_THUC = m_dat_ngay_kt.Value;
            else
                m_us_dm_du_an.SetNGAY_KET_THUCNull();

            m_us_dm_du_an.dcID_CO_CHE = CIPConvert.ToDecimal(m_cbo_co_che.SelectedValue);

            m_us_dm_du_an.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);

            if (m_us_quyet_dinh.dcID == 0 || m_us_quyet_dinh.dcID == -1)
                m_us_dm_du_an.SetID_QUYET_DINHNull();
            else
                m_us_dm_du_an.dcID_QUYET_DINH = m_us_quyet_dinh.dcID;

            m_us_dm_du_an.strNOI_DUNG = m_txt_noi_dung_du_an.Text;
        }

        private void form_to_us_object_quyet_dinh()
        {
            m_us_quyet_dinh.strMA_QUYET_DINH = m_txt_ma_quyet_dinh.Text.Trim();
            m_us_quyet_dinh.strNOI_DUNG = m_txt_noi_dung_quyet_dinh.Text.Trim();
            m_us_quyet_dinh.dcID_LOAI_QD = CIPConvert.ToDecimal(TU_DIEN.QD_THANH_LAP_DU_AN);
            m_us_quyet_dinh.datNGAY_KY = m_dat_ngay_ky.Value;
            m_us_quyet_dinh.datNGAY_CO_HIEU_LUC = m_dat_ngay_co_hieu_luc_qd.Value;
            if (m_dat_ngay_het_hieu_luc_qd.Checked)
                m_us_quyet_dinh.datNGAY_HET_HIEU_LUC = m_dat_ngay_het_hieu_luc_qd.Value;
            else
                m_us_quyet_dinh.SetNGAY_HET_HIEU_LUCNull();
            m_str_ma_qd = m_txt_ma_quyet_dinh.Text.Trim();
        }

        private void us_2_form_du_an(US_DM_DU_AN op_us_dm_du_an)
        {
            m_us_dm_du_an = op_us_dm_du_an;

            m_txt_ma_du_an.Text = op_us_dm_du_an.strMA_DU_AN;
            m_cbo_loai_du_an.SelectedValue = op_us_dm_du_an.dcID_LOAI_DU_AN;
            m_txt_ten_du_an.Text = op_us_dm_du_an.strTEN_DU_AN;

            if (op_us_dm_du_an.datNGAY_BAT_DAU != null)
                m_dat_ngay_bd.Value = op_us_dm_du_an.datNGAY_BAT_DAU;

            if (op_us_dm_du_an.datNGAY_KET_THUC != null)
                m_dat_ngay_kt.Value = op_us_dm_du_an.datNGAY_KET_THUC;

            m_cbo_co_che.SelectedValue = op_us_dm_du_an.dcID_CO_CHE;
            m_cbo_trang_thai.SelectedValue = op_us_dm_du_an.dcID_TRANG_THAI;
            m_txt_noi_dung_du_an.Text = op_us_dm_du_an.strNOI_DUNG;
        }

        private void us_to_form_quyet_dinh(US_DM_DU_AN op_us_dm_du_an)
        {
            if (op_us_dm_du_an.dcID_QUYET_DINH != 0)
            {
                m_grb_quyet_dinh.Enabled = true;

                US_DM_QUYET_DINH v_us_dm_qd = new US_DM_QUYET_DINH(op_us_dm_du_an.dcID_QUYET_DINH);
                m_us_quyet_dinh.dcID = v_us_dm_qd.dcID;
                m_txt_ma_quyet_dinh.Text = v_us_dm_qd.strMA_QUYET_DINH;
                m_dat_ngay_ky.Value = v_us_dm_qd.datNGAY_KY;
                m_dat_ngay_co_hieu_luc_qd.Value = v_us_dm_qd.datNGAY_CO_HIEU_LUC;

                if (v_us_dm_qd.datNGAY_HET_HIEU_LUC != null)
                {
                    m_dat_ngay_het_hieu_luc_qd.Checked = true;
                    m_dat_ngay_het_hieu_luc_qd.Value = v_us_dm_qd.datNGAY_HET_HIEU_LUC;
                }

                m_txt_noi_dung_quyet_dinh.Text = v_us_dm_qd.strNOI_DUNG;
                m_lbl_file_name.Text = v_us_dm_qd.strLINK;
            }
        }

        private void chon_quyet_dinh()
        {
            m_b_check_quyet_dinh_save = false;
            m_grb_quyet_dinh.Enabled = true;
            f600_v_dm_quyet_dinh v_frm = new f600_v_dm_quyet_dinh();
            v_frm.select_data(ref m_us_quyet_dinh);
            if (m_us_quyet_dinh.dcID != -1)
            {
                m_txt_ma_quyet_dinh.Text = m_us_quyet_dinh.strMA_QUYET_DINH;

                m_lbl_loai_qd.Text = new US.US_CM_DM_TU_DIEN(CIPConvert.ToDecimal(TU_DIEN.QD_THANH_LAP_DU_AN)).strTEN;

                m_dat_ngay_ky.Value = m_us_quyet_dinh.datNGAY_KY;
                if (m_us_quyet_dinh.datNGAY_CO_HIEU_LUC > DateTime.Parse("01/01/1900") &&
                    m_us_quyet_dinh.datNGAY_CO_HIEU_LUC != null)
                    m_dat_ngay_co_hieu_luc_qd.Value = m_us_quyet_dinh.datNGAY_CO_HIEU_LUC;
                else
                    m_dat_ngay_co_hieu_luc_qd.Checked = false;
                if (m_us_quyet_dinh.datNGAY_HET_HIEU_LUC != null &&
                    m_us_quyet_dinh.datNGAY_HET_HIEU_LUC > DateTime.Parse("1/1/1900"))
                    m_dat_ngay_het_hieu_luc_qd.Value = m_us_quyet_dinh.datNGAY_HET_HIEU_LUC;
                else
                    m_dat_ngay_het_hieu_luc_qd.Checked = false;
                m_txt_noi_dung_quyet_dinh.Text = m_us_quyet_dinh.strNOI_DUNG;

                m_lbl_file_name.Text = m_us_quyet_dinh.strLINK;
            }
            else
            {
                m_b_check_quyet_dinh_null = true;
            }
        }

        private void them_quyet_dinh()
        {
            m_b_check_quyet_dinh_save = true;
            m_grb_quyet_dinh.Enabled = true;
            m_lbl_loai_qd.Text = new US.US_CM_DM_TU_DIEN(CIPConvert.ToDecimal(TU_DIEN.QD_THANH_LAP_DU_AN)).strTEN;
            m_b_check_quyet_dinh_null = true;
            m_txt_ma_quyet_dinh.Focus();
        }
            
        private bool check_data_is_ok()
        {
            if (!m_dat_ngay_bd.Checked)
            {
                BaseMessages.MsgBox_Infor("Phải có ngày bắt đầu dự án");
                return false;
            }
            if (m_dat_ngay_kt.Checked)
            {
                if (m_dat_ngay_bd.Value.Date > m_dat_ngay_kt.Value.Date)
                {
                    BaseMessages.MsgBox_Infor("Ngày bắt đầu dự án phải trước ngày kết thúc dự án");
                    return false;
                }
            }
            if (m_txt_ma_du_an.Text.Trim().Length == 0)
            {
                BaseMessages.MsgBox_Infor("Phải có mã dự án");
                return false;
            }
            if (m_txt_ten_du_an.Text.Trim().Length == 0)
            {
                BaseMessages.MsgBox_Infor("Phải có tên dự án");
                return false;
            }
            return true;
        }

        private bool check_trung_ma_du_an(string ip_str_ma_du_an)
        {

            DS_DM_DU_AN v_ds = new DS_DM_DU_AN();
            US_DM_DU_AN v_us = new US_DM_DU_AN();
            v_us.FillDataset_search_by_ma_da(v_ds, ip_str_ma_du_an);
            if (v_ds.DM_DU_AN.Count > 0)
                return true;
            return false;
        }

        private void chon_file()
        {
            m_ofd_chon_file.Filter = "(*.*)|*.*";
            m_ofd_chon_file.Multiselect = false;
            m_ofd_chon_file.Title = "Chọn file";
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
                m_us_quyet_dinh.strLINK = "";
                return;
            }
            modify_name_file(m_str_from, m_str_path + m_str_time_now + "-" + m_str_file_name);

            var oNetworkCredential =
                    new NetworkCredential()
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

            m_us_quyet_dinh.strLINK = m_str_time_now + "-" + m_str_file_name;
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

        private void save_data()
        {
            if (check_data_is_ok() == false)
                return;

            form_2_us_du_an();

            // Xử lý file đính kèm
            if (existed_file(m_str_to + m_str_time_now + "-" + m_str_file_name))
            {
                BaseMessages.MsgBox_Infor("Tên file đã tồn tại, vui lòng đổi tên khác.");
                return;
            }
            upload_file();

            US_DM_QUYET_DINH v_us_qd = new US_DM_QUYET_DINH();
            DS_DM_QUYET_DINH v_ds_qd = new DS_DM_QUYET_DINH();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    // Kiểm tra dự án đã tồn tại hay chưa
                    if (check_trung_ma_du_an(m_txt_ma_du_an.Text))
                    {
                        BaseMessages.MsgBox_Error("Mã dự án đã tồn tại.");
                        m_txt_ma_du_an.Focus();
                        return;
                    }


                    // Kiểm tra Quyết Định đã được dùng cho Dự Án nào chưa
                    US_DM_DU_AN v_us_dm_da = new US_DM_DU_AN();
                    DS_DM_DU_AN v_ds_dm_da = new DS_DM_DU_AN();
                    v_us_dm_da.FillDatasetByIDQuyetDinh(v_ds_dm_da, m_us_dm_du_an.dcID_QUYET_DINH);
                    if (v_ds_dm_da.DM_DU_AN.Rows.Count > 0)
                    {
                        BaseMessages.MsgBox_Infor("Quyết định này đã được sử dụng cho dự án khác.");
                        return;
                    }

                    if (m_b_check_quyet_dinh_save)
                    {
                        form_to_us_object_quyet_dinh();
                        if (m_b_check_quyet_dinh_null)
                            m_us_quyet_dinh.Insert();
                        else
                            m_us_quyet_dinh.Update();

                        v_us_qd.FillDataset_By_Ma_qd(v_ds_qd, m_us_quyet_dinh.strMA_QUYET_DINH);
                        if (v_ds_qd.Tables[0].Rows.Count != 0)
                            m_us_dm_du_an.dcID_QUYET_DINH = CIPConvert.ToDecimal(v_ds_qd.Tables[0].Rows[0]["ID"]);
                    }

                    m_us_dm_du_an.Insert();
                    m_dc_id_du_an = m_us_dm_du_an.dcID;
                    break;
                case DataEntryFormMode.UpdateDataState:
                    // Kiểm tra mã dự án
                    US_DM_DU_AN v_us_dm_du_an = new US_DM_DU_AN(m_dc_id_du_an_old);
                    if (!m_txt_ma_du_an.Text.Equals(v_us_dm_du_an.strMA_DU_AN))
                    {
                        if (check_trung_ma_du_an(m_txt_ma_du_an.Text))
                        {
                            BaseMessages.MsgBox_Error("Mã dự án đã tồn tại.");
                            m_txt_ma_du_an.Focus();
                            return;
                        }
                    }


                    // Kiểm tra quyết định
                    if (m_txt_ma_quyet_dinh.Text != "")
                    {
                        form_to_us_object_quyet_dinh();
                        if (m_b_check_quyet_dinh_save)
                            m_us_quyet_dinh.Insert();
                        else
                            m_us_quyet_dinh.Update();

                        v_us_qd.FillDataset_By_Ma_qd(v_ds_qd, m_us_quyet_dinh.strMA_QUYET_DINH);
                        if (v_ds_qd.Tables[0].Rows.Count != 0)
                            m_us_dm_du_an.dcID_QUYET_DINH = CIPConvert.ToDecimal(v_ds_qd.Tables[0].Rows[0]["ID"]);
                    }

                    if (m_b_status == true && m_str_file_name_old != "")
                        delete_file(m_str_to + m_str_file_name_old);
                    m_us_quyet_dinh.Update();

                    m_us_dm_du_an.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }

        #endregion

        #region eventHandle
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

        private void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                m_txt_ma_du_an.Text = "";
                m_txt_ma_quyet_dinh.Text = "";
                m_txt_noi_dung_du_an.Text = "";
                m_txt_ten_du_an.Text = "";
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f500_dm_du_an_detail_Load(object sender, EventArgs e)
        {
            WinFormControls.load_data_to_cbo_tu_dien(WinFormControls.eLOAI_TU_DIEN.CO_CHE, WinFormControls.eTAT_CA.NO, m_cbo_co_che);
            WinFormControls.load_data_to_cbo_tu_dien(WinFormControls.eLOAI_TU_DIEN.TRANG_THAI_DU_AN, WinFormControls.eTAT_CA.NO, m_cbo_trang_thai);
            WinFormControls.load_data_to_cbo_tu_dien(WinFormControls.eLOAI_TU_DIEN.LOAI_DU_AN, WinFormControls.eTAT_CA.NO, m_cbo_loai_du_an);
        }

        private void m_cmd_them_quyet_dinh_Click(object sender, EventArgs e)
        {
            try
            {
                them_quyet_dinh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_chon_quyet_dinh_Click(object sender, EventArgs e)
        {
            try
            {
                chon_quyet_dinh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

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

        private void m_cmd_xem_file_Click(object sender, EventArgs e)
        {

        }

        private void m_cmd_go_dinh_kem_Click(object sender, EventArgs e)
        {
            try
            {
                delete_file(m_us_quyet_dinh.strLINK);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
