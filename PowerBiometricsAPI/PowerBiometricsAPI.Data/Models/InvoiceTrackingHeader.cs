using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InvoiceTrackingHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceDescription { get; set; }
        public string InvoiceLongDescription { get; set; }
        public DateTime? PaymentExpectedBy { get; set; }
        public bool? PaymentProblem { get; set; }
        public string PaymentProblemReason { get; set; }
        public string EnteredBy { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
