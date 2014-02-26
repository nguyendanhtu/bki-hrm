///************************************************
/// Generated by: TrongHV
/// Date: 09/01/2014 05:06:40
/// Goal: Create User Service Class for V_GD_TRANG_THAI_LAO_DONG
///************************************************
/// <summary>
/// Create User Service Class for V_GD_TRANG_THAI_LAO_DONG
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_V_GD_TRANG_THAI_LAO_DONG : US_Object
{
	private const string c_TableName = "V_GD_TRANG_THAI_LAO_DONG";
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

	public void SetMA_NVNull() {
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

	public void SetHO_DEMNull() {
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

	public void SetTENNull() {
		pm_objDR["TEN"] = System.Convert.DBNull;
	}

	public decimal dcID_TRANG_LAO_DONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_LAO_DONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TRANG_LAO_DONG"] = value;
		}
	}

	public bool IsID_TRANG_LAO_DONGNull()	{
		return pm_objDR.IsNull("ID_TRANG_LAO_DONG");
	}

	public void SetID_TRANG_LAO_DONGNull() {
		pm_objDR["ID_TRANG_LAO_DONG"] = System.Convert.DBNull;
	}

	public string strExpr1 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "Expr1", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["Expr1"] = value;
		}
	}

	public bool IsExpr1Null() 
	{
		return pm_objDR.IsNull("Expr1");
	}

	public void SetExpr1Null() {
		pm_objDR["Expr1"] = System.Convert.DBNull;
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

	public void SetMA_QUYET_DINHNull() {
		pm_objDR["MA_QUYET_DINH"] = System.Convert.DBNull;
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

	public bool IsID_LOAI_QDNull()	{
		return pm_objDR.IsNull("ID_LOAI_QD");
	}

	public void SetID_LOAI_QDNull() {
		pm_objDR["ID_LOAI_QD"] = System.Convert.DBNull;
	}

	public string strExpr2 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "Expr2", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["Expr2"] = value;
		}
	}

	public bool IsExpr2Null() 
	{
		return pm_objDR.IsNull("Expr2");
	}

	public void SetExpr2Null() {
		pm_objDR["Expr2"] = System.Convert.DBNull;
	}

	public string strTRANG_THAI_HIEN_TAI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRANG_THAI_HIEN_TAI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRANG_THAI_HIEN_TAI"] = value;
		}
	}

	public bool IsTRANG_THAI_HIEN_TAINull() 
	{
		return pm_objDR.IsNull("TRANG_THAI_HIEN_TAI");
	}

	public void SetTRANG_THAI_HIEN_TAINull() {
		pm_objDR["TRANG_THAI_HIEN_TAI"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_GD_TRANG_THAI_LAO_DONG() 
	{
		pm_objDS = new DS_V_GD_TRANG_THAI_LAO_DONG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_TRANG_THAI_LAO_DONG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_TRANG_THAI_LAO_DONG(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_TRANG_THAI_LAO_DONG();
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

    public void FillDataset(string ip_txt_search,DS_V_GD_TRANG_THAI_LAO_DONG op_ds_v_gd_trang_thai_lao_dong){
        CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_TRANG_THAI_LAO_DONG_search");
        v_stored_proc.addNVarcharInputParam("@ip_str_search", ip_txt_search);
        v_stored_proc.fillDataSetByCommand(this,op_ds_v_gd_trang_thai_lao_dong);
    }

    public void FillDataset(DateTime ip_dat_bat_dau, DateTime ip_dat_ket_thuc, string ip_txt_search, DS_V_GD_TRANG_THAI_LAO_DONG op_ds_v_gd_trang_thai_lao_dong) {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_TRANG_THAI_LAO_DONG_search_datetime");
        v_stored_proc.addDatetimeInputParam("@ip_dat_bat_dau", ip_dat_bat_dau);
        v_stored_proc.addDatetimeInputParam("@ip_dat_ket_thuc", ip_dat_ket_thuc);
        v_stored_proc.addNVarcharInputParam("@ip_str_search", ip_txt_search);
        v_stored_proc.fillDataSetByCommand(this, op_ds_v_gd_trang_thai_lao_dong);
    }
    public void FillDatasetByManhanvien(DS_V_GD_TRANG_THAI_LAO_DONG op_ds, string ip_str_ma_nv)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_GD_TRANG_THAI_LAO_DONG_By_Ma_nhan_vien");
        v_sp.addDecimalInputParam("@MA_NHAN_VIEN", ip_str_ma_nv);
        v_sp.fillDataSetByCommand(this, op_ds);
    }
    #endregion
}
}
