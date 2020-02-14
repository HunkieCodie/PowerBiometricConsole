using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryItemsDisplayLang
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ItemId { get; set; }
        public string DisplayLang { get; set; }
        public bool? IsActive { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemLongDescription { get; set; }
        public string ItemCategoryId { get; set; }
        public string SalesDescription { get; set; }
        public string PurchaseDescription { get; set; }
        public string PictureUrl { get; set; }
        public string LargePictureUrl { get; set; }
        public string ItemColor { get; set; }
        public string ItemStyle { get; set; }
        public string ItemCareInstructions { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string EnteredBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
