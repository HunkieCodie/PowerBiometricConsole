using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PosserviceCharge
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ServiceId { get; set; }
        public string ServiceDescription { get; set; }
        public double? ServicePercent { get; set; }
        public double? ServiceAmount { get; set; }
        public string ServiceItemId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
