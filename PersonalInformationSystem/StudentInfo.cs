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
    
    public partial class StudentInfo
    {
        public StudentInfo()
        {
            this.Payments = new HashSet<Payment>();
            this.StudentCourseDetails = new HashSet<StudentCourseDetail>();
            this.StudentQualifications = new HashSet<StudentQualification>();
            this.StudentReferences = new HashSet<StudentReference>();
        }
    
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Nullable<int> Gender { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public Nullable<System.DateTime> EnrolledDate { get; set; }
        public Nullable<bool> ComputerLiterate { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<StudentCourseDetail> StudentCourseDetails { get; set; }
        public virtual ICollection<StudentQualification> StudentQualifications { get; set; }
        public virtual ICollection<StudentReference> StudentReferences { get; set; }
    }
}
