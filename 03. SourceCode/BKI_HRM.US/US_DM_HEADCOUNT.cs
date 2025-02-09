///************************************************
/// Generated by: AnhHT
/// Date: 25/03/2014 09:12:32
/// Goal: Create User Service Class for DM_HEADCOUNT
///************************************************
/// <summary>
/// Create User Service Class for DM_HEADCOUNT
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_DM_HEADCOUNT : US_Object
{
	private const string c_TableName = "DM_HEADCOUNT";
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

	public string strMA_HEADCOUNT 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_HEADCOUNT", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_HEADCOUNT"] = value;
		}
	}

	public bool IsMA_HEADCOUNTNull() 
	{
		return pm_objDR.IsNull("MA_HEADCOUNT");
	}

	public void SetMA_HEADCOUNTNull() {
		pm_objDR["MA_HEADCOUNT"] = System.Convert.DBNull;
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

	public void SetTRANG_THAINull() {
		pm_objDR["TRANG_THAI"] = System.Convert.DBNull;
	}

	public string strACTIONS 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "ACTIONS", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["ACTIONS"] = value;
		}
	}

	public bool IsACTIONSNull() 
	{
		return pm_objDR.IsNull("ACTIONS");
	}

	public void SetACTIONSNull() {
		pm_objDR["ACTIONS"] = System.Convert.DBNull;
	}

	public string strMO_TA 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MO_TA", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MO_TA"] = value;
		}
	}

	public bool IsMO_TANull() 
	{
		return pm_objDR.IsNull("MO_TA");
	}

	public void SetMO_TANull() {
		pm_objDR["MO_TA"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_HEADCOUNT() 
	{
		pm_objDS = new DS_DM_HEADCOUNT();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_HEADCOUNT(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_HEADCOUNT(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_HEADCOUNT();
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
