using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class TblAuditTrail
    {
        public decimal AuditId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string DocumentType { get; set; }
        public string TransactionNumber { get; set; }
        public string TransactionLineNumber { get; set; }
        public string Description { get; set; }
        public string FieldChanged { get; set; }
        public double? NewValue { get; set; }
        public double? TenderedAmount { get; set; }
        public double? Change { get; set; }
        public string WarehouseId { get; set; }
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BranchCode { get; set; }
    }
}
