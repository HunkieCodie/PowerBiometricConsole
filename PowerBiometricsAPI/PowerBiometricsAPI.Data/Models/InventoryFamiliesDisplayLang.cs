using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryFamiliesDisplayLang
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ItemFamilyId { get; set; }
        public string DisplayLang { get; set; }
        public string FamilyName { get; set; }
        public string FamilyDescription { get; set; }
        public string FamilyLongDescription { get; set; }
        public string FamilyPictureUrl { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
