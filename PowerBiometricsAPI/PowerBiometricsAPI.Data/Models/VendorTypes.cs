using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class VendorTypes
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string VendorTypeId { get; set; }
        public string VendorTypeDescription { get; set; }
        public string CreditorsControlAccount { get; set; }
        public string CurrencyExchangeGainOrLossAccount { get; set; }
        public string DiscountsAccount { get; set; }
        public double? DiscountRate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
