using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class BankAccountsType
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BankAccountTypeId { get; set; }
        public string BankAccountTypeDescription { get; set; }
        public string Prefix { get; set; }
        public string NextNumberValue { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Posted { get; set; }
        public string BranchCode { get; set; }
    }
}
