using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollTaxTable
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public int FiscalYear { get; set; }
        public string StateId { get; set; }
        public double BandWidth { get; set; }
        public double LowerLimit { get; set; }
        public double UpperLimit { get; set; }
        public double? TaxRate { get; set; }
        public double? FixedValue { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string CurrencyId { get; set; }
        public string BranchCode { get; set; }
    }
}
