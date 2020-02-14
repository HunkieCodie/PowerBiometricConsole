using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryLedgerHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public DateTime TransDate { get; set; }
        public string ItemId { get; set; }
        public string TransNumber { get; set; }
        public decimal IllineNumber { get; set; }
        public string TransactionType { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public double? Quantity { get; set; }
        public decimal? CostPerUnit { get; set; }
        public decimal? TotalCost { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public decimal? Lifocost { get; set; }
        public decimal? AverageCost { get; set; }
        public decimal? Fifocost { get; set; }
        public decimal? ExpectedCost { get; set; }
        public decimal? OtherCost { get; set; }
        public decimal? StandardCost { get; set; }
        public double? BalanceQty { get; set; }
        public decimal BatchNumber { get; set; }
        public string AccountName { get; set; }
        public string OriginalDocumentNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string BranchCode { get; set; }
    }
}
