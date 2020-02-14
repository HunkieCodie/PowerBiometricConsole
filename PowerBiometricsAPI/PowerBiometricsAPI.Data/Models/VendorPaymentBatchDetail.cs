using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class VendorPaymentBatchDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PaymentId { get; set; }
        public decimal PaymentDetailId { get; set; }
        public string VendorId { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? DiscountTaken { get; set; }
        public decimal? WriteOffAmount { get; set; }
        public decimal? AppliedAmount { get; set; }
        public string ProjectId { get; set; }
        public string TrackingNumber { get; set; }
        public string TaxGroupId { get; set; }
        public decimal? TaxAmount { get; set; }
        public double? TaxRate { get; set; }
        public string Notes { get; set; }
        public string GlanalysisType1 { get; set; }
        public string GlanalysisType2 { get; set; }
        public string AssetId { get; set; }
        public double? CreditAmount { get; set; }
        public double? UnappliedAmount { get; set; }
        public string SettlementReference { get; set; }
        public string VendorControlAccount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string VendorName { get; set; }
        public string BranchCode { get; set; }
    }
}
