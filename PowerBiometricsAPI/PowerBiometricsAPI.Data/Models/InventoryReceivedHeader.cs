using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryReceivedHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string InventoryReceivedId { get; set; }
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
        public string Reference { get; set; }
        public string WarehouseCustomerId { get; set; }
        public string DeliveryNote { get; set; }
        public string SiteNumber { get; set; }
        public string VehicleRegistration { get; set; }
        public string DriversName { get; set; }
        public string Sbcnumber { get; set; }
        public string FromCompanyId { get; set; }
        public string FromDivisionId { get; set; }
        public string FromDepartmentId { get; set; }
        public string FromWarehouseId { get; set; }
        public string FromWarehouseBinId { get; set; }
        public string InventoryIssueTransferId { get; set; }
        public string BranchCode { get; set; }
    }
}
