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
    
    public partial class forgotpassword_identifier
    {
        public int id { get; set; }
        public string forgotcode { get; set; }
        public string isdone { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
    }
}
