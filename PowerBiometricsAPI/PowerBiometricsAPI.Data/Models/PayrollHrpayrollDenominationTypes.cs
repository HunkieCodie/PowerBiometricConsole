using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollDenominationTypes
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CurrencyId { get; set; }
        public string DenominationId { get; set; }
        public string DenominationDescription { get; set; }
        public double? DenominationValue { get; set; }
        public bool? ActiveYn { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
