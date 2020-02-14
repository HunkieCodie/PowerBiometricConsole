using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class HelpSupportRequest
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public long CaseId { get; set; }
        public string CustomerId { get; set; }
        public string ContactId { get; set; }
        public string ProductId { get; set; }
        public string SupportManager { get; set; }
        public bool? SupportAssigned { get; set; }
        public string SupportAssignedTo { get; set; }
        public string SupportRequestMethod { get; set; }
        public string SupportStatus { get; set; }
        public byte? SupportPriority { get; set; }
        public string SupportType { get; set; }
        public string SupportVersion { get; set; }
        public DateTime? SupportDate { get; set; }
        public string SupportQuestion { get; set; }
        public string SupportKeywords { get; set; }
        public string SupportDescription { get; set; }
        public string SupportScreenShotUrl { get; set; }
        public string SupportResolution { get; set; }
        public DateTime? SupportResolutionDate { get; set; }
        public double? SupportTimeSpentFixing { get; set; }
        public string SuportNotesPrivate { get; set; }
        public bool? SupportApproved { get; set; }
        public string SupportApprovedBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
