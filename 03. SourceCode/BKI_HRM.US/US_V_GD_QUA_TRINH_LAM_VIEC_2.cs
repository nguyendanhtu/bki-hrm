///************************************************
/// Generated by: AnhLT
/// Date: 16/06/2014 02:00:53
/// Goal: Create User Service Class for V_GD_QUA_TRINH_LAM_VIEC_2
///************************************************
/// <summary>
/// Create User Service Class for V_GD_QUA_TRINH_LAM_VIEC_2
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US
{

    public class US_V_GD_QUA_TRINH_LAM_VIEC_2 : US_Object
    {
        private const string c_TableName = "V_GD_QUA_TRINH_LAM_VIEC_2";
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

        public void SetMA_CVNull()
        {
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

        public void SetTEN_CVNull()
        {
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

        public void SetMA_DON_VINull()
        {
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

        public void SetTEN_DON_VINull()
        {
            pm_objDR["TEN_DON_VI"] = System.Convert.DBNull;
        }

        public decimal dcID_CAP_DON_VI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_CAP_DON_VI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_CAP_DON_VI"] = value;
            }
        }

        public bool IsID_CAP_DON_VINull()
        {
            return pm_objDR.IsNull("ID_CAP_DON_VI");
        }

        public void SetID_CAP_DON_VINull()
        {
            pm_objDR["ID_CAP_DON_VI"] = System.Convert.DBNull;
        }

        public string strCAP_DON_VI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "CAP_DON_VI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["CAP_DON_VI"] = value;
            }
        }

        public bool IsCAP_DON_VINull()
        {
            return pm_objDR.IsNull("CAP_DON_VI");
        }

        public void SetCAP_DON_VINull()
        {
            pm_objDR["CAP_DON_VI"] = System.Convert.DBNull;
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

        public bool IsID_LOAI_DON_VINull()
        {
            return pm_objDR.IsNull("ID_LOAI_DON_VI");
        }

        public void SetID_LOAI_DON_VINull()
        {
            pm_objDR["ID_LOAI_DON_VI"] = System.Convert.DBNull;
        }

        public string strLOAI_DON_VI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LOAI_DON_VI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LOAI_DON_VI"] = value;
            }
        }

        public bool IsLOAI_DON_VINull()
        {
            return pm_objDR.IsNull("LOAI_DON_VI");
        }

        public void SetLOAI_DON_VINull()
        {
            pm_objDR["LOAI_DON_VI"] = System.Convert.DBNull;
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

        public bool IsID_DON_VI_CAP_TRENNull()
        {
            return pm_objDR.IsNull("ID_DON_VI_CAP_TREN");
        }

        public void SetID_DON_VI_CAP_TRENNull()
        {
            pm_objDR["ID_DON_VI_CAP_TREN"] = System.Convert.DBNull;
        }

        public string strDIA_BAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DIA_BAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DIA_BAN"] = value;
            }
        }

        public bool IsDIA_BANNull()
        {
            return pm_objDR.IsNull("DIA_BAN");
        }

        public void SetDIA_BANNull()
        {
            pm_objDR["DIA_BAN"] = System.Convert.DBNull;
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

        public decimal dcID_LOAI_CV
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_CV", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_CV"] = value;
            }
        }

        public bool IsID_LOAI_CVNull()
        {
            return pm_objDR.IsNull("ID_LOAI_CV");
        }

        public void SetID_LOAI_CVNull()
        {
            pm_objDR["ID_LOAI_CV"] = System.Convert.DBNull;
        }

        public string strLOAI_CV
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LOAI_CV", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LOAI_CV"] = value;
            }
        }

        public bool IsLOAI_CVNull()
        {
            return pm_objDR.IsNull("LOAI_CV");
        }

        public void SetLOAI_CVNull()
        {
            pm_objDR["LOAI_CV"] = System.Convert.DBNull;
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

        public decimal dcID_NHAN_SU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NHAN_SU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NHAN_SU"] = value;
            }
        }

        public bool IsID_NHAN_SUNull()
        {
            return pm_objDR.IsNull("ID_NHAN_SU");
        }

        public void SetID_NHAN_SUNull()
        {
            pm_objDR["ID_NHAN_SU"] = System.Convert.DBNull;
        }

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

        public decimal dcID_NGACH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGACH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGACH"] = value;
            }
        }

        public bool IsID_NGACHNull()
        {
            return pm_objDR.IsNull("ID_NGACH");
        }

        public void SetID_NGACHNull()
        {
            pm_objDR["ID_NGACH"] = System.Convert.DBNull;
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

        public bool IsID_DON_VINull()
        {
            return pm_objDR.IsNull("ID_DON_VI");
        }

        public void SetID_DON_VINull()
        {
            pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
        }

        public string strNGACH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGACH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGACH"] = value;
            }
        }

        public bool IsNGACHNull()
        {
            return pm_objDR.IsNull("NGACH");
        }

        public void SetNGACHNull()
        {
            pm_objDR["NGACH"] = System.Convert.DBNull;
        }

        public string strTRANG_THAI_CHUC_VU_YN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI_CHUC_VU_YN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRANG_THAI_CHUC_VU_YN"] = value;
            }
        }

        public bool IsTRANG_THAI_CHUC_VU_YNNull()
        {
            return pm_objDR.IsNull("TRANG_THAI_CHUC_VU_YN");
        }

        public void SetTRANG_THAI_CHUC_VU_YNNull()
        {
            pm_objDR["TRANG_THAI_CHUC_VU_YN"] = System.Convert.DBNull;
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

        public void SetTRANG_THAI_CVNull()
        {
            pm_objDR["TRANG_THAI_CV"] = System.Convert.DBNull;
        }

        public string strMA_QUYET_DINH_MIEN_NHIEM
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_QUYET_DINH_MIEN_NHIEM", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_QUYET_DINH_MIEN_NHIEM"] = value;
            }
        }

        public bool IsMA_QUYET_DINH_MIEN_NHIEMNull()
        {
            return pm_objDR.IsNull("MA_QUYET_DINH_MIEN_NHIEM");
        }

        public void SetMA_QUYET_DINH_MIEN_NHIEMNull()
        {
            pm_objDR["MA_QUYET_DINH_MIEN_NHIEM"] = System.Convert.DBNull;
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

        public decimal dcID_QUYET_DINH_MIEN_NHIEM
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_QUYET_DINH_MIEN_NHIEM", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_QUYET_DINH_MIEN_NHIEM"] = value;
            }
        }

        public bool IsID_QUYET_DINH_MIEN_NHIEMNull()
        {
            return pm_objDR.IsNull("ID_QUYET_DINH_MIEN_NHIEM");
        }

        public void SetID_QUYET_DINH_MIEN_NHIEMNull()
        {
            pm_objDR["ID_QUYET_DINH_MIEN_NHIEM"] = System.Convert.DBNull;
        }

        public string strLUA_CHON
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LUA_CHON", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LUA_CHON"] = value;
            }
        }

        public bool IsLUA_CHONNull()
        {
            return pm_objDR.IsNull("LUA_CHON");
        }

        public void SetLUA_CHONNull()
        {
            pm_objDR["LUA_CHON"] = System.Convert.DBNull;
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

        public bool IsTY_LE_THAM_GIANull()
        {
            return pm_objDR.IsNull("TY_LE_THAM_GIA");
        }

        public void SetTY_LE_THAM_GIANull()
        {
            pm_objDR["TY_LE_THAM_GIA"] = System.Convert.DBNull;
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

        public bool IsID_CHUC_VUNull()
        {
            return pm_objDR.IsNull("ID_CHUC_VU");
        }

        public void SetID_CHUC_VUNull()
        {
            pm_objDR["ID_CHUC_VU"] = System.Convert.DBNull;
        }

        public string strMA_DV_CAP_TREN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_DV_CAP_TREN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_DV_CAP_TREN"] = value;
            }
        }

        public bool IsMA_DV_CAP_TRENNull()
        {
            return pm_objDR.IsNull("MA_DV_CAP_TREN");
        }

        public void SetMA_DV_CAP_TRENNull()
        {
            pm_objDR["MA_DV_CAP_TREN"] = System.Convert.DBNull;
        }

        public string strTEN_DV_CAP_TREN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_DV_CAP_TREN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_DV_CAP_TREN"] = value;
            }
        }

        public bool IsTEN_DV_CAP_TRENNull()
        {
            return pm_objDR.IsNull("TEN_DV_CAP_TREN");
        }

        public void SetTEN_DV_CAP_TRENNull()
        {
            pm_objDR["TEN_DV_CAP_TREN"] = System.Convert.DBNull;
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

        public bool IsID_TRANG_LAO_DONGNull()
        {
            return pm_objDR.IsNull("ID_TRANG_LAO_DONG");
        }

        public void SetID_TRANG_LAO_DONGNull()
        {
            pm_objDR["ID_TRANG_LAO_DONG"] = System.Convert.DBNull;
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

        public void SetTRANG_THAI_HIEN_TAINull()
        {
            pm_objDR["TRANG_THAI_HIEN_TAI"] = System.Convert.DBNull;
        }

        public string strTRANG_THAI_LD_HIEN_TAI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI_LD_HIEN_TAI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRANG_THAI_LD_HIEN_TAI"] = value;
            }
        }

        public bool IsTRANG_THAI_LD_HIEN_TAINull()
        {
            return pm_objDR.IsNull("TRANG_THAI_LD_HIEN_TAI");
        }

        public void SetTRANG_THAI_LD_HIEN_TAINull()
        {
            pm_objDR["TRANG_THAI_LD_HIEN_TAI"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CO_HIEU_LUC_LD
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CO_HIEU_LUC_LD", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CO_HIEU_LUC_LD"] = value;
            }
        }

        public bool IsNGAY_CO_HIEU_LUC_LDNull()
        {
            return pm_objDR.IsNull("NGAY_CO_HIEU_LUC_LD");
        }

        public void SetNGAY_CO_HIEU_LUC_LDNull()
        {
            pm_objDR["NGAY_CO_HIEU_LUC_LD"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_HET_HIEU_LUC_LD
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_HET_HIEU_LUC_LD", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_HET_HIEU_LUC_LD"] = value;
            }
        }

        public bool IsNGAY_HET_HIEU_LUC_LDNull()
        {
            return pm_objDR.IsNull("NGAY_HET_HIEU_LUC_LD");
        }

        public void SetNGAY_HET_HIEU_LUC_LDNull()
        {
            pm_objDR["NGAY_HET_HIEU_LUC_LD"] = System.Convert.DBNull;
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

        public decimal dcID_PHAP_NHAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_PHAP_NHAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_PHAP_NHAN"] = value;
            }
        }

        public bool IsID_PHAP_NHANNull()
        {
            return pm_objDR.IsNull("ID_PHAP_NHAN");
        }

        public void SetID_PHAP_NHANNull()
        {
            pm_objDR["ID_PHAP_NHAN"] = System.Convert.DBNull;
        }

        public decimal dcID_PHAP_NHAN_QD
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_PHAP_NHAN_QD", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_PHAP_NHAN_QD"] = value;
            }
        }

        public bool IsID_PHAP_NHAN_QDNull()
        {
            return pm_objDR.IsNull("ID_PHAP_NHAN_QD");
        }

        public void SetID_PHAP_NHAN_QDNull()
        {
            pm_objDR["ID_PHAP_NHAN_QD"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_GD_QUA_TRINH_LAM_VIEC_2()
        {
            pm_objDS = new DS_V_GD_QUA_TRINH_LAM_VIEC_2();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_GD_QUA_TRINH_LAM_VIEC_2(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_GD_QUA_TRINH_LAM_VIEC_2(decimal i_dbID)
        {
            pm_objDS = new DS_V_GD_QUA_TRINH_LAM_VIEC_2();
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
        public void FillDatase_NhanSu_TheoPhongBan(DS_V_GD_QUA_TRINH_LAM_VIEC_2 op_ds, string ip_str_search, DateTime ip_dat_thoi_diem, decimal ip_dc_phap_nhan, decimal ip_dc_kiem_nhiem)
        {
            CStoredProc v_sp = new CStoredProc("pr_V_GD_QUA_TRINH_LAM_VIEC_2_Search_NhanVien_TheoPhongBanTaiMotThoiDiem");
            v_sp.addNVarcharInputParam("@ip_str_tim_kiem", ip_str_search);
            v_sp.addDecimalInputParam("@ip_dc_phap_nhan", ip_dc_phap_nhan);
            v_sp.addDatetimeInputParam("@ip_dat_thoi_diem", ip_dat_thoi_diem);
            v_sp.addDecimalInputParam("@ip_dc_kiem_nhiem", ip_dc_kiem_nhiem);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
        public void count_nhan_vien_theo_phong_ban(DS_V_GD_QUA_TRINH_LAM_VIEC_2 op_ds, string ip_str_search, DateTime ip_dat_thoi_diem, ref decimal op_count, decimal ip_dc_phap_nhan, decimal ip_dc_kiem_nhiem)
        {

            CStoredProc v_sp = new CStoredProc("pr_V_GD_QUA_TRINH_LAM_VIEC_2_Count_NhanVien_TheoPhongBanTaiMotThoiDiem");
            v_sp.addNVarcharInputParam("@ip_str_tim_kiem", ip_str_search);
            v_sp.addDatetimeInputParam("@ip_dat_thoi_diem", ip_dat_thoi_diem);
            v_sp.addDecimalInputParam("@ip_dc_phap_nhan", ip_dc_phap_nhan);
            v_sp.addDecimalInputParam("@ip_dc_kiem_nhiem", ip_dc_kiem_nhiem);
            SqlParameter v_sql = v_sp.addDecimalOutputParam("@count", op_count);
            v_sp.fillDataSetByCommand(this, op_ds);
            op_count = CIPConvert.ToDecimal(v_sql.Value.ToString());
        }
        public void count_nhan_vien_chinh_thuc(DS_V_GD_QUA_TRINH_LAM_VIEC_2 op_ds, DateTime ip_dat_thoi_diem, ref decimal op_count, decimal ip_dc_phap_nhan)
        {

            CStoredProc v_sp = new CStoredProc("pr_V_GD_QUA_TRINH_LAM_VIEC_2_Count_NhanVien_chinh_thuc_tren_6_thang");
            v_sp.addDatetimeInputParam("@ip_dat_thoi_diem", ip_dat_thoi_diem);
            v_sp.addDecimalInputParam("@ip_dc_phap_nhan", ip_dc_phap_nhan);
            SqlParameter v_sql = v_sp.addDecimalOutputParam("@count", op_count);
            v_sp.fillDataSetByCommand(this, op_ds);
            op_count = CIPConvert.ToDecimal(v_sql.Value.ToString());
        }
        public void FillDatasetSearchChucVuThoiDiem(DS_V_GD_QUA_TRINH_LAM_VIEC_2 op_ds,
                string ip_str_ma_cv,
                DateTime ip_dat_thoi_diem, decimal ip_dc_phap_nhan, decimal ip_dc_kiem_nhiem)
        {
            CStoredProc v_sp = new CStoredProc("pr_V_GD_QUA_TRINH_LAM_VIEC_2_select_by_MA_CHUC_VU_THOI_DIEM");
            v_sp.addNVarcharInputParam("@MA_CHUC_VU", ip_str_ma_cv);
            v_sp.addDatetimeInputParam("@THOI_DIEM", ip_dat_thoi_diem);
            v_sp.addDecimalInputParam("@ID_PHAP_NHAN", ip_dc_phap_nhan);
            v_sp.addDecimalInputParam("@ID_KIEM_NHIEM", ip_dc_kiem_nhiem);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
        public void count_nhan_vien_theo_chuc_vu(DS_V_GD_QUA_TRINH_LAM_VIEC_2 op_ds,
                string ip_str_ma_cv,
                DateTime ip_dat_thoi_diem, decimal ip_dc_phap_nhan
            , ref decimal op_dc_count, decimal ip_dc_kiem_nhiem)
        {
            CStoredProc v_sp = new CStoredProc("pr_V_GD_QUA_TRINH_LAM_VIEC_2_Count_MA_CHUC_VU_THOI_DIEM");
            v_sp.addNVarcharInputParam("@MA_CHUC_VU", ip_str_ma_cv);
            v_sp.addDatetimeInputParam("@THOI_DIEM", ip_dat_thoi_diem);
            v_sp.addDecimalInputParam("@ID_PHAP_NHAN", ip_dc_phap_nhan);
            v_sp.addDecimalInputParam("@ID_KIEM_NHIEM", ip_dc_kiem_nhiem);
            SqlParameter v_sql = v_sp.addDecimalOutputParam("@Count", op_dc_count);
            v_sp.fillDataSetByCommand(this, op_ds);
            op_dc_count = CIPConvert.ToDecimal(v_sql.Value);
        }
        #endregion
    }
}
