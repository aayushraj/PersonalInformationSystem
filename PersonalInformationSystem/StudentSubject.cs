//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalInformationSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentSubject
    {
        public StudentSubject()
        {
            this.StudentQualifications = new HashSet<StudentQualification>();
        }
    
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
        public string SubjectName { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
    
        public virtual StudentClass StudentClass { get; set; }
        public virtual ICollection<StudentQualification> StudentQualifications { get; set; }
    }
}
