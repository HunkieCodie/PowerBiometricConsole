using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollPayFile
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string PayTypeId { get; set; }
        public string PayTypeDescription { get; set; }
        public string AttrId { get; set; }
        public DateTime? TranDate { get; set; }
        public double? Amount { get; set; }
        public bool? ActiveYn { get; set; }
        public bool? Taxable { get; set; }
        public bool? Porate { get; set; }
        public double? PayTypeBalance { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? OnPayroll { get; set; }
        public double? Rate { get; set; }
        public double? Units { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string BranchCode { get; set; }
    }
}
