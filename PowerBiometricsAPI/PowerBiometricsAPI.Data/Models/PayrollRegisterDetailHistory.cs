using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollRegisterDetailHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PayrollId { get; set; }
        public string PayrollItemId { get; set; }
        public string EmployeeId { get; set; }
        public string Description { get; set; }
        public string Basis { get; set; }
        public string Type { get; set; }
        public decimal? Ytdmax { get; set; }
        public decimal? Minimum { get; set; }
        public decimal? WageHigh { get; set; }
        public decimal? WageLow { get; set; }
        public decimal? ItemAmount { get; set; }
        public double? ItemPercent { get; set; }
        public decimal? PercentAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public bool? ApplyItem { get; set; }
        public string Glaccount { get; set; }
        public string Glaccount2 { get; set; }
        public string Glaccount3 { get; set; }
        public decimal? EmployerItemAmount { get; set; }
        public double? EmployerItemPercent { get; set; }
        public decimal? EmployerPercentAmount { get; set; }
        public decimal? EmployerTotalAmount { get; set; }
        public bool? Employer { get; set; }
        public string BranchCode { get; set; }
    }
}
