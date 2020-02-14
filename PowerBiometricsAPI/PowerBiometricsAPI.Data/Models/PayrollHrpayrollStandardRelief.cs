using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollStandardRelief
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public int FiscalYear { get; set; }
        public double ReliefRate { get; set; }
        public double? PersonalAllowance { get; set; }
        public double? DisabilityAllowance { get; set; }
        public double? ChildAllowance { get; set; }
        public double? DependentAllowance { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? MinimumTaxAmount { get; set; }
        public double? TaxGrossPercent { get; set; }
        public bool? AllStaffRelief { get; set; }
        public string BranchCode { get; set; }
    }
}
