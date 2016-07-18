using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalInformationSystem.Models
{
    public class StudentClassModel
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }       
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public bool Status { get; set; }
    }
}