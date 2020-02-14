using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollEmployeeReferee
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public int RefereeId { get; set; }
        public string RefereeName { get; set; }
        public string RefereeEmail { get; set; }
        public string RefereeRelation { get; set; }
        public string RefereeAddress { get; set; }
        public string RefereePhone { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public byte[] Picture { get; set; }
        public string BranchCode { get; set; }
    }
}
