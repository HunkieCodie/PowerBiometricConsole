using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryCart
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public bool? UsePricingCodes { get; set; }
        public bool? UseCustomerSpecificPricing { get; set; }
        public string DefaultPricingCode { get; set; }
        public bool? ItemOrDefaultWarehouse { get; set; }
        public string DefaultWarehouse { get; set; }
        public string DefaultBin { get; set; }
        public bool? CheckStock { get; set; }
        public bool? ShowStock { get; set; }
        public bool? HideOutOfStockItems { get; set; }
        public bool? OfferSubstitute { get; set; }
        public bool? ShowFeatures { get; set; }
        public bool? ShowSales { get; set; }
        public bool? ShowCrossSell { get; set; }
        public bool? ShowRelations { get; set; }
        public bool? ShowReviews { get; set; }
        public bool? ShowWishList { get; set; }
        public bool? ShowItemNotifications { get; set; }
        public bool? ShowRma { get; set; }
        public bool? ChargeRestockingFee { get; set; }
        public double? RestockingFee { get; set; }
        public bool? MinimumOrder { get; set; }
        public decimal? MinimumOrderAmount { get; set; }
        public bool? MultiCurrency { get; set; }
        public bool? MultiLanguage { get; set; }
        public bool? GiftsOrCoupons { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
