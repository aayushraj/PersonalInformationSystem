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
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}