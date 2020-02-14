using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryReviews
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ItemId { get; set; }
        public string ReviewId { get; set; }
        public string ReviewBy { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string Review { get; set; }
        public int? Rating { get; set; }
        public int? Helpful { get; set; }
        public int? Views { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
