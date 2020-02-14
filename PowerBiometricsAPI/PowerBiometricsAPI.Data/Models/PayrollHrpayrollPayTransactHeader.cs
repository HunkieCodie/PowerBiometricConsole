using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollPayTransactHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string PayTypeId { get; set; }
        public double? Value { get; set; }
        public DateTime? Period { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public int TransId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string BranchCode { get; set; }
    }
}
