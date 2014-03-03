﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
//using BKI_HRM.US;
//using BKI_HRM.DS;
using IP.Core.IPData;
using IP.Core.IPUserService;
using BKI_HRM.DS.CDBNames;

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

        
        #endregion

        #region Member
        DataEntryFormMode m_e_form_mode;
        US.US_DM_DU_AN m_us_dm_du_an = new US.US_DM_DU_AN();
        US.US_DM_QUYET_DINH m_us_dm_quyet_dinh = new US.US_DM_QUYET_DINH();
        enum cm_dm_tu_dien { 
            TRANG_THAI = 10,
            LOAI_DU_AN = 9,
            CO_CHE =8,
            THANH_LAP_DU_AN = 679
        }
        #endregion

        #region privateMethod
        private void format_control()
        {
            CControlFormat.setFormStyle(this);
        }
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            load_data_2_control();
            this.ShowDialog();
        }

        public void display_for_update(DS.DS_DM_DU_AN i_ds)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            load_data_2_control();
            ds_2_form(i_ds);
            load_data_2_form_chi_tiet_qd(m_txt_ma_quyet_dinh.Text);
            this.ShowDialog();            
        }

        private void load_data_2_form_chi_tiet_qd(string i_str_ma_qd)
        {
            DS.DS_DM_QUYET_DINH v_ds_dm_qd = new DS.DS_DM_QUYET_DINH();
            m_us_dm_quyet_dinh.FillDatasetByMaQuyetDinh(v_ds_dm_qd, i_str_ma_qd);
            DataRow v_dr = v_ds_dm_qd.Tables[0].Rows[0];
            m_txt_link.Text = v_dr["LINK"].ToString();
            m_txt_noi_dung_quyet_dinh.Text = v_dr["NOI_DUNG"].ToString();

            if (v_dr["NGAY_KY"].ToString() != "")
            {
                m_dat_ngay_ki.Value = (DateTime)v_dr["NGAY_KY"];
            }
            else
            {
                m_dat_ngay_ki.Checked = false;
            }

            if (v_dr["NGAY_HET_HIEU_LUC"].ToString() != "")
            {
                m_dat_ngay_het_hieu_luc.Value = (DateTime)v_dr["NGAY_HET_HIEU_LUC"];
            }
            else
            {
                m_dat_ngay_het_hieu_luc.Checked = false;
            }
            if (v_dr["NGAY_CO_HIEU_LUC"].ToString() != "")
            {
                m_dat_ngay_co_hieu_luc.Value = (DateTime)v_dr["NGAY_CO_HIEU_LUC"];
            }
            else
            {
                m_dat_ngay_co_hieu_luc.Checked = false;
            }
            
            m_us_dm_quyet_dinh.dcID = CIPConvert.ToDecimal(v_dr["ID"].ToString());
        }

        private void ds_2_form(DS.DS_DM_DU_AN i_ds)
        {
            DataRow dr = i_ds.Tables[0].Rows[0];
            m_us_dm_du_an.dcID = CIPConvert.ToDecimal(dr["ID"].ToString());
            m_txt_ma_du_an.Text = dr["MA_DU_AN"].ToString();
            //m_txt_ma_quyet_dinh.Text = dr["TEN_DU_AN"].ToString();
            m_txt_noi_dung.Text = dr["NOI_DUNG"].ToString();
            m_txt_ten_du_an.Text = dr["TEN_DU_AN"].ToString();

            m_cbo_co_che.SelectedValue = CIPConvert.ToDecimal(dr["ID_CO_CHE"].ToString());
            m_cbo_loai_du_an.SelectedValue = CIPConvert.ToDecimal(dr["ID_LOAI_DU_AN"].ToString());
            m_cbo_trang_thai.SelectedValue = CIPConvert.ToDecimal(dr["ID_TRANG_THAI"].ToString());

            m_dat_ngay_bd.Value = (DateTime)dr["NGAY_BAT_DAU"];
            m_dat_ngay_kt.Value = (DateTime)dr["NGAY_KET_THUC"];

            US.US_DM_QUYET_DINH v_us_qd = new US.US_DM_QUYET_DINH();
            DS.DS_DM_QUYET_DINH v_ds_qd = new DS.DS_DM_QUYET_DINH();
            v_us_qd.FillDatasetByIdQD(v_ds_qd, CIPConvert.ToDecimal(dr["ID_QUYET_DINH"].ToString()));
            dr = v_ds_qd.Tables[0].Rows[0];
            m_txt_ma_quyet_dinh.Text = dr["MA_QUYET_DINH"].ToString();
            
        }

        public void load_data_2_cbo_trang_thai()
        {
            DS_CM_DM_TU_DIEN v_ds_cm_dm_td = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us_cm_dm_td = new US_CM_DM_TU_DIEN();
            v_us_cm_dm_td.FillDatasetByIdLoaiTuDien(v_ds_cm_dm_td, (int)cm_dm_tu_dien.TRANG_THAI);
            m_cbo_trang_thai.DataSource = v_ds_cm_dm_td.Tables[0];
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
        }
        
        public void load_data_2_cbo_co_che() 
        {
            DS_CM_DM_TU_DIEN v_ds_cm_dm_td = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us_cm_dm_td = new US_CM_DM_TU_DIEN();
            v_us_cm_dm_td.FillDatasetByIdLoaiTuDien(v_ds_cm_dm_td, (int)cm_dm_tu_dien.CO_CHE);
            m_cbo_co_che.DataSource = v_ds_cm_dm_td.Tables[0];
            m_cbo_co_che.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            m_cbo_co_che.ValueMember = CM_DM_TU_DIEN.ID;
        }

        public void load_data_2_cbo_loai_du_an()
        {
            DS_CM_DM_TU_DIEN v_ds_cm_dm_td = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us_cm_dm_td = new US_CM_DM_TU_DIEN();
            v_us_cm_dm_td.FillDatasetByIdLoaiTuDien(v_ds_cm_dm_td, (int)cm_dm_tu_dien.LOAI_DU_AN);
            m_cbo_loai_du_an.DataSource = v_ds_cm_dm_td.Tables[0];
            m_cbo_loai_du_an.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            m_cbo_loai_du_an.ValueMember = CM_DM_TU_DIEN.ID;
        }
        public void load_data_2_txt_ma_quyet_dinh_custom_source()
        {
            BKI_HRM.DS.DS_DM_QUYET_DINH v_ds_quyet_dinh = new BKI_HRM.DS.DS_DM_QUYET_DINH();
            BKI_HRM.US.US_DM_QUYET_DINH v_us_quyet_dinh = new BKI_HRM.US.US_DM_QUYET_DINH();
            v_us_quyet_dinh.FillDatasetByIdLoaiQD(v_ds_quyet_dinh,(int)cm_dm_tu_dien.THANH_LAP_DU_AN);
            int count = v_ds_quyet_dinh.Tables["DM_QUYET_DINH"].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataRow dr = v_ds_quyet_dinh.Tables["DM_QUYET_DINH"].Rows[i];
                m_txt_ma_quyet_dinh.AutoCompleteCustomSource.Add(dr[1].ToString());
            }
        }
        public void form_2_us_object()
        {
            m_us_dm_quyet_dinh.strMA_QUYET_DINH = m_txt_ma_quyet_dinh.Text;
            m_us_dm_quyet_dinh.strNOI_DUNG = m_txt_noi_dung_quyet_dinh.Text;
            m_us_dm_quyet_dinh.strLINK = m_txt_link.Text;

            if (m_dat_ngay_co_hieu_luc.Checked)
            {
                m_us_dm_quyet_dinh.datNGAY_CO_HIEU_LUC = m_dat_ngay_co_hieu_luc.Value;
            }

            if (m_dat_ngay_het_hieu_luc.Checked)
            {
                m_us_dm_quyet_dinh.datNGAY_HET_HIEU_LUC = m_dat_ngay_het_hieu_luc.Value;
            }

            if (m_dat_ngay_ki.Checked)
            {
                m_us_dm_quyet_dinh.datNGAY_KY = m_dat_ngay_ki.Value;
            }

            m_us_dm_quyet_dinh.dcID_LOAI_QD = (int)cm_dm_tu_dien.THANH_LAP_DU_AN;

            //----------------------------------------------------------------------------------
            m_us_dm_du_an.dcID_CO_CHE = CIPConvert.ToDecimal(m_cbo_co_che.SelectedValue);
            m_us_dm_du_an.dcID_LOAI_DU_AN = CIPConvert.ToDecimal(m_cbo_loai_du_an.SelectedValue);
            m_us_dm_du_an.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);

            BKI_HRM.US.US_DM_QUYET_DINH v_us = new BKI_HRM.US.US_DM_QUYET_DINH();
            BKI_HRM.DS.DS_DM_QUYET_DINH v_ds = new BKI_HRM.DS.DS_DM_QUYET_DINH();

            //v_us.FillDatasetByMaQuyetDinh(v_ds,m_txt_ma_quyet_dinh.Text);

            //DataRow dr = v_ds.Tables[0].Rows[0];

            m_us_dm_du_an.dcID_QUYET_DINH = m_us_dm_quyet_dinh.dcID;
                //CIPConvert.ToDecimal(dr[0].ToString());

            m_us_dm_du_an.strMA_DU_AN = m_txt_ma_du_an.Text;
            m_us_dm_du_an.strNOI_DUNG = m_txt_noi_dung.Text;
            m_us_dm_du_an.strTEN_DU_AN = m_txt_ten_du_an.Text;

            m_us_dm_du_an.datNGAY_BAT_DAU = m_dat_ngay_bd.Value;
            m_us_dm_du_an.datNGAY_KET_THUC = m_dat_ngay_kt.Value;
        }

        private void save_data()
        {
            if (check_data_is_ok() == false)
            {
                return;
            }
            form_2_us_object();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_quyet_dinh.Insert();
                    m_us_dm_du_an.Insert();                    
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_quyet_dinh.Update();
                    m_us_dm_du_an.Update();                    
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }

        private bool check_data_is_ok()
        {
            return true;
        }

        private void load_data_2_control() 
        {
            load_data_2_cbo_co_che();
            load_data_2_cbo_loai_du_an();
            load_data_2_cbo_trang_thai();
            load_data_2_txt_ma_quyet_dinh_custom_source();
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
                m_txt_noi_dung.Text = "";
                m_txt_ten_du_an.Text = "";
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {

        }

        private void f500_dm_du_an_detail_Load(object sender, EventArgs e)
        {
            
        }
        #endregion        
    
        
    }
}
