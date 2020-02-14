using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class TaxGroupDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string TaxGroupDetailId { get; set; }
        public string TaxId { get; set; }
        public string Description { get; set; }
        public string GltaxAccount { get; set; }
        public double? TaxPercent { get; set; }
        public int? TaxOrder { get; set; }
        public bool? TaxOnTax { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
