using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollCompanyStandard
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CompanyStdId { get; set; }
        public int? TaxFiscalYear { get; set; }
        public int? TaxPeriod { get; set; }
        public double? ReliefOnGross { get; set; }
        public DateTime? CurrentPeriod { get; set; }
        public int? AverageWrkAge { get; set; }
        public double? WorkingHrs { get; set; }
        public string PostingCompanyId { get; set; }
        public string PostingDivisionId { get; set; }
        public string PostingDepartmentId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? WorkingDays { get; set; }
        public string TaxType { get; set; }
        public string ReliefType { get; set; }
        public bool? Prorate { get; set; }
        public DateTime? ResumptionTime { get; set; }
        public DateTime? GraceTime { get; set; }
        public DateTime? MidMonthDate { get; set; }
        public DateTime? MidMonthPeriod { get; set; }
        public string PorationBasis { get; set; }
        public string Email { get; set; }
        public string EmailClosed { get; set; }
        public string SalaryAccount { get; set; }
        public bool? GrossUpNonStatutoryforTax { get; set; }
        public bool? BioSaturday { get; set; }
        public bool? BioSunday { get; set; }
        public int? NoofLatenessAsAbsent { get; set; }
        public string JournalBasis { get; set; }
        public bool? PostJvasSummary { get; set; }
        public bool? ConsolidateBillPerCostCentre { get; set; }
        public int? PromotionInAyear { get; set; }
        public int? DurationBeforeFirstPromotion { get; set; }
        public bool? TaxRulesSubjectValue { get; set; }
        public bool? AutoPromotion { get; set; }
        public bool? PayrollProcessed { get; set; }
        public string BranchCode { get; set; }
        public string HrreportPassword { get; set; }
    }
}
