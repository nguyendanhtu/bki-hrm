//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GD_QUYET_DINH_DU_AN
    {
        public decimal ID { get; set; }
        public decimal ID_DU_AN { get; set; }
        public decimal ID_QUYET_DINH { get; set; }
    
        public virtual DM_DU_AN DM_DU_AN { get; set; }
        public virtual DM_QUYET_DINH DM_QUYET_DINH { get; set; }
    }
}
