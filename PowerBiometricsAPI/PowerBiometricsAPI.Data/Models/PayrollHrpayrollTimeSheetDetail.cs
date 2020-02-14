using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollTimeSheetDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string PayTypeId { get; set; }
        public double? Rate { get; set; }
        public double? Units { get; set; }
        public decimal? Amount { get; set; }
        public double? TaxAmount { get; set; }
        public string TaxGroupId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? OnPayroll { get; set; }
        public bool? ActiveYn { get; set; }
        public bool? Taxable { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? Cleared { get; set; }
        public string ClearedBy { get; set; }
        public DateTime? ClearedDate { get; set; }
        public double? ValueTaxable { get; set; }
        public double? ValueTaxableAdded { get; set; }
        public string BranchCode { get; set; }
    }
}
