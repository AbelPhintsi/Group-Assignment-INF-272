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
    
    public partial class SUBJECTFACT
    {
        public int SubjectFactID { get; set; }
        public int SubjectID { get; set; }
        public string SubjectFactDescription { get; set; }
        public string HistoryFact { get; set; }
        public string GeneralFact { get; set; }
    
        public virtual STUDENTSUBJECT STUDENTSUBJECT { get; set; }
    }
}
