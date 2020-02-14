using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmailMessages
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmailMessageId { get; set; }
        public string Body { get; set; }
        public string Sender { get; set; }
        public string Ccto { get; set; }
        public string Subject { get; set; }
        public short? Priority { get; set; }
        public DateTime? TimeSent { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
