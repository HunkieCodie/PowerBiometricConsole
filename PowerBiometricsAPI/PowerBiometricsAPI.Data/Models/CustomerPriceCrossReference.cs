using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerPriceCrossReference
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CustomerId { get; set; }
        public string ItemPricingCode { get; set; }
        public decimal? ItemPrice { get; set; }
        public string CurrencyId { get; set; }
        public decimal? Freight { get; set; }
        public decimal? Handling { get; set; }
        public decimal? Advertising { get; set; }
        public decimal? Shipping { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
