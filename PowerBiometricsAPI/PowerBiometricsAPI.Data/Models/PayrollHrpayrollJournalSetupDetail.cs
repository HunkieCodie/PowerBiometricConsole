using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollJournalSetupDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string JournalLocationId { get; set; }
        public string JournalCostCenterId { get; set; }
        public string JournalDepartmentId { get; set; }
        public string JournalGroupId { get; set; }
        public string PayTypeId { get; set; }
        public string GlaccountNumber { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string BranchCode { get; set; }
    }
}
