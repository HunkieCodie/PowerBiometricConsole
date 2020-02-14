using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PowerSuiteRoomTypeManager
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Capacity { get; set; }
        public string CategoryDescription { get; set; }
        public double? Price { get; set; }
        public byte[] Picture { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
