using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollFedTaxTables
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string Country { get; set; }
        public string WithholdingStatus { get; set; }
        public string StatusType { get; set; }
        public float TaxBracket { get; set; }
        public decimal? OverAmnt { get; set; }
        public decimal? NotOver { get; set; }
        public decimal? Cumulative { get; set; }
        public int? PayrollYear { get; set; }
        public string PayFrequency { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
