using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class WorkOrderDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string WorkOrderNumber { get; set; }
        public long WorkOrderLineNumber { get; set; }
        public DateTime? WorkOrderStartDate { get; set; }
        public DateTime? WorkOrderExpectedDate { get; set; }
        public bool? WorkOrderCompleted { get; set; }
        public DateTime? WorkOrderCompletedDate { get; set; }
        public string WorkOrderBomnumber { get; set; }
        public string WorkOrderBomdescription { get; set; }
        public double? WorkOrderBomquantity { get; set; }
        public decimal? WorkOrderBomunitCost { get; set; }
        public decimal? WorkOrderBomunitLabor { get; set; }
        public decimal? WorkOrderBomotherCost { get; set; }
        public decimal? WorkOrderTotalCost { get; set; }
        public string WorkOrderSerialNumber { get; set; }
        public string WorkOrderDescription { get; set; }
        public string WorkOrderStatus { get; set; }
        public string WorkOrderPriority { get; set; }
        public string WorkOrderInProgress { get; set; }
        public string WorkOrderProgressNotes { get; set; }
        public string WorkOrderDetailMemo1 { get; set; }
        public string WorkOrderDetailMemo2 { get; set; }
        public string WorkOrderDetailMemo3 { get; set; }
        public string WorkOrderDetailMemo4 { get; set; }
        public string WorkOrderDetailMemo5 { get; set; }
        public string WorkOrderDetailMemo6 { get; set; }
        public string WorkOrderDetailMemo7 { get; set; }
        public string WorkOrderDetailMemo8 { get; set; }
        public string WorkOrderDetailMemo9 { get; set; }
        public string Signature { get; set; }
        public string SignaturePassword { get; set; }
        public string SupervisorSignature { get; set; }
        public string SupervisorSignaturePassword { get; set; }
        public string ManagerSignature { get; set; }
        public string ManagerSignaturePassword { get; set; }
        public string MaterialIssueVarianceAccount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string AdditionalCostAccount { get; set; }
        public string GlanalysisType1 { get; set; }
        public string GlanalysisType2 { get; set; }
        public string AssetId { get; set; }
        public string BranchCode { get; set; }
    }
}
