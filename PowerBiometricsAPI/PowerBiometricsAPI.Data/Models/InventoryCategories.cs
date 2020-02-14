using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryCategories
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ItemCategoryId { get; set; }
        public string ItemFamilyId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryLongDescription { get; set; }
        public string CategoryPictureUrl { get; set; }
        public double? PriceMarkUp { get; set; }
        public double? GrossMargin { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public DateTime? LastEditDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ServiceCharge { get; set; }
        public bool? ServiceStatus { get; set; }
        public string BranchCode { get; set; }
    }
}
