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
    
    public partial class HT_CONTROLLER
    {
        public HT_CONTROLLER()
        {
            this.HT_PHAN_QUYEN_CHUC_NANG = new HashSet<HT_PHAN_QUYEN_CHUC_NANG>();
        }
    
        public System.Guid ID { get; set; }
        public string CONTROLLER_NAME { get; set; }
        public string ACTIVITY_NAME { get; set; }
    
        public virtual ICollection<HT_PHAN_QUYEN_CHUC_NANG> HT_PHAN_QUYEN_CHUC_NANG { get; set; }
    }
}
