using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PosshiftCartTable
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ShiftId { get; set; }
        public string OrderNumber { get; set; }
        public int OrderLineNumber { get; set; }
        public string EmployeeId { get; set; }
        public string TerminalId { get; set; }
        public string CustomerId { get; set; }
        public DateTime? TransDateTime { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string CurrencyId { get; set; }
        public string WarehouseId { get; set; }
        public int? ItemWeight { get; set; }
        public bool? Taxable { get; set; }
        public bool? Remove { get; set; }
        public string TaxGroupId { get; set; }
        public decimal? TaxAmount { get; set; }
        public string PictureUrl { get; set; }
        public double? ItemTaxPercent { get; set; }
        public decimal? ItemTotalAmount { get; set; }
        public decimal? ItemCost { get; set; }
        public string SalesTaxGroupId { get; set; }
        public double? SalesTaxPercent { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? DiscountPer { get; set; }
        public double? DiscountAmt { get; set; }
        public bool? Status { get; set; }
        public bool? Posted { get; set; }
        public int? NoOfPerson { get; set; }
        public bool? Served { get; set; }
        public DateTime? OrderStartDateTime { get; set; }
        public DateTime? OrderEndDateTime { get; set; }
        public bool? Reconcilled { get; set; }
        public bool? Void { get; set; }
        public DateTime? LastEditDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string VoidBy { get; set; }
        public string VoidReason { get; set; }
        public string ItemCategoryId { get; set; }
        public bool? Closed { get; set; }
        public string WarehouseBinId { get; set; }
        public bool? Tpintegrated { get; set; }
        public bool? ServeStatus { get; set; }
        public string TableId { get; set; }
        public string WaitressId { get; set; }
        public string ReceiveOrderCashier { get; set; }
        public string TrackingNumber { get; set; }
        public double? TrackingAmount { get; set; }
        public string CustomerPhone { get; set; }
        public string BranchCode { get; set; }
    }
}
