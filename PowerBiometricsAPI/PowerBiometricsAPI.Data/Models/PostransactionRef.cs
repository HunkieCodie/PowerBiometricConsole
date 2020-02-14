using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PostransactionRef
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CustomerId { get; set; }
        public string Reference { get; set; }
        public string ShiftId { get; set; }
        public string OrderNumber { get; set; }
        public string EmployeeId { get; set; }
        public string TerminalId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
