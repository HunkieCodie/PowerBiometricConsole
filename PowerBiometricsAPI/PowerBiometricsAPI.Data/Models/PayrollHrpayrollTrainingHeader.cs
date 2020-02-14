using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollTrainingHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string TrainingId { get; set; }
        public string TrainingDescription { get; set; }
        public string Facilitator { get; set; }
        public string Course { get; set; }
        public decimal? Total { get; set; }
        public string EnteredBy { get; set; }
        public bool? Cleared { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public byte[] Picture { get; set; }
        public string TrainingLoc { get; set; }
        public int? DutyAllowance { get; set; }
        public string BranchCode { get; set; }
    }
}
