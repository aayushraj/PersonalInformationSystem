using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PersonalInformationSystem.Models;

namespace PersonalInformationSystem.Models
{
    public class StudentInfoModel
    {
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string ResidenceNo { get; set; }
        public DateTime EnrolledDate { get; set; }
        public bool ComputerLiterate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public bool Status { get; set; }
        public List<StudentInfoModel> StudentInfoModelList { get; set; }
        public CourseInfoModel ObjCourseInfoModel { get; set; }
        public PaymentModel ObjPaymentModel { get; set; }

    }
}