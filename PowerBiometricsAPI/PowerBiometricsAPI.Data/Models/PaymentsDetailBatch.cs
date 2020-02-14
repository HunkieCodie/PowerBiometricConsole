using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PaymentsDetailBatch
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PaymentId { get; set; }
        public decimal PaymentDetailId { get; set; }
        public string PayedId { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? DiscountTaken { get; set; }
        public decimal? WriteOffAmount { get; set; }
        public decimal? AppliedAmount { get; set; }
        public bool? Cleared { get; set; }
        public string GlexpenseAccount { get; set; }
        public string ProjectId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string TaxGroupId { get; set; }
        public decimal? TaxAmount { get; set; }
        public double? TaxRate { get; set; }
        public string Notes { get; set; }
        public string GlanalysisType1 { get; set; }
        public string GlanalysisType2 { get; set; }
        public string AssetId { get; set; }
        public string BranchCode { get; set; }
    }
}
