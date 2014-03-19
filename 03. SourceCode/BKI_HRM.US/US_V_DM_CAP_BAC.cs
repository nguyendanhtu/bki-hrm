///************************************************
/// Generated by: TuNA
/// Date: 19-03-2014 02:33:26
/// Goal: Create User Service Class for V_DM_CAP_BAC
///************************************************
/// <summary>
/// Create User Service Class for V_DM_CAP_BAC
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_V_DM_CAP_BAC : US_Object
{
	private const string c_TableName = "V_DM_CAP_BAC";
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

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public string strMA_CAP 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_CAP", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_CAP"] = value;
		}
	}

	public bool IsMA_CAPNull() 
	{
		return pm_objDR.IsNull("MA_CAP");
	}

	public void SetMA_CAPNull() {
		pm_objDR["MA_CAP"] = System.Convert.DBNull;
	}

	public string strMA_BAC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_BAC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_BAC"] = value;
		}
	}

	public bool IsMA_BACNull() 
	{
		return pm_objDR.IsNull("MA_BAC");
	}

	public void SetMA_BACNull() {
		pm_objDR["MA_BAC"] = System.Convert.DBNull;
	}

	public string strTRANG_THAI_SU_DUNG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRANG_THAI_SU_DUNG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRANG_THAI_SU_DUNG"] = value;
		}
	}

	public bool IsTRANG_THAI_SU_DUNGNull() 
	{
		return pm_objDR.IsNull("TRANG_THAI_SU_DUNG");
	}

	public void SetTRANG_THAI_SU_DUNGNull() {
		pm_objDR["TRANG_THAI_SU_DUNG"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_AP_DUNG
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_AP_DUNG", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_AP_DUNG"] = value;
		}
	}

	public bool IsNGAY_AP_DUNGNull()
	{
		return pm_objDR.IsNull("NGAY_AP_DUNG");
	}

	public void SetNGAY_AP_DUNGNull()
	{
		pm_objDR["NGAY_AP_DUNG"] = System.Convert.DBNull;
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

	public string strMA_CAP_BAC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_CAP_BAC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_CAP_BAC"] = value;
		}
	}

	public bool IsMA_CAP_BACNull() 
	{
		return pm_objDR.IsNull("MA_CAP_BAC");
	}

	public void SetMA_CAP_BACNull() {
		pm_objDR["MA_CAP_BAC"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_DM_CAP_BAC() 
	{
		pm_objDS = new DS_V_DM_CAP_BAC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_CAP_BAC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_CAP_BAC(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_CAP_BAC();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
	}
}
