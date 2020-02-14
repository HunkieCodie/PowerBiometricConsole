using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerLoyaltyPointDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CustomerLoyaltyPointId { get; set; }
        public int CustomerLoyaltyPointDetailId { get; set; }
        public double? ExpectedValue { get; set; }
        public double? ExpectedQuantity { get; set; }
        public double? PointsObtainable { get; set; }
        public string ProjectId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
