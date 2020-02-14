using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollLoanType
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string LoanTypeId { get; set; }
        public string Description { get; set; }
        public decimal? InterestRate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string GlaccountNumber { get; set; }
        public string InterestTypeId { get; set; }
        public string BranchCode { get; set; }
    }
}
