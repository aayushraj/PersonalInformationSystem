using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonalInformationSystem.Models;
using System.Data.Entity;

namespace PersonalInformationSystem.Providers
{
    public class ClassProvider
    {
        //public ClassModel GetList(StudentInfoModel model)
        //{
        //    ClassModel models = new ClassModel();
        //    PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();

            //ent.StudentInfoes.ToList();

            //model.StudentClassModelList = (from sc in ent.StudentClasses
            //                              where sc.DeletedOn == null
            //                              select new StudentInfoModel
            //                              {
            //                                  StudentClassId = sc.StudentId,
            //                                  FirstName = sc.FirstName,

            //                              }).ToList();
            ////return model;
            //return model;

        //}
        public int Save(ClassModel model)
        {

            //database initailization
            Class entityClass = new Class();
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();

            //var toSave = AutoMapper.Mapper.Map<StudentInfoModel, StudentInfo>(model);

            entityClass.ClassId = model.ClassId;
            entityClass.ClassName = model.ClassName;
           
            if (model.ClassId != 0 && model.ClassId > 0)
            {
                ent.Entry(entityClass).State = EntityState.Modified;
                entityClass.ModifiedBy = 1;
                entityClass.ModifiedOn = DateTime.Now;
            }

            else
            {
                ent.Classes.Add(entityClass);
                entityClass.CreatedBy = 1;
                entityClass.CreatedOn = DateTime.Now;
            }


            ent.SaveChanges();
            return 1;



        }
        public bool Delete(int classId)
        {
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();
            Class entityClass = ent.Classes.Where(x => x.ClassId == classId).FirstOrDefault();
            entityClass.DeletedOn = DateTime.Now;
            entityClass.DeletedBy = 1;
            ent.Entry(entityClass).State = EntityState.Modified;
            ent.SaveChanges();
            return true;
        }

    }
}