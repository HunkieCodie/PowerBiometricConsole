using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class ProjectsDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ProjectId { get; set; }
        public int ProjectDetailId { get; set; }
        public string DependsOn { get; set; }
        public int? Step { get; set; }
        public string StepName { get; set; }
        public string StepDescription { get; set; }
        public DateTime? StepStartDate { get; set; }
        public DateTime? StepCompleteDate { get; set; }
        public DateTime? StepDueDate { get; set; }
        public string StepNotes { get; set; }
        public string StepStatus { get; set; }
        public bool? StepComplete { get; set; }
        public double? PercentComplete { get; set; }
        public string Priority { get; set; }
        public int? EstimatedEffort { get; set; }
        public int? ActualEffort { get; set; }
        public bool? Milestone { get; set; }
        public string EmployeeId { get; set; }
        public bool? Billed { get; set; }
        public string OrderNumber { get; set; }
        public bool? Paid { get; set; }
        public string InvoiceNumber { get; set; }
        public bool? RequiredExpenses { get; set; }
        public string PurchaseNumber { get; set; }
        public string OtherRelatedDocumentNumber { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string TransactionType { get; set; }
        public string ItemId { get; set; }
        public string Description { get; set; }
        public string Glaccount { get; set; }
        public double? EstimatedQty { get; set; }
        public decimal? EstimatedValue { get; set; }
        public double? ActualQty { get; set; }
        public decimal? ActualValue { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string BranchCode { get; set; }
    }
}
