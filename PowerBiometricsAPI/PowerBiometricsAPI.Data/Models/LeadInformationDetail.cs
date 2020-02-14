using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LeadInformationDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string LeadId { get; set; }
        public string ProjectId { get; set; }
        public DateTime? SubscriptionDate { get; set; }
        public double? SalesPrice { get; set; }
        public double? SalesQuantity { get; set; }
        public double? Total { get; set; }
        public string Notes { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string Reference { get; set; }
        public DateTime? AllocationDate { get; set; }
        public string PlotType { get; set; }
        public string NewCustomerId { get; set; }
        public bool? Revoked { get; set; }
        public string RevokedBy { get; set; }
        public DateTime? RevocationDate { get; set; }
        public bool? Transfered { get; set; }
        public DateTime? TransferedDate { get; set; }
        public string Remarks { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Refunded { get; set; }
        public DateTime? RefundDate { get; set; }
        public string RefundBy { get; set; }
        public bool? RefundPosted { get; set; }
        public string RefundRef { get; set; }
        public DateTime? RefundPostedDate { get; set; }
        public string OldFileNumber { get; set; }
        public double? UnitTransfered { get; set; }
        public bool? TransferPosted { get; set; }
        public double? TransferAmount { get; set; }
        public string TransferPostedby { get; set; }
        public string LeadName { get; set; }
        public double? AmountPaid { get; set; }
        public double? BalanceDue { get; set; }
        public bool? PermanentRevoke { get; set; }
        public string PermanentRevokedBy { get; set; }
        public DateTime? PermanentRevokedPostedDate { get; set; }
        public bool? Released { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string ReleasedBy { get; set; }
        public string BranchCode { get; set; }
    }
}
