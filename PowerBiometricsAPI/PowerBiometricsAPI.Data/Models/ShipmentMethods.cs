using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class ShipmentMethods
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ShipMethodId { get; set; }
        public string ShipMethodDescription { get; set; }
        public string FreighPayment { get; set; }
        public string Scaccode { get; set; }
        public string Scacdescription { get; set; }
        public string ShippingAccountNumber { get; set; }
        public string ShippingLogin { get; set; }
        public string ShippingPassword { get; set; }
        public string WebsiteUrl { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
