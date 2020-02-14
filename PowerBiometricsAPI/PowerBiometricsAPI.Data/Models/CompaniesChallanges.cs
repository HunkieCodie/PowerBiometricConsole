using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CompaniesChallanges
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public long ChallangeId { get; set; }
        public bool? ChallangeOpen { get; set; }
        public string ChallangeReason { get; set; }
        public string ChallangeDocument { get; set; }
        public DateTime? ChallangeDocumentDate { get; set; }
        public string ChallangeDocumentType { get; set; }
        public decimal? ChallangeAmount { get; set; }
        public bool? ChallangeResearched { get; set; }
        public bool? ChallangeApproved { get; set; }
        public string ChallangeApprovedBy { get; set; }
        public DateTime? ChallangeApprovedDate { get; set; }
        public string ChallangeNotes { get; set; }
        public string Signature { get; set; }
        public string SignaturePassword { get; set; }
        public string SupervisorSignature { get; set; }
        public string SupervisorPassword { get; set; }
        public string ManagerSignature { get; set; }
        public string ManagerPassword { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
