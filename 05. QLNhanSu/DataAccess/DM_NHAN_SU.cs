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
    
    public partial class DM_NHAN_SU
    {
        public DM_NHAN_SU()
        {
            this.GD_CHI_TIET_CAP_BAC = new HashSet<GD_CHI_TIET_CAP_BAC>();
            this.GD_CHI_TIET_CHUC_VU = new HashSet<GD_CHI_TIET_CHUC_VU>();
            this.GD_CHI_TIET_DU_AN = new HashSet<GD_CHI_TIET_DU_AN>();
            this.GD_CHI_TIET_TRANG_THAI_LD = new HashSet<GD_CHI_TIET_TRANG_THAI_LD>();
            this.GD_CHI_TIET_TUYEN_DUNG = new HashSet<GD_CHI_TIET_TUYEN_DUNG>();
            this.GD_CONG_TAC = new HashSet<GD_CONG_TAC>();
            this.GD_HOP_DONG = new HashSet<GD_HOP_DONG>();
        }
    
        public decimal ID { get; set; }
        public string MA_NV { get; set; }
        public string HO_DEM { get; set; }
        public string TEN { get; set; }
        public string GIOI_TINH { get; set; }
        public Nullable<System.DateTime> NGAY_SINH { get; set; }
        public string NOI_SINH { get; set; }
        public string NGUYEN_QUAN { get; set; }
        public string ANH { get; set; }
        public string CMND { get; set; }
        public Nullable<System.DateTime> NGAY_CAP_CMND { get; set; }
        public string NOI_CAP_CMND { get; set; }
        public string TRINH_DO { get; set; }
        public string NOI_DAO_TAO { get; set; }
        public string CHUYEN_NGANH { get; set; }
        public Nullable<decimal> NAM_TOT_NGHIEP { get; set; }
        public string EMAIL_CQ { get; set; }
        public string EMAIL_CA_NHAN { get; set; }
        public string DT_NHA { get; set; }
        public string DI_DONG { get; set; }
        public string CHO_O { get; set; }
        public string HO_KHAU { get; set; }
        public string NGUOI_LIEN_HE { get; set; }
        public string DI_DONG_LIEN_HE { get; set; }
        public string QUAN_HE { get; set; }
        public string TON_GIAO { get; set; }
        public string DAN_TOC { get; set; }
        public string MA_SO_THUE { get; set; }
        public string TRANG_THAI { get; set; }
        public Nullable<decimal> ID_HEADCOUNT { get; set; }
        public string MA_HEADCOUNT { get; set; }
    
        public virtual DM_HEADCOUNT DM_HEADCOUNT { get; set; }
        public virtual ICollection<GD_CHI_TIET_CAP_BAC> GD_CHI_TIET_CAP_BAC { get; set; }
        public virtual ICollection<GD_CHI_TIET_CHUC_VU> GD_CHI_TIET_CHUC_VU { get; set; }
        public virtual ICollection<GD_CHI_TIET_DU_AN> GD_CHI_TIET_DU_AN { get; set; }
        public virtual ICollection<GD_CHI_TIET_TRANG_THAI_LD> GD_CHI_TIET_TRANG_THAI_LD { get; set; }
        public virtual ICollection<GD_CHI_TIET_TUYEN_DUNG> GD_CHI_TIET_TUYEN_DUNG { get; set; }
        public virtual ICollection<GD_CONG_TAC> GD_CONG_TAC { get; set; }
        public virtual ICollection<GD_HOP_DONG> GD_HOP_DONG { get; set; }
    }
}
