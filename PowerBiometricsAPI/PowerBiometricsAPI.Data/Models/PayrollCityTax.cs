using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollCityTax
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string StateName { get; set; }
        public string CountyName { get; set; }
        public string CityName { get; set; }
        public float? CityRate { get; set; }
        public float? CityWageBase { get; set; }
        public float? CityUiirate { get; set; }
        public float? CityUiwageBase { get; set; }
        public float? CityOtherRate { get; set; }
        public float? CityOtherWageBase { get; set; }
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
