using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class AuditTrailHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public decimal AuditId { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? EntryTime { get; set; }
        public string DocumentType { get; set; }
        public string TransactionNumber { get; set; }
        public string TableAffected { get; set; }
        public string FieldChanged { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string TransactionLineNumber { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
