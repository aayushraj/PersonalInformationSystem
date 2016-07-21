using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonalInformationSystem.Models;

namespace PersonalInformationSystem.Models
{
    public class ParentModel
    {
        public string Headertext { get; set; }

        public StudentInfoModel ObjStudentInfoModel { get; set;}

        public CourseInfoModel ObjCourseInfoModel { get; set; }
        public PaymentModel ObjPaymentModel { get; set; }

    }
}