///************************************************
/// Generated by: NghiaDT
/// Date: 10/01/2014 04:43:18
/// Goal: Create User Service Class for V_GD_HOP_DONG_LAO_DONG
///************************************************
/// <summary>
/// Create User Service Class for V_GD_HOP_DONG_LAO_DONG
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_V_GD_HOP_DONG_LAO_DONG : US_Object
{
	private const string c_TableName = "V_GD_HOP_DONG_LAO_DONG";
    #region "Public Properties"
    public string strMA_NV
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "MA_NV", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["MA_NV"] = value;
        }
    }

    public bool IsMA_NVNull()
    {
        return pm_objDR.IsNull("MA_NV");
    }

    public void SetMA_NVNull()
    {
        pm_objDR["MA_NV"] = System.Convert.DBNull;
    }

    public string strHO_DEM
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "HO_DEM", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["HO_DEM"] = value;
        }
    }

    public bool IsHO_DEMNull()
    {
        return pm_objDR.IsNull("HO_DEM");
    }

    public void SetHO_DEMNull()
    {
        pm_objDR["HO_DEM"] = System.Convert.DBNull;
    }

    public string strTEN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN"] = value;
        }
    }

    public bool IsTENNull()
    {
        return pm_objDR.IsNull("TEN");
    }

    public void SetTENNull()
    {
        pm_objDR["TEN"] = System.Convert.DBNull;
    }

    public string strMA_HOP_DONG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "MA_HOP_DONG", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["MA_HOP_DONG"] = value;
        }
    }

    public bool IsMA_HOP_DONGNull()
    {
        return pm_objDR.IsNull("MA_HOP_DONG");
    }

    public void SetMA_HOP_DONGNull()
    {
        pm_objDR["MA_HOP_DONG"] = System.Convert.DBNull;
    }

    public decimal dcID_LOAI_HOP_DONG
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_HOP_DONG", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_LOAI_HOP_DONG"] = value;
        }
    }

    public bool IsID_LOAI_HOP_DONGNull()
    {
        return pm_objDR.IsNull("ID_LOAI_HOP_DONG");
    }

    public void SetID_LOAI_HOP_DONGNull()
    {
        pm_objDR["ID_LOAI_HOP_DONG"] = System.Convert.DBNull;
    }

    public string strLOAI_HOP_DONG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "LOAI_HOP_DONG", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["LOAI_HOP_DONG"] = value;
        }
    }

    public bool IsLOAI_HOP_DONGNull()
    {
        return pm_objDR.IsNull("LOAI_HOP_DONG");
    }

    public void SetLOAI_HOP_DONGNull()
    {
        pm_objDR["LOAI_HOP_DONG"] = System.Convert.DBNull;
    }

    public DateTime datNGAY_CO_HIEU_LUC
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_CO_HIEU_LUC", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_CO_HIEU_LUC"] = value;
        }
    }

    public bool IsNGAY_CO_HIEU_LUCNull()
    {
        return pm_objDR.IsNull("NGAY_CO_HIEU_LUC");
    }

    public void SetNGAY_CO_HIEU_LUCNull()
    {
        pm_objDR["NGAY_CO_HIEU_LUC"] = System.Convert.DBNull;
    }

    public DateTime datNGAY_HET_HAN
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_HET_HAN", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_HET_HAN"] = value;
        }
    }

    public bool IsNGAY_HET_HANNull()
    {
        return pm_objDR.IsNull("NGAY_HET_HAN");
    }

    public void SetNGAY_HET_HANNull()
    {
        pm_objDR["NGAY_HET_HAN"] = System.Convert.DBNull;
    }

    public string strTRANG_THAI_HOP_DONG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TRANG_THAI_HOP_DONG", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TRANG_THAI_HOP_DONG"] = value;
        }
    }

    public bool IsTRANG_THAI_HOP_DONGNull()
    {
        return pm_objDR.IsNull("TRANG_THAI_HOP_DONG");
    }

    public void SetTRANG_THAI_HOP_DONGNull()
    {
        pm_objDR["TRANG_THAI_HOP_DONG"] = System.Convert.DBNull;
    }

    #endregion
    #region "Init Functions"
    public US_V_GD_HOP_DONG_LAO_DONG()
    {
        pm_objDS = new DS_V_GD_HOP_DONG_LAO_DONG();
        pm_strTableName = c_TableName;
        pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
    }

    public US_V_GD_HOP_DONG_LAO_DONG(DataRow i_objDR)
        : this()
    {
        this.DataRow2Me(i_objDR);
    }

    public US_V_GD_HOP_DONG_LAO_DONG(decimal i_dbID)
    {
        pm_objDS = new DS_V_GD_HOP_DONG_LAO_DONG();
        pm_strTableName = c_TableName;
        IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
        v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
        SqlCommand v_cmdSQL;
        v_cmdSQL = v_objMkCmd.getSelectCmd();
        this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
        pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
    }
    #endregion
    public void FillDataset_search(DS_V_GD_HOP_DONG_LAO_DONG op_ds,
        string ip_str_nhan_vien,
        decimal ip_dc_loai_hop_dong,
        DateTime ip_dat_ngay_bat_dau,
        DateTime ip_dat_ngay_ket_thuc)
    {
        var command = new CStoredProc("pr_V_GD_HOP_DONG_LAO_DONG_Search");

        command.addNVarcharInputParam("@NHAN_VIEN", ip_str_nhan_vien);
        command.addDecimalInputParam("@ID_LOAI_HOP_DONG", ip_dc_loai_hop_dong);
        command.addDatetimeInputParam("@NGAY_BAT_DAU", ip_dat_ngay_bat_dau);
        command.addDatetimeInputParam("@NGAY_KET_THUC", ip_dat_ngay_ket_thuc);
        command.fillDataSetByCommand(this, op_ds);

    }
    public void FillDatasetByIDnhanvien(DS_V_GD_HOP_DONG_LAO_DONG op_ds, string ip_str_ma_nv)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_GD_HOP_DONG_LAO_DONG_By_Ma_nhan_vien");
        v_sp.addDecimalInputParam("@MA_NHAN_VIEN", ip_str_ma_nv);
        v_sp.fillDataSetByCommand(this, op_ds);
    }
	}
}
