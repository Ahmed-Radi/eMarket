//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace emarket.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cart
    {
        public int product_Id { get; set; }
        public Nullable<System.DateTime> added_at { get; set; }
    
        public virtual product product { get; set; }
    }
}
