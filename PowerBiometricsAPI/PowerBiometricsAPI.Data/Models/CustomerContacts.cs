using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerContacts
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CustomerId { get; set; }
        public string ContactId { get; set; }
        public string ContactType { get; set; }
        public string ContactDescription { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactDepartment { get; set; }
        public string ContactSource { get; set; }
        public string ContactSalutation { get; set; }
        public string ContactIndustry { get; set; }
        public string ContactAddress1 { get; set; }
        public string ContactAddress2 { get; set; }
        public string ContactAddress3 { get; set; }
        public string ContactCity { get; set; }
        public string ContactState { get; set; }
        public string ContactZip { get; set; }
        public string ContactPhone { get; set; }
        public string ContactPhone2 { get; set; }
        public string ContactPhone3 { get; set; }
        public string ContactFax { get; set; }
        public string ContactCellular { get; set; }
        public string ContactPager { get; set; }
        public string ContactEmail { get; set; }
        public string ContactWebPage { get; set; }
        public string ContactLogin { get; set; }
        public string ContactPassword { get; set; }
        public string ContactPasswordOld { get; set; }
        public DateTime? ContactPasswordDate { get; set; }
        public bool? ContactPasswordExpires { get; set; }
        public int? ContactPasswordExpiresDate { get; set; }
        public string ContactRegion { get; set; }
        public string ContactNotes { get; set; }
        public string ContactCallingRestrictions { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? Commission { get; set; }
        public string BranchCode { get; set; }
    }
}
