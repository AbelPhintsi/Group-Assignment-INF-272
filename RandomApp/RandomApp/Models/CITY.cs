//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RandomApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CITY()
        {
            this.INSTITUITIONs = new HashSet<INSTITUITION>();
        }
    
        public int CityID { get; set; }
        public int RegionID { get; set; }
        public string CityName { get; set; }
    
        public virtual REGION REGION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSTITUITION> INSTITUITIONs { get; set; }
    }
}
