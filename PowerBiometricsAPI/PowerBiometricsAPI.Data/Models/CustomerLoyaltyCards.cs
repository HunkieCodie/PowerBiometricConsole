using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerLoyaltyCards
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string LoyaltyCardId { get; set; }
        public string CustomerLoyaltyCardTypeId { get; set; }
        public string CustomerId { get; set; }
        public DateTime? IssuedDate { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public double? PointsAccumulated { get; set; }
        public double? PointsRedeemed { get; set; }
        public bool? Active { get; set; }
        public DateTime? ActivationDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
