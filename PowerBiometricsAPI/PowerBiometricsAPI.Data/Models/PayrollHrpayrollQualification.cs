using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollQualification
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string QualificationTypeId { get; set; }
        public string Institution { get; set; }
        public string YearFrom { get; set; }
        public string YearTo { get; set; }
        public string Grade { get; set; }
        public string CourseTypeId { get; set; }
        public string CertificateNo { get; set; }
        public int? YearofIssuance { get; set; }
        public bool? Entered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public bool? Posted { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public string VerifiedBy { get; set; }
        public bool? Verified { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public int QualificationId { get; set; }
        public string BranchCode { get; set; }
    }
}
