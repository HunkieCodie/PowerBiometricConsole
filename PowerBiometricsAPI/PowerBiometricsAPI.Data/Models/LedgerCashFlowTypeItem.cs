using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LedgerCashFlowTypeItem
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CashFlowType { get; set; }
        public string CashFlowItem { get; set; }
        public string CashFlowItemDescription { get; set; }
        public string SortOrder { get; set; }
        public bool? IsDirectCashFlow { get; set; }
        public bool? IsInDirectCashFlow { get; set; }
        public int? BalanceType { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
