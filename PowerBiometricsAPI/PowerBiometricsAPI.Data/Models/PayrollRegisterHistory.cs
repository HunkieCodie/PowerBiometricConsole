using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollRegisterHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PayrollId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? PayrollDate { get; set; }
        public DateTime? PayPeriodStartDate { get; set; }
        public DateTime? PayPeriodEndDate { get; set; }
        public string CheckTypeId { get; set; }
        public DateTime? PayrollCheckDate { get; set; }
        public DateTime? SystemDate { get; set; }
        public string CheckNumber { get; set; }
        public decimal? PreTax { get; set; }
        public decimal? Ytdgross { get; set; }
        public decimal? Gross { get; set; }
        public decimal? Agi { get; set; }
        public decimal? Fica { get; set; }
        public decimal? Ficaer { get; set; }
        public decimal? Fit { get; set; }
        public decimal? Futa { get; set; }
        public decimal? StateTax { get; set; }
        public decimal? CountyTax { get; set; }
        public decimal? CityTax { get; set; }
        public decimal? Ficamed { get; set; }
        public decimal? Suta { get; set; }
        public decimal? Sit { get; set; }
        public decimal? Sdi { get; set; }
        public decimal? Lui { get; set; }
        public decimal? Additions { get; set; }
        public decimal? Commission { get; set; }
        public decimal? Deductions { get; set; }
        public decimal? NetPay { get; set; }
        public bool? Voided { get; set; }
        public bool? Reconciled { get; set; }
        public bool? Printed { get; set; }
        public double? RegularHours { get; set; }
        public double? OvertimeHours { get; set; }
        public decimal? OvertimeRate { get; set; }
        public decimal? HourlyRate { get; set; }
        public decimal? Amount { get; set; }
        public string BranchCode { get; set; }
    }
}
