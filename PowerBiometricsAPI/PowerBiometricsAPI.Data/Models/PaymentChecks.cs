using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PaymentChecks
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string PaymentId { get; set; }
        public string CheckNumber { get; set; }
        public string GlbankAccount { get; set; }
        public string VendorId { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyId { get; set; }
        public bool? Printed { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
