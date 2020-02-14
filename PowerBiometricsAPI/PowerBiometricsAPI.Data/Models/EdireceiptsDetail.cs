using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class EdireceiptsDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ReceiptId { get; set; }
        public decimal ReceiptDetailId { get; set; }
        public string DocumentNumber { get; set; }
        public string PaymentId { get; set; }
        public string PayedId { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? DiscountTaken { get; set; }
        public decimal? WriteOffAmount { get; set; }
        public decimal? AppliedAmount { get; set; }
        public bool? Cleared { get; set; }
        public string DetailMemo1 { get; set; }
        public string DetailMemo2 { get; set; }
        public string DetailMemo3 { get; set; }
        public string DetailMemo4 { get; set; }
        public string DetailMemo5 { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
