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
    
    public partial class Installment
    {
        public int Id { get; set; }
        public System.DateTime Installment_Date { get; set; }
        public Nullable<System.DateTime> Due_Date { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Installment_Amount { get; set; }
        public int Transaction_Id { get; set; }
    
        public virtual Transaction Transaction { get; set; }
    }
}