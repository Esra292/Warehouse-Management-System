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
    
    public partial class Client
    {
        public Client()
        {
            this.Sale_Order = new HashSet<Sale_Order>();
        }
    
        public string C_Name { get; set; }
        public string Telephone { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string C_Site { get; set; }
    
        public virtual ICollection<Sale_Order> Sale_Order { get; set; }
    }
}