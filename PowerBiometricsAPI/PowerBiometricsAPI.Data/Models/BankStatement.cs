using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class BankStatement
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BankId { get; set; }
        public DateTime BankStatementDate { get; set; }
        public int BankStatementId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string TransactionType { get; set; }
        public string EntityTypeId { get; set; }
        public string Reference { get; set; }
        public string Narratives { get; set; }
        public bool? Reconcile { get; set; }
        public bool? Reconciled { get; set; }
        public string ReconciledBy { get; set; }
        public DateTime? ReconciledDate { get; set; }
        public bool? Posted { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? SystemDate { get; set; }
        public string EnteredBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? SavedImported { get; set; }
        public string TaxGroupId { get; set; }
        public double? TaxAmount { get; set; }
        public double? TaxRate { get; set; }
        public string BranchCode { get; set; }
    }
}
