///************************************************
/// Generated by: DucVT
/// Date: 30/09/2014 10:38:31
/// Goal: Create User Service Class for RPT_TONG_LUONG
///************************************************
/// <summary>
/// Create User Service Class for RPT_TONG_LUONG
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US
{

    public class US_RPT_TONG_LUONG : US_Object
    {
        private const string c_TableName = "RPT_TONG_LUONG";
        #region "Public Properties"
        public decimal dcID
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public string strMA_KY
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_KY", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_KY"] = value;
            }
        }

        public bool IsMA_KYNull()
        {
            return pm_objDR.IsNull("MA_KY");
        }

        public void SetMA_KYNull()
        {
            pm_objDR["MA_KY"] = System.Convert.DBNull;
        }

        public decimal dcTONG_LUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_LUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_LUONG"] = value;
            }
        }

        public bool IsTONG_LUONGNull()
        {
            return pm_objDR.IsNull("TONG_LUONG");
        }

        public void SetTONG_LUONGNull()
        {
            pm_objDR["TONG_LUONG"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_RPT_TONG_LUONG()
        {
            pm_objDS = new DS_RPT_TONG_LUONG();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_RPT_TONG_LUONG(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_RPT_TONG_LUONG(decimal i_dbID)
        {
            pm_objDS = new DS_RPT_TONG_LUONG();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public void FillDatasetByMaCV(DS_RPT_TONG_LUONG op_ds_tong_luong, string ip_ma, decimal ip_id_phap_nhan)
        {
            CStoredProc v_sp = new CStoredProc("get_tong_luong_by_ma_cv");
            v_sp.addNVarcharInputParam("@ip_ma_chuc_vu", ip_ma);
            v_sp.addDecimalInputParam("@ip_id_phap_nhan", ip_id_phap_nhan);

            v_sp.fillDataSetByCommand(this, op_ds_tong_luong);
        }

        public void FillDatasetByMaTTLD(DS_RPT_TONG_LUONG op_ds_tong_luong, decimal ip_id_ttld, decimal ip_id_phap_nhan)
        {
            CStoredProc v_sp = new CStoredProc("get_tong_luong_by_ma_ttld");
            v_sp.addDecimalInputParam("@ip_id_ttld", ip_id_ttld);
            v_sp.addDecimalInputParam("@ip_id_phap_nhan", ip_id_phap_nhan);

            v_sp.fillDataSetByCommand(this, op_ds_tong_luong);
        }
    }
}
