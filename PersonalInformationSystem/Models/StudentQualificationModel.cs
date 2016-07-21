using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalInformationSystem.Models
{
    public class StudentQualificationModel
    {
        public int QualificationId { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public string Board { get; set; }
        public decimal Percentage { get; set; }
        public string PassedYear { get; set; }
        public bool Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public List<StudentQualificationModel> StudentQualificationModelList { get; set; }
    }
}