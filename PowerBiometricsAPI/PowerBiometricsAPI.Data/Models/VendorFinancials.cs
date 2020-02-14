using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class VendorFinancials
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string VendorId { get; set; }
        public short? LateDays { get; set; }
        public short? AverageDaytoPay { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public decimal? LastPaymentAmount { get; set; }
        public decimal? HighestCredit { get; set; }
        public decimal? HighestBalance { get; set; }
        public decimal? AvailableCredit { get; set; }
        public double? PromptPerc { get; set; }
        public decimal? BookedPurchaseOrders { get; set; }
        public decimal? AdvertisingDollars { get; set; }
        public decimal? TotalAp { get; set; }
        public decimal? CurrentApbalance { get; set; }
        public decimal? Under30 { get; set; }
        public decimal? Over30 { get; set; }
        public decimal? Over60 { get; set; }
        public decimal? Over90 { get; set; }
        public decimal? Over120 { get; set; }
        public decimal? Over150 { get; set; }
        public decimal? Over180 { get; set; }
        public DateTime? LastPurchaseDate { get; set; }
        public decimal? PurchaseYtd { get; set; }
        public decimal? PurchaseLastYear { get; set; }
        public decimal? PurchaseLifetime { get; set; }
        public decimal? PaymentsYtd { get; set; }
        public decimal? PaymentsLastYear { get; set; }
        public decimal? PaymentsLifetime { get; set; }
        public decimal? DebitMemos { get; set; }
        public DateTime? LastDebitMemoDate { get; set; }
        public decimal? DebitMemosYtd { get; set; }
        public decimal? DebitMemosLastYear { get; set; }
        public decimal? DebitMemosLifetime { get; set; }
        public decimal? VendorReturns { get; set; }
        public DateTime? LastReturnDate { get; set; }
        public decimal? ReturnsYtd { get; set; }
        public decimal? ReturnsLastYear { get; set; }
        public decimal? ReturnsLifetime { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
