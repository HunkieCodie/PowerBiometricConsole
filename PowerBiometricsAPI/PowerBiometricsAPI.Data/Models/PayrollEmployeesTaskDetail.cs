using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeesTaskDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeTaskId { get; set; }
        public decimal EmployeeTaskDetailId { get; set; }
        public string TaskDetailRelatedDocumentType { get; set; }
        public string TaskDetailRelatedDocumentNumber { get; set; }
        public string TaskDetailDescription { get; set; }
        public DateTime? TaskDetailDate { get; set; }
        public bool? TaskDetailComplete { get; set; }
        public DateTime? TaskDetailCompleteDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string ItemId { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public double? ItemQty { get; set; }
        public string AssetId { get; set; }
        public string BranchCode { get; set; }
    }
}
