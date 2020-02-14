using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class ProductionDetailOrder
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string AssemblyId { get; set; }
        public string OrderId { get; set; }
        public string OrderDescription { get; set; }
        public double? EstimatedCost { get; set; }
        public string Notes { get; set; }
        public DateTime? SystemDate { get; set; }
        public bool? Cleared { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
