using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollInstantMessages
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string InstantMessageId { get; set; }
        public string InstantMessageText { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeEmail { get; set; }
        public DateTime? TimeSent { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
