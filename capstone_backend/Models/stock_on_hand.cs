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
    
    public partial class stock_on_hand
    {
        public int stockID { get; set; }
        public string stockNumber { get; set; }
        public string productname { get; set; }
        public Nullable<int> productquantity { get; set; }
        public Nullable<decimal> productprice { get; set; }
        public string productstatus { get; set; }
        public string productcreator { get; set; }
        public string productsupplier { get; set; }
        public string productimgurl { get; set; }
        public string productcategory { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<decimal> product_total { get; set; }
    }
}