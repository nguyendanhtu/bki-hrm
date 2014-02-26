///************************************************
/// Generated by: AnhLT
/// Date: 25/02/2014 04:43:00
/// Goal: Create User Service Class for V_DM_DU_LIEU_NHAN_VIEN
///************************************************
/// <summary>
/// Create User Service Class for V_DM_DU_LIEU_NHAN_VIEN
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_V_DM_DU_LIEU_NHAN_VIEN : US_Object
{
	private const string c_TableName = "V_DM_DU_LIEU_NHAN_VIEN";
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

	public string strGIOI_TINH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GIOI_TINH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GIOI_TINH"] = value;
		}
	}

	public bool IsGIOI_TINHNull() 
	{
		return pm_objDR.IsNull("GIOI_TINH");
	}

	public void SetGIOI_TINHNull() {
		pm_objDR["GIOI_TINH"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_SINH
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_SINH", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_SINH"] = value;
		}
	}

	public bool IsNGAY_SINHNull()
	{
		return pm_objDR.IsNull("NGAY_SINH");
	}

	public void SetNGAY_SINHNull()
	{
		pm_objDR["NGAY_SINH"] = System.Convert.DBNull;
	}

	public string strTRINH_DO 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRINH_DO", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRINH_DO"] = value;
		}
	}

	public bool IsTRINH_DONull() 
	{
		return pm_objDR.IsNull("TRINH_DO");
	}

	public void SetTRINH_DONull() {
		pm_objDR["TRINH_DO"] = System.Convert.DBNull;
	}

	public decimal dcID_CHUC_VU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_CHUC_VU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_CHUC_VU"] = value;
		}
	}

	public bool IsID_CHUC_VUNull()	{
		return pm_objDR.IsNull("ID_CHUC_VU");
	}

	public void SetID_CHUC_VUNull() {
		pm_objDR["ID_CHUC_VU"] = System.Convert.DBNull;
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

	public string strTRANG_THAI_CV 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRANG_THAI_CV", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRANG_THAI_CV"] = value;
		}
	}

	public bool IsTRANG_THAI_CVNull() 
	{
		return pm_objDR.IsNull("TRANG_THAI_CV");
	}

	public void SetTRANG_THAI_CVNull() {
		pm_objDR["TRANG_THAI_CV"] = System.Convert.DBNull;
	}

	public decimal dcTY_LE_THAM_GIA 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TY_LE_THAM_GIA", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TY_LE_THAM_GIA"] = value;
		}
	}

	public bool IsTY_LE_THAM_GIANull()	{
		return pm_objDR.IsNull("TY_LE_THAM_GIA");
	}

	public void SetTY_LE_THAM_GIANull() {
		pm_objDR["TY_LE_THAM_GIA"] = System.Convert.DBNull;
	}

	public decimal dcID_DON_VI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_VI"] = value;
		}
	}

	public bool IsID_DON_VINull()	{
		return pm_objDR.IsNull("ID_DON_VI");
	}

	public void SetID_DON_VINull() {
		pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
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

	public string strTEN_DON_VI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_DON_VI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_DON_VI"] = value;
		}
	}

	public bool IsTEN_DON_VINull() 
	{
		return pm_objDR.IsNull("TEN_DON_VI");
	}

	public void SetTEN_DON_VINull() {
		pm_objDR["TEN_DON_VI"] = System.Convert.DBNull;
	}

	public decimal dcID_DON_VI_CAP_TREN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_CAP_TREN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_VI_CAP_TREN"] = value;
		}
	}

	public bool IsID_DON_VI_CAP_TRENNull()	{
		return pm_objDR.IsNull("ID_DON_VI_CAP_TREN");
	}

	public void SetID_DON_VI_CAP_TRENNull() {
		pm_objDR["ID_DON_VI_CAP_TREN"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_DON_VI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_DON_VI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_DON_VI"] = value;
		}
	}

	public bool IsID_LOAI_DON_VINull()	{
		return pm_objDR.IsNull("ID_LOAI_DON_VI");
	}

	public void SetID_LOAI_DON_VINull() {
		pm_objDR["ID_LOAI_DON_VI"] = System.Convert.DBNull;
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

	public string strTRANG_THAI_LAO_DONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRANG_THAI_LAO_DONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRANG_THAI_LAO_DONG"] = value;
		}
	}

	public bool IsTRANG_THAI_LAO_DONGNull() 
	{
		return pm_objDR.IsNull("TRANG_THAI_LAO_DONG");
	}

	public void SetTRANG_THAI_LAO_DONGNull() {
		pm_objDR["TRANG_THAI_LAO_DONG"] = System.Convert.DBNull;
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

	public decimal dcID_VI_TRI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_VI_TRI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_VI_TRI"] = value;
		}
	}

	public bool IsID_VI_TRINull()	{
		return pm_objDR.IsNull("ID_VI_TRI");
	}

	public void SetID_VI_TRINull() {
		pm_objDR["ID_VI_TRI"] = System.Convert.DBNull;
	}

	public string strVI_TRI_DU_AN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "VI_TRI_DU_AN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["VI_TRI_DU_AN"] = value;
		}
	}

	public bool IsVI_TRI_DU_ANNull() 
	{
		return pm_objDR.IsNull("VI_TRI_DU_AN");
	}

	public void SetVI_TRI_DU_ANNull() {
		pm_objDR["VI_TRI_DU_AN"] = System.Convert.DBNull;
	}

	public DateTime datTHOI_DIEM_TG
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "THOI_DIEM_TG", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["THOI_DIEM_TG"] = value;
		}
	}

	public bool IsTHOI_DIEM_TGNull()
	{
		return pm_objDR.IsNull("THOI_DIEM_TG");
	}

	public void SetTHOI_DIEM_TGNull()
	{
		pm_objDR["THOI_DIEM_TG"] = System.Convert.DBNull;
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

	public void SetMA_DU_ANNull() {
		pm_objDR["MA_DU_AN"] = System.Convert.DBNull;
	}

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

	public void SetTEN_DU_ANNull() {
		pm_objDR["TEN_DU_AN"] = System.Convert.DBNull;
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

	public void SetMA_HOP_DONGNull() {
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

	public bool IsID_LOAI_HOP_DONGNull()	{
		return pm_objDR.IsNull("ID_LOAI_HOP_DONG");
	}

	public void SetID_LOAI_HOP_DONGNull() {
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

	public void SetLOAI_HOP_DONGNull() {
		pm_objDR["LOAI_HOP_DONG"] = System.Convert.DBNull;
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

	public void SetTRANG_THAI_HOP_DONGNull() {
		pm_objDR["TRANG_THAI_HOP_DONG"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_DM_DU_LIEU_NHAN_VIEN() 
	{
		pm_objDS = new DS_V_DM_DU_LIEU_NHAN_VIEN();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_DU_LIEU_NHAN_VIEN(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_DU_LIEU_NHAN_VIEN(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_DU_LIEU_NHAN_VIEN();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    #region "Addtional"

    public void FillDatasetByIdCV(DS_V_DM_DU_LIEU_NHAN_VIEN op_ds_nhan_su, decimal i_dc_id)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_DM_DU_LIEU_NHAN_VIEN_select_by_ID_CHUC_VU");
        v_sp.addDecimalInputParam("@ID_CHUC_VU", i_dc_id);
        v_sp.fillDataSetByCommand(this, op_ds_nhan_su);
    }


    public void FillDatasetByKeyWord(string ip_str_key_word, DS_V_DM_DU_LIEU_NHAN_VIEN op_ds_v_dm_du_lieu_nhan_vien) {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_DM_DU_LIEU_NHAN_VIEN_search");
        v_stored_proc.addNVarcharInputParam("@ip_str_search", ip_str_key_word);
        v_stored_proc.fillDataSetByCommand(this, op_ds_v_dm_du_lieu_nhan_vien);
    }

    public void FillDatasetConvention(string ip_str_key_word, string ip_str_gender, DS_V_DM_DU_LIEU_NHAN_VIEN op_ds_v_dm_du_lieu_nhan_vien) {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_DM_DU_LIEU_NHAN_VIEN_search_gioi_tinh");
        v_stored_proc.addNVarcharInputParam("@ip_str_search", ip_str_key_word);
        v_stored_proc.addNVarcharInputParam("@ip_str_gioi_tinh", ip_str_gender);
        v_stored_proc.fillDataSetByCommand(this, op_ds_v_dm_du_lieu_nhan_vien);
    }
    

    #endregion
}
}
