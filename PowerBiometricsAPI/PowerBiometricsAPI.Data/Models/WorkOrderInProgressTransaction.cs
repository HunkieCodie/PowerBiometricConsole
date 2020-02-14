using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class WorkOrderInProgressTransaction
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string WorkOrderInProgressNumber { get; set; }
        public string WorkOrderItemId { get; set; }
        public DateTime? WorkOrderIssuedDate { get; set; }
        public string WorkOrderInProgressDescription { get; set; }
        public double? WorkOrderItemQty { get; set; }
        public double? WorkOrderItemValue { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
