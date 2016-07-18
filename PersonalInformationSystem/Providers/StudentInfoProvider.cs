using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PersonalInformationSystem.Models;

namespace PersonalInformationSystem.Providers
{
    public class StudentInfoProvider
    {

        public StudentInfoModel GetList(StudentInfoModel model)
        {
            StudentInfoModel models = new StudentInfoModel();
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();

            //ent.StudentInfoes.ToList();

            model.StudentInfoModelList = (from s in ent.StudentInfoes
                                          where s.DeletedOn == null
                                          select new StudentInfoModel
                                          {
                                              StudentId = s.StudentId,
                                              FirstName = s.FirstName,

                                          }).ToList();
            //return model;
            return model;

        }
        public int Save(StudentInfoModel model)
        {

            //database initailization
            StudentInfo entityStudentInfo = new StudentInfo();
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();

          //var toSave = AutoMapper.Mapper.Map<StudentInfoModel, StudentInfo>(model);

            entityStudentInfo.StudentId = model.StudentId;
            entityStudentInfo.FirstName = model.FirstName;
            entityStudentInfo.LastName = model.LastName;
            entityStudentInfo.MobileNo = model.MobileNo;
            entityStudentInfo.Address = model.Address;
            entityStudentInfo.City = model.City;
            entityStudentInfo.Country = model.Country;
            entityStudentInfo.Email = model.Email;
            entityStudentInfo.Gender = model.Gender;
            entityStudentInfo.EnrolledDate = DateTime.Now;
            entityStudentInfo.ComputerLiterate = model.ComputerLiterate;
            entityStudentInfo.Status = model.Status;

            entityStudentInfo.DeletedBy = model.DeletedBy;
            entityStudentInfo.DeletedOn = DateTime.Now;



            if (model.StudentId != 0 && model.StudentId > 0)
            {
                ent.Entry(entityStudentInfo).State = EntityState.Modified;
                entityStudentInfo.ModifiedBy = 1;
                entityStudentInfo.ModifiedOn = DateTime.Now;
            }

            else
            {
                ent.StudentInfoes.Add(entityStudentInfo);
                entityStudentInfo.CreatedBy = 1;
                entityStudentInfo.CreatedOn = DateTime.Now;
            }


            ent.SaveChanges();
            return 1;



        }
        public bool Delete(int studentInfoId)
        {
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();
            StudentInfo entityStudentInfo = ent.StudentInfoes.Where(x => x.StudentId == studentInfoId).FirstOrDefault();
            entityStudentInfo.DeletedOn = DateTime.Now;
            entityStudentInfo.DeletedBy = 1;
            ent.Entry(entityStudentInfo).State = EntityState.Modified;
            ent.SaveChanges();
            return true;
        }

    }
}