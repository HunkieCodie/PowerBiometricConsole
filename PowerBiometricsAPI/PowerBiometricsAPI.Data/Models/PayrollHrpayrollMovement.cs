using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollMovement
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string OldGroup { get; set; }
        public string NewGroup { get; set; }
        public string OldLocation { get; set; }
        public string NewLocation { get; set; }
        public string OldCostCenter { get; set; }
        public string NewCostCenter { get; set; }
        public string OldDepartment { get; set; }
        public string NewDepartment { get; set; }
        public bool? Cleared { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? Posted { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? OldBaseValue { get; set; }
        public double? NewBaseValue { get; set; }
        public DateTime? Period { get; set; }
        public string BranchCode { get; set; }
    }
}
