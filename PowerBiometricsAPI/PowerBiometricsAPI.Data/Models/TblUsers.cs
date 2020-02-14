using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class TblUsers
    {
        public int IdAgents { get; set; }
        public string CAgentName { get; set; }
        public string Accesscode { get; set; }
        public bool? IsSupervisor { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateTimeStamp { get; set; }
        public bool? ReportOnly { get; set; }
        public bool? ChangePassword { get; set; }
        public int? CashAccount { get; set; }
        public int? SalesAccount { get; set; }
        public int? Cosaccount { get; set; }
        public int? StockAccount { get; set; }
        public int? TaxAccount { get; set; }
        public int? TransactionType { get; set; }
        public int? TransactionTypeCrn { get; set; }
        public int? TransactionTypeIssue { get; set; }
        public int? TransactionTypeReceive { get; set; }
        public int? BranchId { get; set; }
        public string CustomerId { get; set; }
        public bool? Active { get; set; }
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BankId { get; set; }
        public bool? Discount { get; set; }
        public bool? PlaceOrder { get; set; }
        public bool? ReleaseOrder { get; set; }
        public bool? PayChange { get; set; }
        public bool? MultipleWarehouse { get; set; }
        public bool? PlaceOrderRecall { get; set; }
        public bool? ReleaseOrderEnforce { get; set; }
        public string BranchCode { get; set; }
    }
}
