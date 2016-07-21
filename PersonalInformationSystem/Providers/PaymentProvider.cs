using System;
using System.Linq;
using PersonalInformationSystem.Models;
using System.Data.Entity;


namespace PersonalInformationSystem.Providers
{
    public class PaymentProvider
    {
        //public PaymentModel GetList(PaymentModel model)
        //{
        //    PaymentModel models = new PaymentModel();
        //    PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();

        //    model.PaymentModelList = (from p in ent.Payments
        //                              where p.DeletedOn == null
        //                              select new PaymentModel
        //                              {
        //                                  PaymentId = p.PaymentId,
        //                                  PaymentType = p.PaymentType,
        //                                  PaidAmount = p.PaidAmount.ToDecimal,
        //                                  DueAmount = p.DueAmount,
        //                                  PaidBy = p.PaidBy,
        //                                  ReceivedBy = p.ReceivedBy,
        //                                  Remarks = p.Remarks,
        //                                  CreatedBy = p.CreatedBy,
        //                                  CreatedOn = p.CreatedOn,
        //                                  ModifiedBy = p.ModifiedBy,
        //                                  ModifiedOn = p.Modifiedon,
        //                                  DeletedBy = p.DeletedBy,
        //                                  DeletedOn = p.DeletedOn
        //                              }).ToList();
        //    return model;
        //}


        public int Save(PaymentModel model)
        {

            Payment entityPayment = new Payment();
            PersonalInformationSystemEntities ent = new PersonalInformationSystemEntities();

            entityPayment.PaymentId = model.PaymentId;
            entityPayment.StudentId = model.StudentId;
            entityPayment.PaymentType = model.PaymentType;
            entityPayment.PaidAmount = model.PaidAmount;
            entityPayment.DueAmount = model.DueAmount;
            entityPayment.PaidBy = model.PaidBy;
            entityPayment.ReceivedBy = model.ReceivedBy;
            entityPayment.Remarks = model.Remarks;

            entityPayment.DeletedBy = model.DeletedBy;
            entityPayment.DeletedOn = DateTime.Now;

            if (model.PaymentId != 0 && model.PaymentId >0)
            {
                ent.Entry(entityPayment).State = EntityState.Modified;
                entityPayment.ModifiedBy = 1;
                entityPayment.Modifiedon = DateTime.Now;
            }
            else
            {
                ent.Payments.Add(entityPayment);
                entityPayment.CreatedOn = DateTime.Now;
                entityPayment.CreatedBy = 1;
            }
            ent.SaveChanges();


            return 1;

        }
      
    }
}