using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeesAccrualTypes
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string AccrualId { get; set; }
        public string AccrualDescription { get; set; }
        public string AccrualFrequency { get; set; }
        public string AccrualGlAccount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
