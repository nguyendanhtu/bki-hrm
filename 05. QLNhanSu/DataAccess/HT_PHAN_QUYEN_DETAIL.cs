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
    
    public partial class HT_PHAN_QUYEN_DETAIL
    {
        public decimal ID { get; set; }
        public string FORM_NAME { get; set; }
        public string CONTROL_NAME { get; set; }
        public string CONTROL_TYPE { get; set; }
        public string VISIBLE_YN { get; set; }
        public string ENABLED_YN { get; set; }
        public decimal ID_PHAN_QUYEN_HT { get; set; }
    
        public virtual HT_PHAN_QUYEN_HE_THONG HT_PHAN_QUYEN_HE_THONG { get; set; }
    }
}
