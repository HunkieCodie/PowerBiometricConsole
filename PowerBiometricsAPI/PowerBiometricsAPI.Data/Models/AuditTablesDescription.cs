using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class AuditTablesDescription
    {
        public string TableName { get; set; }
        public string DocumentType { get; set; }
        public string TransactionNumberField { get; set; }
        public string TransactionLineNumberField { get; set; }
        public bool? ComplexObject { get; set; }
        public bool? ApplyAudit { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
