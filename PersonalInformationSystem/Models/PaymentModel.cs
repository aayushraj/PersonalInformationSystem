using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalInformationSystem.Models
{
    public class PaymentModel
    {
        public int PaymentId { get; set; }
        public int StudentId { get; set; }
        public string PaymentType { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal DueAmount { get; set; }
        public string PaidBy { get; set; }
        public string ReceivedBy { get; set; }
        public string Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public bool Status { get; set; }
    }
}