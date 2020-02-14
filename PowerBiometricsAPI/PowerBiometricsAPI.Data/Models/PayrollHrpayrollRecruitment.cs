using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollRecruitment
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string RecruitId { get; set; }
        public string RecruitTypeId { get; set; }
        public string TitleId { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Othername { get; set; }
        public bool? Confirmed { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string MobilePhone { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
        public byte[] Picture { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? Birthday { get; set; }
        public string GenderId { get; set; }
        public string StatusId { get; set; }
        public string NationalityId { get; set; }
        public string StateId { get; set; }
        public string LanguageId { get; set; }
        public bool? Disabled { get; set; }
        public string EmployeeZip { get; set; }
        public string Notes { get; set; }
        public string CurrencyId { get; set; }
        public bool? Cleared { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public DateTime? FirstGraduationDate { get; set; }
        public DateTime? ServiceYrCompletionDate { get; set; }
        public int? YearsOfExp { get; set; }
        public string BranchCode { get; set; }
    }
}
