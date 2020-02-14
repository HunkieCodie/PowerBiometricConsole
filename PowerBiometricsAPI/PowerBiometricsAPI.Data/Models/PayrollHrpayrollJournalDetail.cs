using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollJournalDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string TransactionNumber { get; set; }
        public DateTime GltransactionPeriod { get; set; }
        public decimal GltransactionNumberDetail { get; set; }
        public string Location { get; set; }
        public string CostCenter { get; set; }
        public string Department { get; set; }
        public string GroupId { get; set; }
        public string PayTypeId { get; set; }
        public double? GltransactionAmountDr { get; set; }
        public double? GltransactionAmountCr { get; set; }
        public string GltransactionAccount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string Project { get; set; }
        public bool? Deductibles { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string BranchCode { get; set; }
    }
}
