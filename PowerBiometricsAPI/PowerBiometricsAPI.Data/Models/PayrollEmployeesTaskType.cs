using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeesTaskType
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string TaskTypeId { get; set; }
        public string WorkFlowTypeId { get; set; }
        public string TaskTypeDescription { get; set; }
        public string TaskTypeRule { get; set; }
        public string TaskTypeManager { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
