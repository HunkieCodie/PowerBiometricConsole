using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollPeriod
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public DateTime Period { get; set; }
        public string Description { get; set; }
        public string GeneratedBy { get; set; }
        public bool? Generated { get; set; }
        public DateTime? GeneratedDate { get; set; }
        public string AuditedBy { get; set; }
        public bool? Audited { get; set; }
        public DateTime? AuditedDate { get; set; }
        public string ApprovedBy { get; set; }
        public bool? Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string AuditComment { get; set; }
        public double? TotalGrossPay { get; set; }
        public double? TotalGrossDeduction { get; set; }
        public double? TotalNetPay { get; set; }
        public string BranchCode { get; set; }
    }
}
