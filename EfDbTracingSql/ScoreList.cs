//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EfDbTracingSql
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScoreList
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Nullable<int> CSharp { get; set; }
        public Nullable<int> SQLServerDB { get; set; }
        public System.DateTime UpdateTime { get; set; }
    
        public virtual Students Students { get; set; }
    }
}
