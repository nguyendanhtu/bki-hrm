///************************************************
/// Generated by: TrongHV
/// Date: 11/03/2014 06:56:48
/// Goal: Create User Service Class for V_GD_CHI_TIET_CAP_BAC
///************************************************
/// <summary>
/// Create User Service Class for V_GD_CHI_TIET_CAP_BAC
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US {

    public class US_V_GD_CHI_TIET_CAP_BAC : US_Object {
        private const string c_TableName = "V_GD_CHI_TIET_CAP_BAC";

        #region "Public Properties"
        public decimal dcID {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull() {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull() {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public string strMA_NV {
            get {
                return CNull.RowNVLString(pm_objDR, "MA_NV", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["MA_NV"] = value;
            }
        }

        public bool IsMA_NVNull() {
            return pm_objDR.IsNull("MA_NV");
        }

        public void SetMA_NVNull() {
            pm_objDR["MA_NV"] = System.Convert.DBNull;
        }

        public string strHO_DEM {
            get {
                return CNull.RowNVLString(pm_objDR, "HO_DEM", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["HO_DEM"] = value;
            }
        }

        public bool IsHO_DEMNull() {
            return pm_objDR.IsNull("HO_DEM");
        }

        public void SetHO_DEMNull() {
            pm_objDR["HO_DEM"] = System.Convert.DBNull;
        }

        public string strTEN {
            get {
                return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["TEN"] = value;
            }
        }

        public bool IsTENNull() {
            return pm_objDR.IsNull("TEN");
        }

        public void SetTENNull() {
            pm_objDR["TEN"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_BAT_DAU {
            get {
                return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU", IPConstants.c_DefaultDate);
            }
            set {
                pm_objDR["NGAY_BAT_DAU"] = value;
            }
        }

        public bool IsNGAY_BAT_DAUNull() {
            return pm_objDR.IsNull("NGAY_BAT_DAU");
        }

        public void SetNGAY_BAT_DAUNull() {
            pm_objDR["NGAY_BAT_DAU"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_KET_THUC {
            get {
                return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC", IPConstants.c_DefaultDate);
            }
            set {
                pm_objDR["NGAY_KET_THUC"] = value;
            }
        }

        public bool IsNGAY_KET_THUCNull() {
            return pm_objDR.IsNull("NGAY_KET_THUC");
        }

        public void SetNGAY_KET_THUCNull() {
            pm_objDR["NGAY_KET_THUC"] = System.Convert.DBNull;
        }

        public string strTRANG_THAI_CB {
            get {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI_CB", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["TRANG_THAI_CB"] = value;
            }
        }

        public bool IsTRANG_THAI_CBNull() {
            return pm_objDR.IsNull("TRANG_THAI_CB");
        }

        public void SetTRANG_THAI_CBNull() {
            pm_objDR["TRANG_THAI_CB"] = System.Convert.DBNull;
        }

        public string strMA_CAP {
            get {
                return CNull.RowNVLString(pm_objDR, "MA_CAP", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["MA_CAP"] = value;
            }
        }

        public bool IsMA_CAPNull() {
            return pm_objDR.IsNull("MA_CAP");
        }

        public void SetMA_CAPNull() {
            pm_objDR["MA_CAP"] = System.Convert.DBNull;
        }

        public string strMA_BAC {
            get {
                return CNull.RowNVLString(pm_objDR, "MA_BAC", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["MA_BAC"] = value;
            }
        }

        public bool IsMA_BACNull() {
            return pm_objDR.IsNull("MA_BAC");
        }

        public void SetMA_BACNull() {
            pm_objDR["MA_BAC"] = System.Convert.DBNull;
        }

        public string strMA_QUYET_DINH {
            get {
                return CNull.RowNVLString(pm_objDR, "MA_QUYET_DINH", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["MA_QUYET_DINH"] = value;
            }
        }

        public bool IsMA_QUYET_DINHNull() {
            return pm_objDR.IsNull("MA_QUYET_DINH");
        }

        public void SetMA_QUYET_DINHNull() {
            pm_objDR["MA_QUYET_DINH"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CO_HIEU_LUC {
            get {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CO_HIEU_LUC", IPConstants.c_DefaultDate);
            }
            set {
                pm_objDR["NGAY_CO_HIEU_LUC"] = value;
            }
        }

        public bool IsNGAY_CO_HIEU_LUCNull() {
            return pm_objDR.IsNull("NGAY_CO_HIEU_LUC");
        }

        public void SetNGAY_CO_HIEU_LUCNull() {
            pm_objDR["NGAY_CO_HIEU_LUC"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_HET_HIEU_LUC {
            get {
                return CNull.RowNVLDate(pm_objDR, "NGAY_HET_HIEU_LUC", IPConstants.c_DefaultDate);
            }
            set {
                pm_objDR["NGAY_HET_HIEU_LUC"] = value;
            }
        }

        public bool IsNGAY_HET_HIEU_LUCNull() {
            return pm_objDR.IsNull("NGAY_HET_HIEU_LUC");
        }

        public void SetNGAY_HET_HIEU_LUCNull() {
            pm_objDR["NGAY_HET_HIEU_LUC"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_GD_CHI_TIET_CAP_BAC() {
            pm_objDS = new DS_V_GD_CHI_TIET_CAP_BAC();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_GD_CHI_TIET_CAP_BAC(DataRow i_objDR)
            : this() {
            this.DataRow2Me(i_objDR);
        }

        public US_V_GD_CHI_TIET_CAP_BAC(decimal i_dbID) {
            pm_objDS = new DS_V_GD_CHI_TIET_CAP_BAC();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        #region "Addtional"

        public void FillDatasetByKeyWord(DS_V_GD_CHI_TIET_CAP_BAC op_ds_v_v_dm_don_vi, string ip_str_key_word) {
            CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_CHI_TIET_CAP_BAC_search");
            v_stored_proc.addNVarcharInputParam("@ip_str_search", ip_str_key_word);
            v_stored_proc.fillDataSetByCommand(this, op_ds_v_v_dm_don_vi);
        }
        public void FillDatasetByKeyWord(DS_V_GD_CHI_TIET_CAP_BAC op_ds_v_gd_chi_tiet_cap_bac, string ip_str_key_word, DateTime ip_dat_thoi_diem)
        {
            CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_CHI_TIET_CAP_BAC_select_by_MA_CAP_BAC_THOI_DIEM");
            v_stored_proc.addNVarcharInputParam("@MA_CAP_BAC", ip_str_key_word);
            v_stored_proc.addDatetimeInputParam("@THOI_DIEM", ip_dat_thoi_diem);
            v_stored_proc.fillDataSetByCommand(this, op_ds_v_gd_chi_tiet_cap_bac);
        }
        #endregion
    }
}
