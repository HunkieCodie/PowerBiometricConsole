using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollFedTax
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string Country { get; set; }
        public float? Fitrate { get; set; }
        public float? FitwageBase { get; set; }
        public float? Ficarate { get; set; }
        public float? FicawageBase { get; set; }
        public float? Futarate { get; set; }
        public float? FutawageBase { get; set; }
        public float? FicamedRate { get; set; }
        public float? FicamedWageBase { get; set; }
        public decimal? StandardDeductSingle { get; set; }
        public decimal? StandardDeductJoint { get; set; }
        public decimal? Exemption { get; set; }
        public decimal? Dependents { get; set; }
        public string Notes { get; set; }
        public string CountryName { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
