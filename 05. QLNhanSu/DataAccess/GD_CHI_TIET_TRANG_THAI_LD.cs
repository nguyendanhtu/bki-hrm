//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class GD_CHI_TIET_TRANG_THAI_LD
    {
        public decimal ID { get; set; }
        public decimal ID_NHAN_SU { get; set; }
        public decimal ID_TRANG_LAO_DONG { get; set; }
        public Nullable<decimal> ID_QUYET_DINH { get; set; }
        public Nullable<System.DateTime> NGAY_CO_HIEU_LUC { get; set; }
        public Nullable<System.DateTime> NGAY_HET_HIEU_LUC { get; set; }
        public string TRANG_THAI_HIEN_TAI { get; set; }
    
        public virtual CM_DM_TU_DIEN CM_DM_TU_DIEN { get; set; }
        public virtual DM_NHAN_SU DM_NHAN_SU { get; set; }
        public virtual DM_QUYET_DINH DM_QUYET_DINH { get; set; }
    }
}
