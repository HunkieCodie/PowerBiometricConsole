using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class HelpProblemReport
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public long CaseId { get; set; }
        public string CustomerId { get; set; }
        public string ProductId { get; set; }
        public string ProblemManager { get; set; }
        public bool? ProblemAssigned { get; set; }
        public string ProblemAssignedTo { get; set; }
        public string ProblemRequestMethod { get; set; }
        public string ProblemStatus { get; set; }
        public byte? ProblemPriority { get; set; }
        public string ProblemType { get; set; }
        public string ProblemVersion { get; set; }
        public DateTime? ProblemDate { get; set; }
        public string ProblemShortDescription { get; set; }
        public string ProblemKeywords { get; set; }
        public string ProblemLongDescription { get; set; }
        public string ProblemExactErrorMessage { get; set; }
        public string ProblemStepsToReproduce { get; set; }
        public string ProblemScreenShotUrl { get; set; }
        public bool? ProblemFixed { get; set; }
        public DateTime? ProblemFixDate { get; set; }
        public string ProblemFix { get; set; }
        public double? ProblemTimeSpentFixing { get; set; }
        public string ProblemNotesPrivate { get; set; }
        public bool? ProblemApproved { get; set; }
        public string ProblemApprovedBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
