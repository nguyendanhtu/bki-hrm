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
    
    public partial class DM_QUYET_DINH
    {
        public DM_QUYET_DINH()
        {
            this.GD_CHI_TIET_CAP_BAC = new HashSet<GD_CHI_TIET_CAP_BAC>();
            this.GD_CHI_TIET_CHUC_VU = new HashSet<GD_CHI_TIET_CHUC_VU>();
            this.GD_CHI_TIET_DU_AN = new HashSet<GD_CHI_TIET_DU_AN>();
            this.GD_CHI_TIET_TRANG_THAI_LD = new HashSet<GD_CHI_TIET_TRANG_THAI_LD>();
            this.GD_CONG_TAC = new HashSet<GD_CONG_TAC>();
            this.GD_QUYET_DINH_DU_AN = new HashSet<GD_QUYET_DINH_DU_AN>();
            this.GD_QUYET_DINH_PHAP_NHAN = new HashSet<GD_QUYET_DINH_PHAP_NHAN>();
        }
    
        public decimal ID { get; set; }
        public string MA_QUYET_DINH { get; set; }
        public decimal ID_LOAI_QD { get; set; }
        public Nullable<System.DateTime> NGAY_CO_HIEU_LUC { get; set; }
        public Nullable<System.DateTime> NGAY_KY { get; set; }
        public Nullable<System.DateTime> NGAY_HET_HIEU_LUC { get; set; }
        public string NOI_DUNG { get; set; }
        public string LINK { get; set; }
    
        public virtual CM_DM_TU_DIEN CM_DM_TU_DIEN { get; set; }
        public virtual ICollection<GD_CHI_TIET_CAP_BAC> GD_CHI_TIET_CAP_BAC { get; set; }
        public virtual ICollection<GD_CHI_TIET_CHUC_VU> GD_CHI_TIET_CHUC_VU { get; set; }
        public virtual ICollection<GD_CHI_TIET_DU_AN> GD_CHI_TIET_DU_AN { get; set; }
        public virtual ICollection<GD_CHI_TIET_TRANG_THAI_LD> GD_CHI_TIET_TRANG_THAI_LD { get; set; }
        public virtual ICollection<GD_CONG_TAC> GD_CONG_TAC { get; set; }
        public virtual ICollection<GD_QUYET_DINH_DU_AN> GD_QUYET_DINH_DU_AN { get; set; }
        public virtual ICollection<GD_QUYET_DINH_PHAP_NHAN> GD_QUYET_DINH_PHAP_NHAN { get; set; }
    }
}