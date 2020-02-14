using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class QuoteTrackingHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string OrderNumber { get; set; }
        public string QuoteStatus { get; set; }
        public string QuoteDescription { get; set; }
        public string QuoteLongDescription { get; set; }
        public DateTime? ExpectedCloseDate { get; set; }
        public int? SaleProbability { get; set; }
        public string SpecialInstructions { get; set; }
        public string SpecialNeeds { get; set; }
        public string EnteredBy { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
