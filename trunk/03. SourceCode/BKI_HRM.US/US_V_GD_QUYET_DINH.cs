///************************************************
/// Generated by: AnhHT
/// Date: 27/04/2014 04:55:18
/// Goal: Create User Service Class for V_GD_QUYET_DINH
///************************************************
/// <summary>
/// Create User Service Class for V_GD_QUYET_DINH
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_V_GD_QUYET_DINH : US_Object
{
	private const string c_TableName = "V_GD_QUYET_DINH";
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

    public decimal dcID_LOAI_QD
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_QD", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_LOAI_QD"] = value;
        }
    }

    public bool IsID_LOAI_QDNull()
    {
        return pm_objDR.IsNull("ID_LOAI_QD");
    }

    public void SetID_LOAI_QDNull()
    {
        pm_objDR["ID_LOAI_QD"] = System.Convert.DBNull;
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

    public DateTime datNGAY_KY
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_KY", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_KY"] = value;
        }
    }

    public bool IsNGAY_KYNull()
    {
        return pm_objDR.IsNull("NGAY_KY");
    }

    public void SetNGAY_KYNull()
    {
        pm_objDR["NGAY_KY"] = System.Convert.DBNull;
    }

    public DateTime datNGAY_HET_HIEU_LUC
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_HET_HIEU_LUC", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_HET_HIEU_LUC"] = value;
        }
    }

    public bool IsNGAY_HET_HIEU_LUCNull()
    {
        return pm_objDR.IsNull("NGAY_HET_HIEU_LUC");
    }

    public void SetNGAY_HET_HIEU_LUCNull()
    {
        pm_objDR["NGAY_HET_HIEU_LUC"] = System.Convert.DBNull;
    }

    public string strNOI_DUNG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NOI_DUNG", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NOI_DUNG"] = value;
        }
    }

    public bool IsNOI_DUNGNull()
    {
        return pm_objDR.IsNull("NOI_DUNG");
    }

    public void SetNOI_DUNGNull()
    {
        pm_objDR["NOI_DUNG"] = System.Convert.DBNull;
    }

    public string strLINK
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "LINK", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["LINK"] = value;
        }
    }

    public bool IsLINKNull()
    {
        return pm_objDR.IsNull("LINK");
    }

    public void SetLINKNull()
    {
        pm_objDR["LINK"] = System.Convert.DBNull;
    }

    public string strLOAI_QUYET_DINH
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "LOAI_QUYET_DINH", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["LOAI_QUYET_DINH"] = value;
        }
    }

    public bool IsLOAI_QUYET_DINHNull()
    {
        return pm_objDR.IsNull("LOAI_QUYET_DINH");
    }

    public void SetLOAI_QUYET_DINHNull()
    {
        pm_objDR["LOAI_QUYET_DINH"] = System.Convert.DBNull;
    }

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

    #endregion
    #region "Init Functions"
    public US_V_GD_QUYET_DINH()
    {
        pm_objDS = new DS_V_GD_QUYET_DINH();
        pm_strTableName = c_TableName;
        pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
    }

    public US_V_GD_QUYET_DINH(DataRow i_objDR)
        : this()
    {
        this.DataRow2Me(i_objDR);
    }

    public US_V_GD_QUYET_DINH(decimal i_dbID)
    {
        pm_objDS = new DS_V_GD_QUYET_DINH();
        pm_strTableName = c_TableName;
        IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
        v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
        SqlCommand v_cmdSQL;
        v_cmdSQL = v_objMkCmd.getSelectCmd();
        this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
        pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
    }
    #endregion

    

#region "Addtionals"
    public void FillDataset(DS_V_GD_QUYET_DINH op_ds)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_GD_QUYET_DINH_FillDataset");
        v_sp.fillDataSetByCommand(this, op_ds);
    }
    public void FillDatasetSearch(DS_V_GD_QUYET_DINH op_ds, string i_str_search)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_GD_QUYET_DINH_search");
        v_sp.addNVarcharInputParam("@STR_SEARCH", i_str_search);
        v_sp.fillDataSetByCommand(this, op_ds);
    }
#endregion
	}
}
