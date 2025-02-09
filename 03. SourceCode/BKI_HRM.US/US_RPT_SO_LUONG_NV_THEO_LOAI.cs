///************************************************
/// Generated by: AnhLT
/// Date: 15/09/2014 09:53:53
/// Goal: Create User Service Class for RPT_SO_LUONG_NV_THEO_LOAI
///************************************************
/// <summary>
/// Create User Service Class for RPT_SO_LUONG_NV_THEO_LOAI
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_RPT_SO_LUONG_NV_THEO_LOAI : US_Object
{
	private const string c_TableName = "RPT_SO_LUONG_NV_THEO_LOAI";
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

	public decimal dcLOAI_NV 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "LOAI_NV", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["LOAI_NV"] = value;
		}
	}

	public bool IsLOAI_NVNull()	{
		return pm_objDR.IsNull("LOAI_NV");
	}

	public void SetLOAI_NVNull() {
		pm_objDR["LOAI_NV"] = System.Convert.DBNull;
	}

	public decimal dcTHANG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "THANG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["THANG"] = value;
		}
	}

	public bool IsTHANGNull()	{
		return pm_objDR.IsNull("THANG");
	}

	public void SetTHANGNull() {
		pm_objDR["THANG"] = System.Convert.DBNull;
	}

	public decimal dcSO_LUONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_LUONG"] = value;
		}
	}

	public bool IsSO_LUONGNull()	{
		return pm_objDR.IsNull("SO_LUONG");
	}

	public void SetSO_LUONGNull() {
		pm_objDR["SO_LUONG"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_RPT_SO_LUONG_NV_THEO_LOAI() 
	{
		pm_objDS = new DS_RPT_SO_LUONG_NV_THEO_LOAI();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_RPT_SO_LUONG_NV_THEO_LOAI(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_RPT_SO_LUONG_NV_THEO_LOAI(decimal i_dbID) 
	{
		pm_objDS = new DS_RPT_SO_LUONG_NV_THEO_LOAI();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
    public void FillDatasetByProc(DS_RPT_SO_LUONG_NV_THEO_LOAI op_ds_rpt, DateTime ip_dat_thoi_diem, decimal ip_dc_phap_nhan)
    {
        CStoredProc v_sp = new CStoredProc("pr_RPT_SO_LUONG_NV_THEO_LOAI");
        v_sp.addDatetimeInputParam("@ip_dat_thoi_diem", ip_dat_thoi_diem);
        v_sp.addDecimalInputParam("@ip_dc_phap_nhan", ip_dc_phap_nhan);
        v_sp.fillDataSetByCommand(this, op_ds_rpt);
    }
	}
}
