///************************************************
/// Generated by: AnhHT
/// Date: 09/01/2014 03:51:46
/// Goal: Create User Service Class for V_GD_QUA_TRINH_LAM_VIEC
///************************************************
/// <summary>
/// Create User Service Class for V_GD_QUA_TRINH_LAM_VIEC
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_V_GD_QUA_TRINH_LAM_VIEC : US_Object
{
	private const string c_TableName = "V_GD_QUA_TRINH_LAM_VIEC";
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

	public string strMA_CV 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_CV", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_CV"] = value;
		}
	}

	public bool IsMA_CVNull() 
	{
		return pm_objDR.IsNull("MA_CV");
	}

	public void SetMA_CVNull() {
		pm_objDR["MA_CV"] = System.Convert.DBNull;
	}

	public string strTEN_CV 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_CV", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_CV"] = value;
		}
	}

	public bool IsTEN_CVNull() 
	{
		return pm_objDR.IsNull("TEN_CV");
	}

	public void SetTEN_CVNull() {
		pm_objDR["TEN_CV"] = System.Convert.DBNull;
	}

	public string strMA_DON_VI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_DON_VI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_DON_VI"] = value;
		}
	}

	public bool IsMA_DON_VINull() 
	{
		return pm_objDR.IsNull("MA_DON_VI");
	}

	public void SetMA_DON_VINull() {
		pm_objDR["MA_DON_VI"] = System.Convert.DBNull;
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

	public decimal dcID_TRANG_THAI_CV 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI_CV", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TRANG_THAI_CV"] = value;
		}
	}

	public bool IsID_TRANG_THAI_CVNull()	{
		return pm_objDR.IsNull("ID_TRANG_THAI_CV");
	}

	public void SetID_TRANG_THAI_CVNull() {
		pm_objDR["ID_TRANG_THAI_CV"] = System.Convert.DBNull;
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

#endregion
#region "Init Functions"
	public US_V_GD_QUA_TRINH_LAM_VIEC() 
	{
		pm_objDS = new DS_V_GD_QUA_TRINH_LAM_VIEC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_QUA_TRINH_LAM_VIEC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_QUA_TRINH_LAM_VIEC(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_QUA_TRINH_LAM_VIEC();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDataset_search(DS_V_GD_QUA_TRINH_LAM_VIEC op_ds, 
        string ip_str_ma_nhan_vien, 
        decimal ip_dc_trang_thai){
            var command = new CStoredProc("pr_V_GD_QUA_TRINH_LAM_VIEC_Search");
            command.addNVarcharInputParam("@MA_NV", ip_str_ma_nhan_vien);
            command.addDecimalInputParam("@ID_TRANG_THAI_CV", ip_dc_trang_thai);
            command.fillDataSetByCommand(this, op_ds);

	}
}
}