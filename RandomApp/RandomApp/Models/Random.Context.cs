﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RandomEntities : DbContext
    {
        public RandomEntities()
            : base("name=RandomEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMINISTRATOR> ADMINISTRATORs { get; set; }
        public virtual DbSet<CITY> CITies { get; set; }
        public virtual DbSet<COUNTRY> COUNTRies { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENTs { get; set; }
        public virtual DbSet<GRADE> GRADEs { get; set; }
        public virtual DbSet<INSTITUITION> INSTITUITIONs { get; set; }
        public virtual DbSet<LEVEL> LEVELs { get; set; }
        public virtual DbSet<REGION> REGIONs { get; set; }
        public virtual DbSet<STUDENT> STUDENTs { get; set; }
        public virtual DbSet<STUDENTSUBJECT> STUDENTSUBJECTs { get; set; }
        public virtual DbSet<SUBJECTFACT> SUBJECTFACTs { get; set; }
        public virtual DbSet<TEST> TESTs { get; set; }
        public virtual DbSet<TestStudent> TestStudents { get; set; }
        public virtual DbSet<THEME> THEMEs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
    }
}
