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
    
    public partial class Transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaction()
        {
            this.Electronics = new HashSet<Electronic>();
            this.Gold_Saving = new HashSet<Gold_Saving>();
            this.Handphones = new HashSet<Handphone>();
            this.Installments = new HashSet<Installment>();
            this.Jewelries = new HashSet<Jewelry>();
            this.Precious_Metal = new HashSet<Precious_Metal>();
            this.Type_Business_Financing = new HashSet<Type_Business_Financing>();
            this.Type_Laptop = new HashSet<Type_Laptop>();
            this.Type_Vehicle = new HashSet<Type_Vehicle>();
        }
    
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public int Installment_Type_Id { get; set; }
        public int Outlet_Id { get; set; }
        public byte[] Transaction_Date { get; set; }
        public decimal Administrative_Cost { get; set; }
        public Nullable<decimal> Loan_Amount { get; set; }
        public Nullable<System.DateTime> Approved_Date { get; set; }
        public string Approved_Status { get; set; }
        public Nullable<System.DateTime> Accepted_Date { get; set; }
        public string Accepted_Status { get; set; }
        public Nullable<decimal> Remaining_Amount { get; set; }
        public int User_Create { get; set; }
        public int Cust_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Electronic> Electronics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gold_Saving> Gold_Saving { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Handphone> Handphones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Installment> Installments { get; set; }
        public virtual Installment_type Installment_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jewelry> Jewelries { get; set; }
        public virtual Outlet Outlet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Precious_Metal> Precious_Metal { get; set; }
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Type_Business_Financing> Type_Business_Financing { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Type_Laptop> Type_Laptop { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Type_Vehicle> Type_Vehicle { get; set; }
    }
}
