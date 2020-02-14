using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryCrossSelling
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ItemId { get; set; }
        public string CrossSellItemId { get; set; }
        public string CrossSellItemReason { get; set; }
        public string CrossSellItemPromotion { get; set; }
        public DateTime? CrossSellItemPromotionEnds { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
