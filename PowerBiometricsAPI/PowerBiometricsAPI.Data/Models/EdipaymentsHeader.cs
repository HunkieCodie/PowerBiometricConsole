using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class EdipaymentsHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PaymentId { get; set; }
        public string PaymentTypeId { get; set; }
        public string EdidirectionTypeId { get; set; }
        public string EdidocumentTypeId { get; set; }
        public bool? Ediopen { get; set; }
        public string CheckNumber { get; set; }
        public bool? CheckPrinted { get; set; }
        public DateTime? CheckDate { get; set; }
        public bool? Paid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentClassId { get; set; }
        public string VendorId { get; set; }
        public DateTime? SystemDate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? UnAppliedAmount { get; set; }
        public string GlbankAccount { get; set; }
        public string PaymentStatus { get; set; }
        public bool? Void { get; set; }
        public string Notes { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? CreditAmount { get; set; }
        public bool? SelectedForPayment { get; set; }
        public DateTime? SelectedForPaymentDate { get; set; }
        public bool? ApprovedForPayment { get; set; }
        public DateTime? ApprovedForPaymentDate { get; set; }
        public bool? Cleared { get; set; }
        public string InvoiceNumber { get; set; }
        public bool? Posted { get; set; }
        public bool? Reconciled { get; set; }
        public bool? Credit { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
