using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeesAccrualFrequency
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string AccrualFrequency { get; set; }
        public string AccruslFrequencyDescription { get; set; }
        public double? AccrualFrequencyRate { get; set; }
        public string AccrualFrequencyUnit { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
