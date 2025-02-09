///************************************************
/// Generated by: THAIPH
/// Date: 13/04/2014 10:12:42
/// Goal: Create User Service Class for V_GD_BAO_CAO_DU_AN_2
///************************************************
/// <summary>
/// Create User Service Class for V_GD_BAO_CAO_DU_AN_2
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US
{

    public class US_V_GD_BAO_CAO_DU_AN_2 : US_Object
    {
        private const string c_TableName = "V_GD_BAO_CAO_DU_AN_2";
        #region "Public Properties"
        public string strTEN_DU_AN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_DU_AN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_DU_AN"] = value;
            }
        }

        public bool IsTEN_DU_ANNull()
        {
            return pm_objDR.IsNull("TEN_DU_AN");
        }

        public void SetTEN_DU_ANNull()
        {
            pm_objDR["TEN_DU_AN"] = System.Convert.DBNull;
        }

        public string strMA_DU_AN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_DU_AN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_DU_AN"] = value;
            }
        }

        public bool IsMA_DU_ANNull()
        {
            return pm_objDR.IsNull("MA_DU_AN");
        }

        public void SetMA_DU_ANNull()
        {
            pm_objDR["MA_DU_AN"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_BAT_DAU
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_BAT_DAU"] = value;
            }
        }

        public bool IsNGAY_BAT_DAUNull()
        {
            return pm_objDR.IsNull("NGAY_BAT_DAU");
        }

        public void SetNGAY_BAT_DAUNull()
        {
            pm_objDR["NGAY_BAT_DAU"] = System.Convert.DBNull;
        }

        public string strTRUONG_DU_AN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRUONG_DU_AN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRUONG_DU_AN"] = value;
            }
        }

        public bool IsTRUONG_DU_ANNull()
        {
            return pm_objDR.IsNull("TRUONG_DU_AN");
        }

        public void SetTRUONG_DU_ANNull()
        {
            pm_objDR["TRUONG_DU_AN"] = System.Convert.DBNull;
        }

        public decimal dcSL_THANH_VIEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SL_THANH_VIEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SL_THANH_VIEN"] = value;
            }
        }

        public bool IsSL_THANH_VIENNull()
        {
            return pm_objDR.IsNull("SL_THANH_VIEN");
        }

        public void SetSL_THANH_VIENNull()
        {
            pm_objDR["SL_THANH_VIEN"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_KET_THUC
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_KET_THUC"] = value;
            }
        }

        public bool IsNGAY_KET_THUCNull()
        {
            return pm_objDR.IsNull("NGAY_KET_THUC");
        }

        public void SetNGAY_KET_THUCNull()
        {
            pm_objDR["NGAY_KET_THUC"] = System.Convert.DBNull;
        }

        public string strCO_CHE
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "CO_CHE", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["CO_CHE"] = value;
            }
        }

        public bool IsCO_CHENull()
        {
            return pm_objDR.IsNull("CO_CHE");
        }

        public void SetCO_CHENull()
        {
            pm_objDR["CO_CHE"] = System.Convert.DBNull;
        }

        public string strGHI_CHU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU"] = value;
            }
        }

        public bool IsGHI_CHUNull()
        {
            return pm_objDR.IsNull("GHI_CHU");
        }

        public void SetGHI_CHUNull()
        {
            pm_objDR["GHI_CHU"] = System.Convert.DBNull;
        }

        public decimal dcID_QUYET_DINH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_QUYET_DINH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_QUYET_DINH"] = value;
            }
        }

        public bool IsID_QUYET_DINHNull()
        {
            return pm_objDR.IsNull("ID_QUYET_DINH");
        }

        public void SetID_QUYET_DINHNull()
        {
            pm_objDR["ID_QUYET_DINH"] = System.Convert.DBNull;
        }

        public string strMA_QUYET_DINH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_QUYET_DINH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_QUYET_DINH"] = value;
            }
        }

        public bool IsMA_QUYET_DINHNull()
        {
            return pm_objDR.IsNull("MA_QUYET_DINH");
        }

        public void SetMA_QUYET_DINHNull()
        {
            pm_objDR["MA_QUYET_DINH"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_DU_AN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_DU_AN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_DU_AN"] = value;
            }
        }

        public bool IsID_LOAI_DU_ANNull()
        {
            return pm_objDR.IsNull("ID_LOAI_DU_AN");
        }

        public void SetID_LOAI_DU_ANNull()
        {
            pm_objDR["ID_LOAI_DU_AN"] = System.Convert.DBNull;
        }

        public decimal dcID_TRANG_THAI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TRANG_THAI"] = value;
            }
        }

        public bool IsID_TRANG_THAINull()
        {
            return pm_objDR.IsNull("ID_TRANG_THAI");
        }

        public void SetID_TRANG_THAINull()
        {
            pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
        }

        public decimal dcID_CO_CHE
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_CO_CHE", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_CO_CHE"] = value;
            }
        }

        public bool IsID_CO_CHENull()
        {
            return pm_objDR.IsNull("ID_CO_CHE");
        }

        public void SetID_CO_CHENull()
        {
            pm_objDR["ID_CO_CHE"] = System.Convert.DBNull;
        }

        public string strTRANG_THAI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRANG_THAI"] = value;
            }
        }

        public bool IsTRANG_THAINull()
        {
            return pm_objDR.IsNull("TRANG_THAI");
        }

        public void SetTRANG_THAINull()
        {
            pm_objDR["TRANG_THAI"] = System.Convert.DBNull;
        }

        public string strLOAI_DU_AN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LOAI_DU_AN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LOAI_DU_AN"] = value;
            }
        }

        public bool IsLOAI_DU_ANNull()
        {
            return pm_objDR.IsNull("LOAI_DU_AN");
        }

        public void SetLOAI_DU_ANNull()
        {
            pm_objDR["LOAI_DU_AN"] = System.Convert.DBNull;
        }

        public string strLOAI_QD
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LOAI_QD", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LOAI_QD"] = value;
            }
        }

        public bool IsLOAI_QDNull()
        {
            return pm_objDR.IsNull("LOAI_QD");
        }

        public void SetLOAI_QDNull()
        {
            pm_objDR["LOAI_QD"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_GD_BAO_CAO_DU_AN_2()
        {
            pm_objDS = new DS_V_GD_BAO_CAO_DU_AN_2();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_GD_BAO_CAO_DU_AN_2(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_GD_BAO_CAO_DU_AN_2(decimal i_dbID)
        {
            pm_objDS = new DS_V_GD_BAO_CAO_DU_AN_2();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion


        public void FillDatasetSearch(
            DS_V_GD_BAO_CAO_DU_AN_2 op_ds_bc_da, 
            string i_str_search,
            DateTime v_dat_tu_ngay,
            DateTime v_dat_den_ngay,
            decimal v_dc_trang_thai,
            decimal v_dc_loai_du_an,
            decimal v_dc_co_che,
            decimal v_dc_tim_kiem_theo_ngay,
            decimal ip_dc_id_phap_nhan)
        {
            CStoredProc v_sp = new CStoredProc("pr_V_GD_BAO_CAO_DU_AN_2_search");
            v_sp.addNVarcharInputParam("@str_search", i_str_search);
            v_sp.addDatetimeInputParam("@tu_ngay", v_dat_tu_ngay);
            v_sp.addDatetimeInputParam("@den_ngay", v_dat_den_ngay);
            v_sp.addDecimalInputParam("@id_trang_thai_du_an", v_dc_trang_thai);
            v_sp.addDecimalInputParam("@id_loai_du_an", v_dc_loai_du_an);
            v_sp.addDecimalInputParam("@id_co_che", v_dc_co_che);
            v_sp.addDecimalInputParam("@tim_kiem_theo_ngay", v_dc_tim_kiem_theo_ngay);
            v_sp.addDecimalInputParam("@id_phap_nhan", ip_dc_id_phap_nhan);
            v_sp.fillDataSetByCommand(this, op_ds_bc_da);
        }
    }
}
