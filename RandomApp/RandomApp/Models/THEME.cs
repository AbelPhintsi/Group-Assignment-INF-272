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
    
    public partial class THEME
    {
        public int ThemeID { get; set; }
        public int SubjectID { get; set; }
        public string ThemeMode { get; set; }
    
        public virtual Subject Subject { get; set; }
        public virtual SUBJECT1 SUBJECT { get; set; }
    }
}
