using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeesHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeTypeId { get; set; }
        public string EmployeeName { get; set; }
        public bool? ActiveYn { get; set; }
        public string EmployeeAddress1 { get; set; }
        public string EmployeeAddress2 { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeState { get; set; }
        public string EmployeeZip { get; set; }
        public string EmployeeCountry { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeFax { get; set; }
        public string EmployeeSsnumber { get; set; }
        public string EmployeeEmailAddress { get; set; }
        public string EmployeeUserName { get; set; }
        public string EmployeePassword { get; set; }
        public string PictureUrl { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? Commissionable { get; set; }
        public double? CommissionPerc { get; set; }
        public string CommissionCalcMethod { get; set; }
        public string Notes { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinNumber { get; set; }
        public decimal? MonthToDateGross { get; set; }
        public decimal? MonthToDateFica { get; set; }
        public decimal? MonthToDateFederal { get; set; }
        public decimal? MonthToDateState { get; set; }
        public decimal? MonthToDateLocal { get; set; }
        public decimal? MonthToDateOther { get; set; }
        public decimal? QuarterToDateGross { get; set; }
        public decimal? QuarterToDateFica { get; set; }
        public decimal? QuarterToDateFederal { get; set; }
        public decimal? QuarterToDateState { get; set; }
        public decimal? QuarterToDateLocal { get; set; }
        public decimal? QuarterToDateOther { get; set; }
        public decimal? YearToDateGross { get; set; }
        public decimal? YearToDateFica { get; set; }
        public decimal? YearToDateFederal { get; set; }
        public decimal? YearToDateState { get; set; }
        public decimal? YearToDateLocal { get; set; }
        public decimal? YearToDateOther { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string EnteredBy { get; set; }
        public string BranchCode { get; set; }
    }
}
