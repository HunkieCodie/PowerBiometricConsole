using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LedgerPrepaymentHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string LedgerPrepaymentId { get; set; }
        public string GltransactionTypeId { get; set; }
        public DateTime? GltransactionDate { get; set; }
        public DateTime? SystemDate { get; set; }
        public string GltransactionDescription { get; set; }
        public string GltransactionReference { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string GltransactionAccount { get; set; }
        public decimal? GltransactionAmount { get; set; }
        public int? TotalPeriod { get; set; }
        public int? TotalPeriodPost { get; set; }
        public int? OutstandingPeriod { get; set; }
        public bool? Cleared { get; set; }
        public bool? Void { get; set; }
        public bool? Posted { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string EnteredBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string VoidBy { get; set; }
        public DateTime? VoidDate { get; set; }
        public string BranchCode { get; set; }
    }
}
