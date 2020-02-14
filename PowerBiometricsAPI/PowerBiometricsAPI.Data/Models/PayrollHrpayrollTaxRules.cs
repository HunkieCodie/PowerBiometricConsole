using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollTaxRules
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PayTypeId { get; set; }
        public double PercentApplied { get; set; }
        public double LowerLimit { get; set; }
        public double UpperLimit { get; set; }
        public string PayTypeIdbase { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
