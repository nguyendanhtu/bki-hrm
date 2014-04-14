///************************************************
/// Generated by: AnhLT
/// Date: 25/02/2014 05:39:47
/// Goal: Create User Service Class for V_DM_CHUC_VU
///************************************************
/// <summary>
/// Create User Service Class for V_DM_CHUC_VU
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US {

    public class US_V_DM_CHUC_VU : US_Object {
        private const string c_TableName = "V_DM_CHUC_VU";
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

        public string strMA_CV {
            get {
                return CNull.RowNVLString(pm_objDR, "MA_CV", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["MA_CV"] = value;
            }
        }

        public bool IsMA_CVNull() {
            return pm_objDR.IsNull("MA_CV");
        }

        public void SetMA_CVNull() {
            pm_objDR["MA_CV"] = System.Convert.DBNull;
        }

        public string strTEN_CV {
            get {
                return CNull.RowNVLString(pm_objDR, "TEN_CV", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["TEN_CV"] = value;
            }
        }

        public bool IsTEN_CVNull() {
            return pm_objDR.IsNull("TEN_CV");
        }

        public void SetTEN_CVNull() {
            pm_objDR["TEN_CV"] = System.Convert.DBNull;
        }

        public string strTEN_CV_TA {
            get {
                return CNull.RowNVLString(pm_objDR, "TEN_CV_TA", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["TEN_CV_TA"] = value;
            }
        }

        public bool IsTEN_CV_TANull() {
            return pm_objDR.IsNull("TEN_CV_TA");
        }

        public void SetTEN_CV_TANull() {
            pm_objDR["TEN_CV_TA"] = System.Convert.DBNull;
        }

        public decimal dcID_NGACH {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGACH", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["ID_NGACH"] = value;
            }
        }

        public bool IsID_NGACHNull() {
            return pm_objDR.IsNull("ID_NGACH");
        }

        public void SetID_NGACHNull() {
            pm_objDR["ID_NGACH"] = System.Convert.DBNull;
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

        public DateTime datNGAY_AP_DUNG {
            get {
                return CNull.RowNVLDate(pm_objDR, "NGAY_AP_DUNG", IPConstants.c_DefaultDate);
            }
            set {
                pm_objDR["NGAY_AP_DUNG"] = value;
            }
        }

        public bool IsNGAY_AP_DUNGNull() {
            return pm_objDR.IsNull("NGAY_AP_DUNG");
        }

        public void SetNGAY_AP_DUNGNull() {
            pm_objDR["NGAY_AP_DUNG"] = System.Convert.DBNull;
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

        public string strTRANG_THAI_SU_DUNG {
            get {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI_SU_DUNG", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["TRANG_THAI_SU_DUNG"] = value;
            }
        }

        public bool IsTRANG_THAI_SU_DUNGNull() {
            return pm_objDR.IsNull("TRANG_THAI_SU_DUNG");
        }

        public void SetTRANG_THAI_SU_DUNGNull() {
            pm_objDR["TRANG_THAI_SU_DUNG"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_DM_CHUC_VU() {
            pm_objDS = new DS_V_DM_CHUC_VU();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_DM_CHUC_VU(DataRow i_objDR)
            : this() {
            this.DataRow2Me(i_objDR);
        }

        public US_V_DM_CHUC_VU(decimal i_dbID) {
            pm_objDS = new DS_V_DM_CHUC_VU();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
        public void FillDatasetSearch(DS_V_DM_CHUC_VU op_ds, string i_str_search) {
            CStoredProc v_sp = new CStoredProc("pr_V_DM_CHUC_VU_search");
            v_sp.addNVarcharInputParam("@STR_SEARCH", i_str_search);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
        public void FillDatasetOrderByMaChucVu(DS_V_DM_CHUC_VU op_ds) {
            CStoredProc v_sp = new CStoredProc("pr_V_DM_CHUC_VU_order_by_ma_chuc_vu");
            v_sp.fillDataSetByCommand(this, op_ds);
        }
    }
}
