//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IDSP7_pw
{
    using System;
    using System.Collections.Generic;
    
    public partial class inventory
    {
        public int itemID { get; set; }
        public int siteID { get; set; }
        public int quantity { get; set; }
        public string itemLocation { get; set; }
        public Nullable<int> reorderThreshold { get; set; }
        public int maxReorderWarning { get; set; }
    }
}
