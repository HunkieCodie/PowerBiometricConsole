using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollGroupDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string GroupId { get; set; }
        public decimal GroupDetailId { get; set; }
        public string PayTypeId { get; set; }
        public string BasisId { get; set; }
        public string AttrId { get; set; }
        public double? Rate { get; set; }
        public decimal? Value { get; set; }
        public bool? Taxable { get; set; }
        public string TaxGroupId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? ActiveYn { get; set; }
        public string GlaccountNumber { get; set; }
        public string BranchCode { get; set; }
    }
}
