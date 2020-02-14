using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerBillsGeneratedHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BillNumber { get; set; }
        public DateTime BillDate { get; set; }
        public string BillingType { get; set; }
        public string Notes { get; set; }
        public bool? Billed { get; set; }
        public string BilledBy { get; set; }
        public DateTime? BilledDate { get; set; }
        public DateTime? LastBilledDate { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public string PostedBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
