using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollTrainingDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string TrainingId { get; set; }
        public string EmployeeId { get; set; }
        public decimal? Amount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int LineId { get; set; }
        public string CourseDescription { get; set; }
        public string FacilitatorDescription { get; set; }
        public string EmployeeName { get; set; }
        public string BranchCode { get; set; }
    }
}
