using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class MultipleDiscountGroupDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string MultipleDiscountGroupDetailId { get; set; }
        public string MultipleDiscountId { get; set; }
        public string Description { get; set; }
        public string GlmultipleDiscountAccount { get; set; }
        public double? MultipleDiscountPercent { get; set; }
        public int? MultipleDiscountOrder { get; set; }
        public bool? MultipleDiscountOnMultipleDiscount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
