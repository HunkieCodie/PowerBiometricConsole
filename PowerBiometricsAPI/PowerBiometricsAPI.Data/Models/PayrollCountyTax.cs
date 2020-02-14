using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollCountyTax
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string StateName { get; set; }
        public string CountyName { get; set; }
        public float? CountyRate { get; set; }
        public float? CountyWageBase { get; set; }
        public float? CountyUiirate { get; set; }
        public float? CountyUiwageBase { get; set; }
        public float? CountyOtherRate { get; set; }
        public float? CountyOtherWageBase { get; set; }
        public decimal? StandardDeductSingle { get; set; }
        public decimal? StandardDeductJoint { get; set; }
        public decimal? Exemption { get; set; }
        public decimal? Dependents { get; set; }
        public string Notes { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
