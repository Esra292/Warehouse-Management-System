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
    
    public partial class Class
    {
        public Class()
        {
            this.Class_Has_Sale_Order = new HashSet<Class_Has_Sale_Order>();
            this.Class_Has_Release_Order = new HashSet<Class_Has_Release_Order>();
            this.Class_Measure_Unit = new HashSet<Class_Measure_Unit>();
            this.Stores = new HashSet<Store>();
        }
    
        public string Code { get; set; }
        public string C_Name { get; set; }
    
        public virtual ICollection<Class_Has_Sale_Order> Class_Has_Sale_Order { get; set; }
        public virtual ICollection<Class_Has_Release_Order> Class_Has_Release_Order { get; set; }
        public virtual ICollection<Class_Measure_Unit> Class_Measure_Unit { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
