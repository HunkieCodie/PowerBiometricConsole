using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollCareer
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public int CareerId { get; set; }
        public string Company { get; set; }
        public string YearFrom { get; set; }
        public string YearTo { get; set; }
        public string Designation { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string Notes { get; set; }
        public string CompanyInfoId { get; set; }
        public string BranchCode { get; set; }
    }
}
