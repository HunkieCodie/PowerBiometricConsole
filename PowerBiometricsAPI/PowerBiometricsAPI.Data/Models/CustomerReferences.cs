using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerReferences
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ReferenceId { get; set; }
        public string CustomerId { get; set; }
        public bool? Permission { get; set; }
        public string CompanyName { get; set; }
        public string ProjectName { get; set; }
        public string PerferedLanguage { get; set; }
        public string Country { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string AdditionalLastName { get; set; }
        public string Title { get; set; }
        public string Salutation { get; set; }
        public string Email { get; set; }
        public string PhoneCountry { get; set; }
        public string PhoneArea { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneExt { get; set; }
        public bool? VertConsumerBusinessMfg { get; set; }
        public bool? VertEducation { get; set; }
        public bool? VertFinancial { get; set; }
        public bool? VertGeneral { get; set; }
        public bool? VertGovernment { get; set; }
        public bool? VertHealthcare { get; set; }
        public bool? VertIndustrialManagement { get; set; }
        public bool? VertMedia { get; set; }
        public bool? VertNonProfit { get; set; }
        public bool? VertProfessional { get; set; }
        public bool? VertRetail { get; set; }
        public bool? VertTelecommunications { get; set; }
        public bool? ImplementedCompanyWide { get; set; }
        public bool? ImplementedWithinDepartments { get; set; }
        public bool? DeptHumanResources { get; set; }
        public bool? DeptInformationTechnology { get; set; }
        public bool? DeptAccountingFinance { get; set; }
        public bool? DeptResearch { get; set; }
        public bool? DeptMarketing { get; set; }
        public bool? DeptTravel { get; set; }
        public bool? DeptSales { get; set; }
        public bool? DeptDistributionWarehouse { get; set; }
        public bool? DeptOther { get; set; }
        public string NumberOfEmployees { get; set; }
        public string NumberOfUsers { get; set; }
        public string DescribeProject { get; set; }
        public string DescriptSolution { get; set; }
        public DateTime? LockTs { get; set; }
        public string LockedBy { get; set; }
        public string BranchCode { get; set; }
    }
}
