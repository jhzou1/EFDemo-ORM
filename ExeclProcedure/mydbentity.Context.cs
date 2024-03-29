﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExeclProcedure
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
    
        public virtual ObjectResult<usp_selectStu_Result> usp_selectStu(Nullable<int> classId)
        {
            var classIdParameter = classId.HasValue ?
                new ObjectParameter("ClassId", classId) :
                new ObjectParameter("ClassId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_selectStu_Result>("usp_selectStu", classIdParameter);
        }
    
        public virtual int usp_updateStu(string studentName, Nullable<int> studentId)
        {
            var studentNameParameter = studentName != null ?
                new ObjectParameter("StudentName", studentName) :
                new ObjectParameter("StudentName", typeof(string));
    
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_updateStu", studentNameParameter, studentIdParameter);
        }
    }
}
