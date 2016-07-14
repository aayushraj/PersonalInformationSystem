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
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}