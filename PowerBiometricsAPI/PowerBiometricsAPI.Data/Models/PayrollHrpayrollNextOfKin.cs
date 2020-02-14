using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollNextOfKin
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public int NextOfKinId { get; set; }
        public string NextofKinName { get; set; }
        public string NextofKinRelation { get; set; }
        public string NextOfKinAddress { get; set; }
        public string NextOfKinPhone { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public byte[] Picture { get; set; }
        public string BranchCode { get; set; }
    }
}
