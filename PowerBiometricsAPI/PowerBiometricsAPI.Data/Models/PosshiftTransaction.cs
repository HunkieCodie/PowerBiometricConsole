using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PosshiftTransaction
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ShiftId { get; set; }
        public string EmployeeId { get; set; }
        public string TerminalId { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerId { get; set; }
        public DateTime? TransDateTime { get; set; }
        public decimal? OrderAmount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Void { get; set; }
        public string Status { get; set; }
        public string BranchCode { get; set; }
    }
}
