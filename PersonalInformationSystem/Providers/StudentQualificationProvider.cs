using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PersonalInformationSystem.Models;

namespace PersonalInformationSystem.Providers
{
    public class StudentQualificationProvider
    {
        public int Save(StudentQualificationModel model)
        {

            //database initailization
            StudentQualification entityStudentQualification = new StudentQualification();
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();

            //var toSave = AutoMapper.Mapper.Map<StudentInfoModel, StudentInfo>(model);

            entityStudentQualification.QualificationId = model.QualificationId;
            entityStudentQualification.ClassId = model.ClassId;
            entityStudentQualification.SubjectId = model.SubjectId;
            entityStudentQualification.StudentId = model.StudentId;
            entityStudentQualification.Board = model.Board;
            entityStudentQualification.Percentage = model.Percentage;
            entityStudentQualification.PassedYear = model.PassedYear;
            entityStudentQualification.Status = model.Status;



            if (model.QualificationId != 0 && model.QualificationId > 0)
            {
                ent.Entry(entityStudentQualification).State = EntityState.Modified;
                entityStudentQualification.ModifiedBy = 1;
                entityStudentQualification.ModifiedOn = DateTime.Now;
            }

            else
            {
                ent.StudentQualifications.Add(entityStudentQualification);
                entityStudentQualification.CreatedBy = 1;
                entityStudentQualification.CreatedOn = DateTime.Now;
            }


            ent.SaveChanges();
            return 1;



        }
        public bool Delete(int studentQualificationId)
        {
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();
            StudentQualification entityStudentQualification = ent.StudentQualifications.Where(x => x.QualificationId == studentQualificationId).FirstOrDefault();
            entityStudentQualification.DeletedOn = DateTime.Now;
            entityStudentQualification.DeletedBy = 1;
            ent.Entry(entityStudentQualification).State = EntityState.Modified;
            ent.SaveChanges();
            return true;
        }

    }
}