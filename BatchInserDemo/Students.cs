//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BatchInserDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Students()
        {
            this.ScoreList = new HashSet<ScoreList>();
        }
    
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public System.DateTime Birthday { get; set; }
        public decimal StudentIdNo { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string StudentAddress { get; set; }
        public int ClassId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScoreList> ScoreList { get; set; }
        public virtual StudentClass StudentClass { get; set; }
    }
}
