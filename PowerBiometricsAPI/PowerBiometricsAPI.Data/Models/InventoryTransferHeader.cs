using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryTransferHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string InventoryTransferId { get; set; }
        public string AdjustmentTypeId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public DateTime? SystemDate { get; set; }
        public string Notes { get; set; }
        public bool? Cleared { get; set; }
        public string EnteredBy { get; set; }
        public bool? Void { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? Issued { get; set; }
        public string IssuedBy { get; set; }
        public bool? Posted { get; set; }
        public string BatchControlNumber { get; set; }
        public decimal? BatchControlTotal { get; set; }
        public string Signature { get; set; }
        public string SignaturePassword { get; set; }
        public string SupervisorSignature { get; set; }
        public string SupervisorPassword { get; set; }
        public string ManagerSignature { get; set; }
        public string ManagerPassword { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public bool? InterTransfer { get; set; }
        public string ToCompanyId { get; set; }
        public string ToDivisionId { get; set; }
        public string ToDepartmentId { get; set; }
        public string LoadingOfficer { get; set; }
        public decimal? Rate { get; set; }
        public string BranchCode { get; set; }
    }
}
