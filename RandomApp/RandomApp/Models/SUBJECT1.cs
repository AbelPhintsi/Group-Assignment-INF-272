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
    
    public partial class SUBJECT1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUBJECT1()
        {
            this.DEPARTMENTs = new HashSet<DEPARTMENT>();
            this.SUBJECTFACTs = new HashSet<SUBJECTFACT>();
            this.TESTs = new HashSet<TEST>();
            this.THEMEs = new HashSet<THEME>();
        }
    
        public int SubjectID { get; set; }
        public int GradeID { get; set; }
        public string SubjectName { get; set; }
        public string SubjectDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPARTMENT> DEPARTMENTs { get; set; }
        public virtual GRADE1 GRADE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUBJECTFACT> SUBJECTFACTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEST> TESTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THEME> THEMEs { get; set; }
    }
}
