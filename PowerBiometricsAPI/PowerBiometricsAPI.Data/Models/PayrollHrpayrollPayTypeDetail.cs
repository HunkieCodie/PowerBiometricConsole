using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollPayTypeDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PayTypeId { get; set; }
        public string PayTypeDetailId { get; set; }
        public decimal PayTypeDetailInc { get; set; }
        public string EmployeePercent { get; set; }
        public string EmployerPercent { get; set; }
        public string OperatorId { get; set; }
        public bool? Active { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
