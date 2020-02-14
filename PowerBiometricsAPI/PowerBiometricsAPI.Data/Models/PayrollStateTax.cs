using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollStateTax
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string State { get; set; }
        public string StateName { get; set; }
        public float? Sutarate { get; set; }
        public decimal? SutawageBase { get; set; }
        public float? Sitrate { get; set; }
        public decimal? SitwageBase { get; set; }
        public float? Sdirate { get; set; }
        public decimal? SdiwageBase { get; set; }
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
