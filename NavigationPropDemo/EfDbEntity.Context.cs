﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NavigationPropDemo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EFDBEntities : DbContext
    {
        public EFDBEntities()
            : base("name=EFDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<ScoreList> ScoreList { get; set; }
        public virtual DbSet<StudentClass> StudentClass { get; set; }
        public virtual DbSet<Students> Students { get; set; }
    }
}