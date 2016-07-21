using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PersonalInformationSystem.Models;

namespace PersonalInformationSystem.Providers
{
    public class StudentCourseDetailsProvider
    {
        public int Save(StudentCourseDetailsModel model)
        {

            //database initailization
            StudentCourseDetail entityStudentCourseDetail = new StudentCourseDetail();
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();

            //var toSave = AutoMapper.Mapper.Map<StudentInfoModel, StudentInfo>(model);

            entityStudentCourseDetail.StudentCourseDetailsId = model.StudentCourseDetailsId;
            entityStudentCourseDetail.CourseId = model.CourseId;
            entityStudentCourseDetail.StudentId = model.StudentId;
            entityStudentCourseDetail.EnrolledDate = model.EnrolledDate;
            entityStudentCourseDetail.Status = model.Status;
           
            if (model.StudentCourseDetailsId != 0 && model.StudentCourseDetailsId > 0)
            {
                ent.Entry(entityStudentCourseDetail).State = EntityState.Modified;
                entityStudentCourseDetail.ModifiedBy = 1;
                entityStudentCourseDetail.ModifiedOn = DateTime.Now;
            }

            else
            {
                ent.StudentCourseDetails.Add(entityStudentCourseDetail);
                entityStudentCourseDetail.CreatedBy = 1;
                entityStudentCourseDetail.CreatedOn = DateTime.Now;
            }


            ent.SaveChanges();
            return 1;



        }
        public bool Delete(int studentCourseDetailId)
        {
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();
            StudentCourseDetail entityStudentCourseDetail = ent.StudentCourseDetails.Where(x => x.StudentCourseDetailsId == studentCourseDetailId).FirstOrDefault();
            entityStudentCourseDetail.DeletedOn = DateTime.Now;
            entityStudentCourseDetail.DeletedBy = 1;
            ent.Entry(entityStudentCourseDetail).State = EntityState.Modified;
            ent.SaveChanges();
            return true;
        }

    }
}