using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PersonalInformationSystem.Models;

namespace PersonalInformationSystem.Providers
{
    public class StudentReferenceProvider
    {
        public int Save(StudentReferenceModel model)
        {
            StudentReference entityStudentReference = new StudentReference();
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();

            entityStudentReference.ReferenceId = model.ReferenceId;
            entityStudentReference.StudentId = model.StudentId;
            entityStudentReference.ReferenceThrough = model.ReferenceThrough;
            entityStudentReference.Status = model.Status;

            if(model.ReferenceId!=0 && model.ReferenceId>0)
            {
                ent.Entry(entityStudentReference).State = EntityState.Modified;
                entityStudentReference.ModifiedBy = 1;
                entityStudentReference.ModifiedOn = DateTime.Now;
            }
            else
            {
                ent.Entry(entityStudentReference).State = EntityState.Added;
                entityStudentReference.CreatedBy = 1;
                entityStudentReference.CreatedOn = DateTime.Now;

            }
            ent.SaveChanges();
            return 1;
        }

        public bool Delete(int studentReferenceId)
        {

            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();
            StudentReference entityStudentReference = ent.StudentReferences.Where(x => x.ReferenceId == studentReferenceId).FirstOrDefault();
            entityStudentReference.DeletedOn = DateTime.Now;
            entityStudentReference.DeletedBy = 1;
            ent.Entry(entityStudentReference).State = EntityState.Modified;
            ent.SaveChanges();

            return true;
        }
    }
}