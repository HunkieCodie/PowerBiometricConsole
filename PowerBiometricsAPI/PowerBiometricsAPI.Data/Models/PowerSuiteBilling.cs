using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PowerSuiteBilling
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BookingId { get; set; }
        public string ServiceTypeId { get; set; }
        public double? Price { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime? BillingDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
