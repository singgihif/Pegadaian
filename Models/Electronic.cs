//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPegadaian.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Electronic
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public Nullable<int> Years_Of_Buy { get; set; }
        public Nullable<decimal> Market_Price { get; set; }
        public string Condition { get; set; }
        public string Picture { get; set; }
        public int Transaction_id { get; set; }
        public string Type_Electronic { get; set; }
    
        public virtual Transaction Transaction { get; set; }
    }
}
