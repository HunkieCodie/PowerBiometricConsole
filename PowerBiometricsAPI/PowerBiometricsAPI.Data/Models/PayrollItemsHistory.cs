using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollItemsHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string PayrollItemId { get; set; }
        public string PayrollItemDescription { get; set; }
        public string Basis { get; set; }
        public string PayrollItemTypeId { get; set; }
        public decimal? Ytdmaximum { get; set; }
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
        public string W2box1 { get; set; }
        public string W2box2 { get; set; }
        public string W2box3 { get; set; }
        public string W2box4 { get; set; }
        public string W2box5 { get; set; }
        public string W2box6 { get; set; }
        public string W2box7 { get; set; }
        public string W2box8 { get; set; }
        public string W2box9 { get; set; }
        public string W2box10 { get; set; }
        public string W2box11 { get; set; }
        public string W2box12 { get; set; }
        public string W2box13 { get; set; }
        public string W2box13b { get; set; }
        public string W2box14 { get; set; }
        public string W2box15 { get; set; }
        public string W2box17 { get; set; }
        public string W2box18 { get; set; }
        public string W2box20 { get; set; }
        public string W2box21 { get; set; }
        public string Frm941Line2 { get; set; }
        public string Frm941Line3 { get; set; }
        public string Frm941Line4 { get; set; }
        public string Frm941Line6a { get; set; }
        public string Frm941Line6b { get; set; }
        public string Frm941Line7 { get; set; }
        public string Frm941Line9 { get; set; }
        public string Frm941Line12 { get; set; }
        public string DefaultItem { get; set; }
        public string BranchCode { get; set; }
    }
}
