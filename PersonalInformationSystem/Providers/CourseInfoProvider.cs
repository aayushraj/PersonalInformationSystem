using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonalInformationSystem.Models;
using System.Data.Entity;

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

            if(model.CourseId!=0 && model.CourseId > 0)
            {
                ent.Entry(entityCourseInfo).State = EntityState.Modified;
                entityCourseInfo.ModifiedBy = 1;
                entityCourseInfo.ModifiedOn = DateTime.Now;
            }
            else
            {
                ent.Entry(entityCourseInfo).State = EntityState.Added;
                entityCourseInfo.CreatedBy = 1;
                entityCourseInfo.CreatedOn = DateTime.Now;
            }
            ent.SaveChanges();
            return 1;
        }
        public bool Delete(int courseinfoId)
        {
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();
            CourseInfo entityCourseInfo = ent.CourseInfoes.Where(x => x.CourseId == courseinfoId).FirstOrDefault();
            entityCourseInfo.DeletedBy = 1;
            entityCourseInfo.DeletedOn = DateTime.Now;
            ent.Entry(entityCourseInfo).State = EntityState.Modified;
            ent.SaveChanges();
            return true;
        }
    }
}