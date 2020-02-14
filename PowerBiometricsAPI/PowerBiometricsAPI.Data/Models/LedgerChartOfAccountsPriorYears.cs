using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LedgerChartOfAccountsPriorYears
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string GlaccountNumber { get; set; }
        public DateTime GlfiscalYear { get; set; }
        public string GlaccountName { get; set; }
        public string GlaccountDescription { get; set; }
        public string GlaccountUse { get; set; }
        public string GlaccountType { get; set; }
        public string GlbalanceType { get; set; }
        public bool? GlreportingAccount { get; set; }
        public short? GlreportLevel { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? GlaccountBalance { get; set; }
        public decimal? GlaccountBeginningBalance { get; set; }
        public string GlotherNotes { get; set; }
        public string GlbudgetId { get; set; }
        public decimal? GlpriorYearBeginningBalance { get; set; }
        public decimal? GlpriorYearPeriod1 { get; set; }
        public decimal? GlpriorYearPeriod2 { get; set; }
        public decimal? GlpriorYearPeriod3 { get; set; }
        public decimal? GlpriorYearPeriod4 { get; set; }
        public decimal? GlpriorYearPeriod5 { get; set; }
        public decimal? GlpriorYearPeriod6 { get; set; }
        public decimal? GlpriorYearPeriod7 { get; set; }
        public decimal? GlpriorYearPeriod8 { get; set; }
        public decimal? GlpriorYearPeriod9 { get; set; }
        public decimal? GlpriorYearPeriod10 { get; set; }
        public decimal? GlpriorYearPeriod11 { get; set; }
        public decimal? GlpriorYearPeriod12 { get; set; }
        public decimal? GlpriorYearPeriod13 { get; set; }
        public decimal? GlpriorYearPeriod14 { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
