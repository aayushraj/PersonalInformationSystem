using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PersonalInformationSystem.Models;

namespace PersonalInformationSystem.Providers
{
    public class StudentSubjectProvider
    { 
        public int Save(StudentSubjectModel model)
        {
            StudentSubject entityStudentSubject = new StudentSubject();
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();

            entityStudentSubject.SubjectId = model.SubjectId;
            entityStudentSubject.ClassId = model.ClassId;
            entityStudentSubject.SubjectName = model.SubjectName;
            entityStudentSubject.Status = model.Status;

            if(model.SubjectId!=0 && model.SubjectId > 0)
            {
                ent.Entry(entityStudentSubject).State = EntityState.Modified;
                entityStudentSubject.ModifiedBy = 1;
                entityStudentSubject.ModifiedOn = DateTime.Now;
            }
            else
            {
                ent.Entry(entityStudentSubject).State = EntityState.Added;
                entityStudentSubject.CreatedBy = 1;
                entityStudentSubject.CreatedOn = DateTime.Now;
            }
            ent.SaveChanges();
            return 1;
        }
        public bool Delete(int studentReferenceId)
        {
            
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();
            StudentReference entityStudentReference = ent.StudentReferences.Where(x => x.ReferenceId == studentReferenceId).FirstOrDefault();
            entityStudentReference.DeletedBy = 1;
            entityStudentReference.DeletedOn = DateTime.Now;
            ent.Entry(entityStudentReference).State = EntityState.Modified;
            ent.SaveChanges();
            return true;
        }
    }
}