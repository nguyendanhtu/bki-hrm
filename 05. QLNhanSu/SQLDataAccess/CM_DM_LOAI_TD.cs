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
    
    public partial class CM_DM_LOAI_TD
    {
        public CM_DM_LOAI_TD()
        {
            this.CM_DM_TU_DIEN = new HashSet<CM_DM_TU_DIEN>();
        }
    
        public decimal ID { get; set; }
        public string MA_LOAI { get; set; }
        public string TEN_LOAI { get; set; }
    
        public virtual ICollection<CM_DM_TU_DIEN> CM_DM_TU_DIEN { get; set; }
    }
}
