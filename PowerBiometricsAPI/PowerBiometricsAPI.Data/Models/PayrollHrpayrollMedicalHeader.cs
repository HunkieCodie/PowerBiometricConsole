using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollMedicalHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string DependantId { get; set; }
        public DateTime TranDate { get; set; }
        public string Hospital { get; set; }
        public string IllnessType { get; set; }
        public decimal? TotalAmount { get; set; }
        public string Remarks { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public bool? Cleared { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Posted { get; set; }
        public string PostedBy { get; set; }
        public int MedicalId { get; set; }
        public byte[] Picture { get; set; }
        public string EmployeeName { get; set; }
        public string BranchCode { get; set; }
    }
}
