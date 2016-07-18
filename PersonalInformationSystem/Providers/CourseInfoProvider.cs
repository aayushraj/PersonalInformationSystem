using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonalInformationSystem.Models;

namespace PersonalInformationSystem.Providers
{
    public class CourseInfoProvider
    {
        public int Save(CourseInfoModel model)
        {
            CourseInfo entityCourseInfo = new CourseInfo();
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();

            entityCourseInfo.CourseId = model.CourseId;
            entityCourseInfo.CourseName = model.CourseName;
            entityCourseInfo.CourseDesc = model.CourseDesc;
            entityCourseInfo.CourseDuration = model.CourseDuration;
            entityCourseInfo.CourseAmount = model.CourseAmount;
            entityCourseInfo.Status = model.Status;

            return 1;
        }
    }
}