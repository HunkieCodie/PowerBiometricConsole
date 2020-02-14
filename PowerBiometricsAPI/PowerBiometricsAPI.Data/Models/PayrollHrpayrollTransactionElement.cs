using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollTransactionElement
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string PayTypeId { get; set; }
        public string AttrId { get; set; }
        public double? Value { get; set; }
        public bool? Taxable { get; set; }
        public string TaxGroupId { get; set; }
        public int? Period { get; set; }
        public bool? Porated { get; set; }
        public bool? OnPayroll { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? ActiveYn { get; set; }
        public string BasisId { get; set; }
        public string GlaccountNumber { get; set; }
        public double? ValueTaxable { get; set; }
        public double? ValueTaxableAdded { get; set; }
        public bool? Approved { get; set; }
        public string BranchCode { get; set; }
    }
}
