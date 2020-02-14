using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollShiftRosterHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ShiftRosterId { get; set; }
        public string ShiftRosterDescription { get; set; }
        public string ShiftType { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Closed { get; set; }
        public string ClosedBy { get; set; }
        public DateTime? ClosedTs { get; set; }
        public bool? CanNotDelete { get; set; }
        public string BranchCode { get; set; }
    }
}
