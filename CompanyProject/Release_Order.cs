//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Release_Order
    {
        public Release_Order()
        {
            this.Class_Has_Release_Order = new HashSet<Class_Has_Release_Order>();
        }
    
        public long Num { get; set; }
        public string Store_Name { get; set; }
        public Nullable<System.DateTime> C_Date { get; set; }
        public string Supplier_Fax { get; set; }
    
        public virtual ICollection<Class_Has_Release_Order> Class_Has_Release_Order { get; set; }
        public virtual Store Store { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
