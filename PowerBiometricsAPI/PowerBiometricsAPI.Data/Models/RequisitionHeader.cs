using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class RequisitionHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string RequisitionId { get; set; }
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
        public string HeaderMemo1 { get; set; }
        public string HeaderMemo2 { get; set; }
        public string HeaderMemo3 { get; set; }
        public string HeaderMemo4 { get; set; }
        public string HeaderMemo5 { get; set; }
        public string HeaderMemo6 { get; set; }
        public string HeaderMemo7 { get; set; }
        public string HeaderMemo8 { get; set; }
        public string HeaderMemo9 { get; set; }
        public string HeaderMemo10 { get; set; }
        public string HeaderMemo11 { get; set; }
        public string HeaderMemo12 { get; set; }
        public string Ullage1 { get; set; }
        public string Ullage2 { get; set; }
        public string Ullage3 { get; set; }
        public string Ullage4 { get; set; }
        public string Ullage5 { get; set; }
        public string Ullage6 { get; set; }
        public string Ullage7 { get; set; }
        public string Ullage8 { get; set; }
        public string Ullage9 { get; set; }
        public string Ullage10 { get; set; }
        public string Ullage11 { get; set; }
        public string Ullage12 { get; set; }
        public string CustomerName { get; set; }
        public string BranchCode { get; set; }
    }
}
