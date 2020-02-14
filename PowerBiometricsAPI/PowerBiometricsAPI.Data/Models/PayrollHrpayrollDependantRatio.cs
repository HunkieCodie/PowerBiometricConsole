using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollDependantRatio
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public int DependantId { get; set; }
        public string DependantName { get; set; }
        public DateTime? DependantBirthday { get; set; }
        public double? DependantRatio { get; set; }
        public string DependantRelation { get; set; }
        public string DependantAddress { get; set; }
        public string DependantPhone { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public byte[] Picture { get; set; }
        public string DependantFirstName { get; set; }
        public string DependantOtherName { get; set; }
        public string BranchCode { get; set; }
    }
}
