using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryByWarehouseTombstone
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ItemId { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public DateTime? DeletionDate { get; set; }
        public string BranchCode { get; set; }
    }
}
