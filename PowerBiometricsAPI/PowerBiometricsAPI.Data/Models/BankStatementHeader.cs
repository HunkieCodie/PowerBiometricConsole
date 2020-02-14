using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class BankStatementHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BankId { get; set; }
        public DateTime BankStatementDate { get; set; }
        public bool? SavedImported { get; set; }
        public double? OpeningBalance { get; set; }
        public double? ClosingBalance { get; set; }
        public double? LockedBy { get; set; }
        public double? LockTs { get; set; }
        public bool? FullyProcessed { get; set; }
        public string FullyProcessedBy { get; set; }
        public DateTime? FullyProcessedDate { get; set; }
        public string BranchCode { get; set; }
    }
}
