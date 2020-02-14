using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollAppraisalCriteriaDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string GroupId { get; set; }
        public string CriteriaId { get; set; }
        public string AppraisalTypeId { get; set; }
        public string AppraisalDescription { get; set; }
        public double? MaxPoints { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
