using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LeadInformation
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string LeadId { get; set; }
        public string LeadCompany { get; set; }
        public string LeadLastName { get; set; }
        public string LeadFirstName { get; set; }
        public string LeadSalutation { get; set; }
        public string LeadAddress1 { get; set; }
        public string LeadAddress2 { get; set; }
        public string LeadAddress3 { get; set; }
        public string LeadCity { get; set; }
        public string LeadState { get; set; }
        public string LeadZip { get; set; }
        public string LeadCountry { get; set; }
        public string LeadEmail { get; set; }
        public string LeadWebPage { get; set; }
        public string LeadPhone { get; set; }
        public string LeadFax { get; set; }
        public string LeadLogin { get; set; }
        public string LeadPassword { get; set; }
        public string LeadPasswordOld { get; set; }
        public DateTime? LeadPasswordDate { get; set; }
        public bool? LeadPasswordExpires { get; set; }
        public int? LeadPasswordExpiresDate { get; set; }
        public short? LeadSecurityGroup { get; set; }
        public string Attention { get; set; }
        public string EmployeeId { get; set; }
        public string CurrencyId { get; set; }
        public string LeadTypeId { get; set; }
        public string LeadRegionId { get; set; }
        public string LeadSourceId { get; set; }
        public string LeadIndustryId { get; set; }
        public DateTime? FirstContacted { get; set; }
        public DateTime? LastFollowUp { get; set; }
        public DateTime? NextFollowUp { get; set; }
        public bool? ReferedByExistingCustomer { get; set; }
        public string ReferedBy { get; set; }
        public DateTime? ReferedDate { get; set; }
        public string ReferalUrl { get; set; }
        public DateTime? LastVisit { get; set; }
        public string Ipaddress { get; set; }
        public long? NumberOfVisits { get; set; }
        public string PrimaryInterest { get; set; }
        public bool? Confirmed { get; set; }
        public bool? Validated { get; set; }
        public bool? OptInEmail { get; set; }
        public bool? Newsletter { get; set; }
        public bool? OptInNewsletter { get; set; }
        public bool? MessageBoard { get; set; }
        public bool? Portal { get; set; }
        public bool? Hot { get; set; }
        public bool? ConvertedToCustomer { get; set; }
        public string ConvertedToCustomerBy { get; set; }
        public DateTime? ConvertedToCustomerDate { get; set; }
        public string LeadMemo1 { get; set; }
        public string LeadMemo2 { get; set; }
        public string LeadMemo3 { get; set; }
        public string LeadMemo4 { get; set; }
        public string LeadMemo5 { get; set; }
        public string LeadMemo6 { get; set; }
        public string LeadMemo7 { get; set; }
        public string LeadMemo8 { get; set; }
        public string LeadMemo9 { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? Commission { get; set; }
        public bool? Revocated { get; set; }
        public string BranchCode { get; set; }
    }
}
