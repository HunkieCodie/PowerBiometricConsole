using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Possetup
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public bool? UsePricingCodes { get; set; }
        public bool? UseCustomerSpecificPricing { get; set; }
        public string DefaultPricingCode { get; set; }
        public string DefaultWarehouse { get; set; }
        public string DefaultBin { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
