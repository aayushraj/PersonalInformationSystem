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
    
    public partial class StudentClass
    {
        public StudentClass()
        {
            this.StudentQualifications = new HashSet<StudentQualification>();
            this.StudentSubjects = new HashSet<StudentSubject>();
        }
    
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
    
        public virtual ICollection<StudentQualification> StudentQualifications { get; set; }
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
