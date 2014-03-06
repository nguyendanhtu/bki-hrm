///************************************************
/// Generated by: TrongHV
/// Date: 16/01/2014 01:58:55
/// Goal: Create User Service Class for V_DM_DON_VI
///************************************************
/// <summary>
/// Create User Service Class for V_DM_DON_VI
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US {

    public class US_V_DM_DON_VI : US_Object {
        private const string c_TableName = "V_DM_DON_VI";

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

        public decimal dcID_DON_VI_CAP_TREN {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_CAP_TREN", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["ID_DON_VI_CAP_TREN"] = value;
            }
        }

        public bool IsID_DON_VI_CAP_TRENNull() {
            return pm_objDR.IsNull("ID_DON_VI_CAP_TREN");
        }

        public void SetID_DON_VI_CAP_TRENNull() {
            pm_objDR["ID_DON_VI_CAP_TREN"] = System.Convert.DBNull;
        }

        public decimal dcID_CAP_DON_VI {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "ID_CAP_DON_VI", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["ID_CAP_DON_VI"] = value;
            }
        }

        public bool IsID_CAP_DON_VINull() {
            return pm_objDR.IsNull("ID_CAP_DON_VI");
        }

        public void SetID_CAP_DON_VINull() {
            pm_objDR["ID_CAP_DON_VI"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_DON_VI {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_DON_VI", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["ID_LOAI_DON_VI"] = value;
            }
        }

        public bool IsID_LOAI_DON_VINull() {
            return pm_objDR.IsNull("ID_LOAI_DON_VI");
        }

        public void SetID_LOAI_DON_VINull() {
            pm_objDR["ID_LOAI_DON_VI"] = System.Convert.DBNull;
        }

        public string strTEN_DON_VI_CAP_TREN {
            get {
                return CNull.RowNVLString(pm_objDR, "TEN_DON_VI_CAP_TREN", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["TEN_DON_VI_CAP_TREN"] = value;
            }
        }

        public bool IsTEN_DON_VI_CAP_TRENNull() {
            return pm_objDR.IsNull("TEN_DON_VI_CAP_TREN");
        }

        public void SetTEN_DON_VI_CAP_TRENNull() {
            pm_objDR["TEN_DON_VI_CAP_TREN"] = System.Convert.DBNull;
        }

        public string strMA_DON_VI {
            get {
                return CNull.RowNVLString(pm_objDR, "MA_DON_VI", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["MA_DON_VI"] = value;
            }
        }

        public bool IsMA_DON_VINull() {
            return pm_objDR.IsNull("MA_DON_VI");
        }

        public void SetMA_DON_VINull() {
            pm_objDR["MA_DON_VI"] = System.Convert.DBNull;
        }

        public string strTEN_DON_VI {
            get {
                return CNull.RowNVLString(pm_objDR, "TEN_DON_VI", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["TEN_DON_VI"] = value;
            }
        }

        public bool IsTEN_DON_VINull() {
            return pm_objDR.IsNull("TEN_DON_VI");
        }

        public void SetTEN_DON_VINull() {
            pm_objDR["TEN_DON_VI"] = System.Convert.DBNull;
        }

        public string strTEN_TIENG_ANH {
            get {
                return CNull.RowNVLString(pm_objDR, "TEN_TIENG_ANH", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["TEN_TIENG_ANH"] = value;
            }
        }

        public bool IsTEN_TIENG_ANHNull() {
            return pm_objDR.IsNull("TEN_TIENG_ANH");
        }

        public void SetTEN_TIENG_ANHNull() {
            pm_objDR["TEN_TIENG_ANH"] = System.Convert.DBNull;
        }

        public DateTime datTU_NGAY {
            get {
                return CNull.RowNVLDate(pm_objDR, "TU_NGAY", IPConstants.c_DefaultDate);
            }
            set {
                pm_objDR["TU_NGAY"] = value;
            }
        }

        public bool IsTU_NGAYNull() {
            return pm_objDR.IsNull("TU_NGAY");
        }

        public void SetTU_NGAYNull() {
            pm_objDR["TU_NGAY"] = System.Convert.DBNull;
        }

        public string strDIA_BAN {
            get {
                return CNull.RowNVLString(pm_objDR, "DIA_BAN", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["DIA_BAN"] = value;
            }
        }

        public bool IsDIA_BANNull() {
            return pm_objDR.IsNull("DIA_BAN");
        }

        public void SetDIA_BANNull() {
            pm_objDR["DIA_BAN"] = System.Convert.DBNull;
        }

        public string strTRANG_THAI {
            get {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["TRANG_THAI"] = value;
            }
        }

        public bool IsTRANG_THAINull() {
            return pm_objDR.IsNull("TRANG_THAI");
        }

        public void SetTRANG_THAINull() {
            pm_objDR["TRANG_THAI"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_DM_DON_VI() {
            pm_objDS = new DS_V_DM_DON_VI();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_DM_DON_VI(DataRow i_objDR)
            : this() {
            this.DataRow2Me(i_objDR);
        }

        public US_V_DM_DON_VI(decimal i_dbID) {
            pm_objDS = new DS_V_DM_DON_VI();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        #region Addtional

        public void FillDatasetByKeyWord(DS_V_DM_DON_VI op_ds_v_v_dm_don_vi, string ip_str_key_word, DateTime ip_dat_tu_ngay) {
            CStoredProc v_stored_proc = new CStoredProc("pr_V_DM_DON_VI_search");
            v_stored_proc.addNVarcharInputParam("@ip_str_search", ip_str_key_word);
            v_stored_proc.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_stored_proc.fillDataSetByCommand(this, op_ds_v_v_dm_don_vi);
        }

        public void FillDatasetByKeyWord(DS_V_DM_DON_VI op_ds_v_v_dm_don_vi, string ip_str_key_word) {
            CStoredProc v_stored_proc = new CStoredProc("pr_V_DM_DON_VI_search");
            v_stored_proc.addNVarcharInputParam("@ip_str_search", ip_str_key_word);
            v_stored_proc.fillDataSetByCommand(this, op_ds_v_v_dm_don_vi);
        }

        public void FillDatasetByKeyWordTop(DS_V_DM_DON_VI op_ds_v_v_dm_don_vi, string ip_str_key_word) {
            CStoredProc v_stored_proc = new CStoredProc("pr_V_DM_DON_VI_search_top");
            v_stored_proc.addNVarcharInputParam("@ip_str_search", ip_str_key_word);
            v_stored_proc.fillDataSetByCommand(this, op_ds_v_v_dm_don_vi);
        }

        public void FillDatasetByCapDonVi(DS_V_DM_DON_VI op_ds_v_v_dm_don_vi, decimal ip_dc_cap_don_vi) {
            CStoredProc v_stored_proc = new CStoredProc("pr_V_DM_DON_VI_search_cap_don_vi");
            v_stored_proc.addNVarcharInputParam("@ip_dc_cap_don_vi", ip_dc_cap_don_vi);
            v_stored_proc.fillDataSetByCommand(this, op_ds_v_v_dm_don_vi);
        }


        #endregion
    }
}
