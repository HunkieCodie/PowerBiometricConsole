using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class SalesGroup
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string SalesGroupId { get; set; }
        public string EmployeeId { get; set; }
        public string SalesGroupDescription { get; set; }
        public string SalesGroupSupervisor { get; set; }
        public bool? SplitCommission { get; set; }
        public double? ComissionPerc { get; set; }
        public string ComissionType { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
