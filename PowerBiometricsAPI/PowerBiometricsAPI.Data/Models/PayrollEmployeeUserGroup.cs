using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeeUserGroup
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PayrollEmployeeUserGroupId { get; set; }
        public string PayrollEmployeeUserGroupDescription { get; set; }
        public string PayrollEmployeeUserGroupEmail { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
