using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class WorkOrderHeaderHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string WorkOrderNumber { get; set; }
        public string WorkOrderType { get; set; }
        public string CurrencyId { get; set; }
        public DateTime? WorkOrderDate { get; set; }
        public DateTime? WorkOrderStartDate { get; set; }
        public DateTime? WorkOrderExpectedDate { get; set; }
        public bool? WorkOrderCompleted { get; set; }
        public DateTime? WorkOrderCompletedDate { get; set; }
        public DateTime? WorkOrderCancelDate { get; set; }
        public string WorkOrderReference { get; set; }
        public DateTime? WorkOrderReferenceDate { get; set; }
        public string WorkOrderRequestedBy { get; set; }
        public string WorkOrderManager { get; set; }
        public string WorkOrderAssignedTo { get; set; }
        public string WorkOrderApprovedBy { get; set; }
        public DateTime? WorkOrderApprovedByDate { get; set; }
        public string WorkOrderForCompanyId { get; set; }
        public string WorkOrderForDivisionId { get; set; }
        public string WorkOrderForDepartmentId { get; set; }
        public string WorkOrderReason { get; set; }
        public string WorkOrderDescription { get; set; }
        public string WorkOrderStatus { get; set; }
        public string WorkOrderPriority { get; set; }
        public string WorkOrderInProgress { get; set; }
        public string WorkOrderProgressNotes { get; set; }
        public decimal? WorkOrderTotalCost { get; set; }
        public string WorkOrderMemo1 { get; set; }
        public string WorkOrderMemo2 { get; set; }
        public string WorkOrderMemo3 { get; set; }
        public string WorkOrderMemo4 { get; set; }
        public string WorkOrderMemo5 { get; set; }
        public string WorkOrderMemo6 { get; set; }
        public string WorkOrderMemo7 { get; set; }
        public string WorkOrderMemo8 { get; set; }
        public string WorkOrderMemo9 { get; set; }
        public string Signature { get; set; }
        public string SignaturePassword { get; set; }
        public string SupervisorSignature { get; set; }
        public string SupervisorSignaturePassword { get; set; }
        public string ManagerSignature { get; set; }
        public string ManagerSignaturePassword { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Memorize { get; set; }
        public bool? Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public string PostedBy { get; set; }
        public bool? Approved { get; set; }
        public bool? Void { get; set; }
        public bool? Cleared { get; set; }
        public string EnteredBy { get; set; }
        public string BranchCode { get; set; }
    }
}
