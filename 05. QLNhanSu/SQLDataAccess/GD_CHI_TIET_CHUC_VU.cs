//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class GD_CHI_TIET_CHUC_VU
    {
        public decimal ID { get; set; }
        public decimal ID_NHAN_SU { get; set; }
        public decimal ID_CHUC_VU { get; set; }
        public decimal ID_DON_VI { get; set; }
        public Nullable<decimal> ID_QUYET_DINH { get; set; }
        public Nullable<decimal> ID_QUYET_DINH_MIEN_NHIEM { get; set; }
        public Nullable<decimal> ID_LOAI_CV { get; set; }
        public string TRANG_THAI_CV { get; set; }
        public Nullable<decimal> TY_LE_THAM_GIA { get; set; }
        public Nullable<System.DateTime> NGAY_BAT_DAU { get; set; }
        public Nullable<System.DateTime> NGAY_KET_THUC { get; set; }
        public string LUA_CHON { get; set; }
    
        public virtual CM_DM_TU_DIEN CM_DM_TU_DIEN { get; set; }
        public virtual DM_CHUC_VU DM_CHUC_VU { get; set; }
        public virtual DM_DON_VI DM_DON_VI { get; set; }
        public virtual DM_NHAN_SU DM_NHAN_SU { get; set; }
        public virtual DM_QUYET_DINH DM_QUYET_DINH { get; set; }
    }
}
