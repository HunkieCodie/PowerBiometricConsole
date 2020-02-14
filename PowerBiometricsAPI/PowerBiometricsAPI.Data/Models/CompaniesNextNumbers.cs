using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CompaniesNextNumbers
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string NextNumberName { get; set; }
        public string NextNumberValue { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string NextNumberPrefix { get; set; }
        public string NextNumberSeparator { get; set; }
        public string BranchCode { get; set; }
    }
}
