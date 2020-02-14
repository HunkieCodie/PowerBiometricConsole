using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeesExit
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeTypeId { get; set; }
        public string EmployeeUserName { get; set; }
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
        public string EmployeeDepartmentId { get; set; }
        public string PictureUrl { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? Commissionable { get; set; }
        public double? CommissionPerc { get; set; }
        public string CommissionCalcMethod { get; set; }
        public string EmployeeManager { get; set; }
        public string EmployeeRegionId { get; set; }
        public string EmployeeSourceId { get; set; }
        public string EmployeeIndustryId { get; set; }
        public string Notes { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinNumber { get; set; }
        public string EmployeeCounty { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string EnteredBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public DateTime? LastEditDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string DocumentId { get; set; }
        public string EmployeeFirstname { get; set; }
        public string EmployeeOthername { get; set; }
        public string TitleId { get; set; }
        public string EmployeeHomephone { get; set; }
        public string EmployeeOfficephone { get; set; }
        public string EmployeeOfficeExt { get; set; }
        public string EmployeeAddress3 { get; set; }
        public string EmployeeAddress4 { get; set; }
        public string EmployeeAddress5 { get; set; }
        public string Pfaid { get; set; }
        public string BankId { get; set; }
        public string DesignationId { get; set; }
        public string EmployeeManagerId { get; set; }
        public string ContractTypeId { get; set; }
        public string CurrencyId { get; set; }
        public string EmployeeMaidenName { get; set; }
        public bool? Disabled { get; set; }
        public string Pfano { get; set; }
        public string GenderId { get; set; }
        public string StatusId { get; set; }
        public string StateId { get; set; }
        public string NationalityId { get; set; }
        public string LanguageId { get; set; }
        public string GradeId { get; set; }
        public string AccountNo { get; set; }
        public string GroupId { get; set; }
        public bool? Taxable { get; set; }
        public string JobClassId { get; set; }
        public string Location { get; set; }
        public string CostCenter { get; set; }
        public double? BaseValue { get; set; }
        public double? MonthlyTax { get; set; }
        public double? YearToDateTax { get; set; }
        public string Department { get; set; }
        public DateTime? PromotionDate { get; set; }
        public string WorkedDays { get; set; }
        public DateTime? LastPayDate { get; set; }
        public DateTime? PensionDate { get; set; }
        public string StatePaye { get; set; }
        public decimal? Gross { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public string GroupDescription { get; set; }
        public byte[] Picture { get; set; }
        public bool? Cleared { get; set; }
        public string EmployeeActivityTypeId { get; set; }
        public bool? ProvideForTax { get; set; }
        public string BranchCode { get; set; }
    }
}
