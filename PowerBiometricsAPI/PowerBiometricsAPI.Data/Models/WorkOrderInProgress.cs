using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class WorkOrderInProgress
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string WorkOrderInProgress1 { get; set; }
        public string WorkOrderInProgressDescription { get; set; }
        public DateTime? WorkOrderIssuedDate { get; set; }
        public string WorkOrderItemId { get; set; }
        public double? WorkOrderItemQty { get; set; }
        public double? WorkOrderItemValue { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
