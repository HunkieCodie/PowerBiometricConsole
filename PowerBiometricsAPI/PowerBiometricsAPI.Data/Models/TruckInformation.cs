using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class TruckInformation
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string TruckId { get; set; }
        public string TruckName { get; set; }
        public double? Capacity { get; set; }
        public bool? Owned { get; set; }
        public bool? Engaged { get; set; }
        public bool? IsActive { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
