using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerCreditReferences
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CustomerId { get; set; }
        public string ReferenceId { get; set; }
        public string ReferenceName { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public string ReferenceFactor { get; set; }
        public DateTime? ReferenceSoldSince { get; set; }
        public DateTime? ReferenceLastSale { get; set; }
        public decimal? ReferenceHighCredit { get; set; }
        public decimal? ReferenceCurrentBalance { get; set; }
        public decimal? ReferencePastDue { get; set; }
        public double? ReferencePromptPerc { get; set; }
        public int? ReferenceLateDays { get; set; }
        public string ReferenceFutures { get; set; }
        public string ReferenceComments { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string EnteredBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
