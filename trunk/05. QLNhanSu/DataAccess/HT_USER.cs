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
    
    public partial class HT_USER
    {
        public System.Guid ID { get; set; }
        public string BHYT { get; set; }
        public string CMND { get; set; }
        public string MSBN { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string HO { get; set; }
        public string TEN { get; set; }
        public bool IS_ACTIVE { get; set; }
        public System.Guid ID_USER_GROUP { get; set; }
    
        public virtual HT_USER_GROUP_WEB HT_USER_GROUP_WEB { get; set; }
    }
}
