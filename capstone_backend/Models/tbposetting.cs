//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace capstone_backend.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbposetting
    {
        public int id { get; set; }
        public string enablePO { get; set; }
        public string enablePOInventory { get; set; }
        public string enableListview { get; set; }
        public string viewentry { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
    }
}