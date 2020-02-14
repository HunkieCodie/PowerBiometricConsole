using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Wipheader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string WorkOrderId { get; set; }
        public string WorkOrderNumber { get; set; }
        public string WorkOrderBomnumber { get; set; }
        public DateTime? WorkOrderIssuedDate { get; set; }
        public string WorkOrderReference { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public string FgwarehouseId { get; set; }
        public string FgwarehouseBinId { get; set; }
        public double? QuantityToProduced { get; set; }
        public double? QuantityProduced { get; set; }
        public double? QuantityProducedToDate { get; set; }
        public double? YieldVariance { get; set; }
        public bool? Completed { get; set; }
        public string CompletedBy { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string ProductionReference { get; set; }
        public DateTime? SystemDate { get; set; }
        public decimal? WorkOrderBomunitCost { get; set; }
        public decimal? WorkOrderBomunitLabor { get; set; }
        public decimal? WorkOrderBomotherCost { get; set; }
        public decimal? WorkOrderTotalCost { get; set; }
        public decimal? NewBomitemCost { get; set; }
        public string MaterialIssueVarianceAccount { get; set; }
        public string ProjectId { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string AdditionalCostAccount { get; set; }
        public string BranchCode { get; set; }
    }
}
