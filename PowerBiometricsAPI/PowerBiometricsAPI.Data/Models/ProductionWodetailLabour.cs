using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class ProductionWodetailLabour
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string Woid { get; set; }
        public string AssemblyId { get; set; }
        public string LabourTypeId { get; set; }
        public double? NumberOfWorkers { get; set; }
        public double? EstimatedHours { get; set; }
        public double? EstimatedCost { get; set; }
        public double? ActualHours { get; set; }
        public double? ActualCost { get; set; }
        public string UnitOfMeasure { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public double? ProductionUnit { get; set; }
        public string Notes { get; set; }
        public DateTime? SystemDate { get; set; }
        public bool? Cleared { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
