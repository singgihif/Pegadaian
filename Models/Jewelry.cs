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
    
    public partial class Jewelry
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public Nullable<double> Weight { get; set; }
        public string Picture { get; set; }
        public int Transaction_Id { get; set; }
        public int Gold_Id { get; set; }
    
        public virtual Gold Gold { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
