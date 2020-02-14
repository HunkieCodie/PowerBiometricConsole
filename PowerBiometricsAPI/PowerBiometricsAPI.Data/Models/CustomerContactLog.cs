using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerContactLog
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CustomerId { get; set; }
        public string ContactId { get; set; }
        public string ContactLogId { get; set; }
        public DateTime? ContactDate { get; set; }
        public DateTime? ContactCallStartTime { get; set; }
        public DateTime? ContactCallEndTime { get; set; }
        public string ContactDesctiption { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
