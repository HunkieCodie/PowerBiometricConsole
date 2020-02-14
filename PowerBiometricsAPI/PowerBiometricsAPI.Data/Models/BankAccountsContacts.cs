using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class BankAccountsContacts
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BankId { get; set; }
        public string ContactId { get; set; }
        public string ContactTypeId { get; set; }
        public string ContactDescription { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactAddress1 { get; set; }
        public string ContactAddress2 { get; set; }
        public string ContactAddress3 { get; set; }
        public string ContactCity { get; set; }
        public string ContactState { get; set; }
        public string ContactZip { get; set; }
        public string ContactPhone { get; set; }
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
        public DateTime? ContactPasswordExpiresDate { get; set; }
        public string ContactRegion { get; set; }
        public string ContactNotes { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
