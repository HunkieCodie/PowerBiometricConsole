using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollYtdtransaction
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string PayTypeId { get; set; }
        public DateTime Period { get; set; }
        public double? Balance { get; set; }
        public double? Utilized { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Cleared { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? Posted { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public double? UtilizedDays { get; set; }
        public double? CummulativeBalance { get; set; }
        public double? CummulativeDays { get; set; }
        public double? BalanceDays { get; set; }
        public double? MthBalance { get; set; }
        public double? MthDays { get; set; }
        public double? Rate { get; set; }
        public string AttrId { get; set; }
        public string BranchCode { get; set; }
    }
}
