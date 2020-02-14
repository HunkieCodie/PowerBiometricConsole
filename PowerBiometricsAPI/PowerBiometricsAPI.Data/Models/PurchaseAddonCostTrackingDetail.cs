using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PurchaseAddonCostTrackingDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PurchaseNumber { get; set; }
        public decimal PurchaseLineNumber { get; set; }
        public string Description { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string PaymentId { get; set; }
        public string PaymentMethodId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string GlexpenseAccount { get; set; }
        public string BankId { get; set; }
        public double? Total { get; set; }
        public string ProjectId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string ApportionmentBase { get; set; }
        public string BranchCode { get; set; }
    }
}
