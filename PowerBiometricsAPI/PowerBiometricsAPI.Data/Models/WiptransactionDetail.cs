using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class WiptransactionDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string WorkOrderId { get; set; }
        public int WorkOrderDetailLineId { get; set; }
        public string WorkOrderNumber { get; set; }
        public string WorkOrderBomnumber { get; set; }
        public string WorkOrderItemId { get; set; }
        public DateTime? WorkOrderIssuedDate { get; set; }
        public string WorkOrderReference { get; set; }
        public double? WorkOrderIssueQty { get; set; }
        public double? WorkOrderItemCost { get; set; }
        public double? WorkOrderItemValue { get; set; }
        public string ProjectId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string GlanalysisType1 { get; set; }
        public string GlanalysisType2 { get; set; }
        public string AssetId { get; set; }
        public string BranchCode { get; set; }
    }
}
