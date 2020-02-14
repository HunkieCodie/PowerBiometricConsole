using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PoscommissionType
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string VendorId { get; set; }
        public string CommissionTypeId { get; set; }
        public string CommissionTypeDescription { get; set; }
        public double? CommissionRate { get; set; }
        public string CommissionAccount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public int TransId { get; set; }
        public string BranchCode { get; set; }
    }
}
