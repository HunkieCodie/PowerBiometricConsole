using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollPayType
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PayTypeId { get; set; }
        public string PayTypeDescription { get; set; }
        public string GlaccountNumber { get; set; }
        public string AttrDescription { get; set; }
        public string OperatorId { get; set; }
        public double ConversionFactor { get; set; }
        public string TotalAmount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string StatusId { get; set; }
        public bool? PayTypeDefault { get; set; }
        public double? EmployeePercent { get; set; }
        public bool? Zerorise { get; set; }
        public int? SortOrder { get; set; }
        public bool? Accrued { get; set; }
        public double? EmployerPercent { get; set; }
        public string PayTypeGlaccountNumber { get; set; }
        public bool? Taxable { get; set; }
        public string GlaccountNumber1 { get; set; }
        public bool? Prorate { get; set; }
        public bool? IgnoreHourlyRate { get; set; }
        public bool? BillingItem { get; set; }
        public bool? ShowBalanceOnSlip { get; set; }
        public string BranchCode { get; set; }
    }
}
