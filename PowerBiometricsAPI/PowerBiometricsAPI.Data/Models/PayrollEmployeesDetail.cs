using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeesDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public bool? PayYn { get; set; }
        public string PayType { get; set; }
        public string PayFrequency { get; set; }
        public decimal? Salary { get; set; }
        public decimal? HourlyRate { get; set; }
        public int? CommissionCalc { get; set; }
        public double? ComissionPerc { get; set; }
        public decimal? OvertimeRate { get; set; }
        public bool? Ficayn { get; set; }
        public bool? Fityn { get; set; }
        public bool? FicamedYn { get; set; }
        public bool? Futayn { get; set; }
        public bool? Sutayn { get; set; }
        public bool? Sityn { get; set; }
        public bool? Sdiyn { get; set; }
        public bool? LocalYn { get; set; }
        public bool? Luiyn { get; set; }
        public int? FederalAllowance { get; set; }
        public int? StateAllowance { get; set; }
        public int? CountyAllowance { get; set; }
        public int? CityAllowance { get; set; }
        public decimal? FederalWithholdingAmount { get; set; }
        public decimal? StateWithholdingAmount { get; set; }
        public decimal? CountyWithhoddingAmount { get; set; }
        public decimal? CityWithhoddingAmount { get; set; }
        public decimal? OtherAmount { get; set; }
        public string FederalFilingStatus { get; set; }
        public string StateFilingStatus { get; set; }
        public string CountyFilingStatus { get; set; }
        public string CityFilingStatus { get; set; }
        public string OtherStatus { get; set; }
        public int? Dependents { get; set; }
        public string MaleFemale { get; set; }
        public decimal? Amount { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? Additions { get; set; }
        public decimal? Deductions { get; set; }
        public decimal? PreTaxedAmount { get; set; }
        public decimal? BlankCheckHourlyRate { get; set; }
        public decimal? BlankCheckOvertimeRate { get; set; }
        public decimal? YearToDateGross { get; set; }
        public decimal? YearToDateAgi { get; set; }
        public decimal? YearToDateFica { get; set; }
        public decimal? YearToDateFit { get; set; }
        public decimal? YearToDateFicamed { get; set; }
        public decimal? YearToDateFuta { get; set; }
        public decimal? YearToDateSuta { get; set; }
        public decimal? YearToDateSit { get; set; }
        public decimal? YearToDateSdi { get; set; }
        public decimal? YearToDateLocal { get; set; }
        public decimal? YearToDateLui { get; set; }
        public decimal? LastGross { get; set; }
        public decimal? LastAgi { get; set; }
        public decimal? LastFica { get; set; }
        public decimal? LastFit { get; set; }
        public decimal? LastFicamed { get; set; }
        public decimal? LastFuta { get; set; }
        public decimal? LastSuta { get; set; }
        public decimal? LastSit { get; set; }
        public decimal? LastSdi { get; set; }
        public decimal? LastLocal { get; set; }
        public decimal? LastLui { get; set; }
        public decimal? LastCommissionAmount { get; set; }
        public float? YearToDateRegularHours { get; set; }
        public float? YearToDateOvertimeHours { get; set; }
        public float? LastHours { get; set; }
        public DateTime? LastPayDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
