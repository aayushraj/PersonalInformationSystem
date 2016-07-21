using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalInformationSystem.Models
{
    public class StudentCourseDetailsModel
    {
        public int StudentCourseDetailsId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrolledDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public bool Status { get; set; }
        public List<StudentCourseDetailsModel> StudentCourseDetailsModelList { get; set; }
    }
}