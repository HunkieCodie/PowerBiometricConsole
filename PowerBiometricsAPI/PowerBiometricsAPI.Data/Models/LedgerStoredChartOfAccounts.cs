using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LedgerStoredChartOfAccounts
    {
        public string IndustryType { get; set; }
        public string GlstoredAccountNumber { get; set; }
        public string GlstoredAccountName { get; set; }
        public string GlstoredAccountType { get; set; }
        public string GlstoredBalanceType { get; set; }
        public bool? GlstoredReportingAccount { get; set; }
        public short? GlstoredReportingLevel { get; set; }
        public string GlstoredNotes { get; set; }
        public string BranchCode { get; set; }
    }
}
