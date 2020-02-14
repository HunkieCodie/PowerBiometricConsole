using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class AragedAllocation
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public int TransactionId { get; set; }
        public string CustomerId { get; set; }
        public string SourceDocument { get; set; }
        public string AllocationDocument { get; set; }
        public string SourceDocumentNumber { get; set; }
        public string AllocationDocumentNumber { get; set; }
        public DateTime? SourceDocumentDate { get; set; }
        public DateTime? SourceDocumentDueDate { get; set; }
        public DateTime? AllocationDate { get; set; }
        public double? Amount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public DateTime? SystemDate { get; set; }
        public string BranchCode { get; set; }
    }
}
