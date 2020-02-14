using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class BankAccounts
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BankId { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public string BankAddress1 { get; set; }
        public string BankAddress2 { get; set; }
        public string BankCity { get; set; }
        public string BankState { get; set; }
        public string BankZip { get; set; }
        public string BankCountry { get; set; }
        public string BankPhone { get; set; }
        public string BankFax { get; set; }
        public string BankContactName { get; set; }
        public string BankEmail { get; set; }
        public string BankWebsite { get; set; }
        public string SwiftCode { get; set; }
        public string RoutingCode { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public int? NextCheckNumber { get; set; }
        public int? NextDepositNumber { get; set; }
        public decimal? Balance { get; set; }
        public decimal? UnpostedDeposits { get; set; }
        public string GlbankAccount { get; set; }
        public string Notes { get; set; }
        public string CorrespondentBankId { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string EnteredBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BankAccountTypeId { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string ChequeNo { get; set; }
        public string FirstSign { get; set; }
        public string SecondSign { get; set; }
        public string FirstDesign { get; set; }
        public string SecondDesign { get; set; }
        public string BranchCode { get; set; }
    }
}
