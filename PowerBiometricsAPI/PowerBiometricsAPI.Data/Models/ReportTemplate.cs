using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class ReportTemplate
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ReportId { get; set; }
        public string Description { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? PeriodFrom { get; set; }
        public bool? PeriodTo { get; set; }
        public bool? ActiveYn { get; set; }
        public bool? FixedAsset { get; set; }
        public bool? FixedAssetFrom { get; set; }
        public bool? FixedAssetTo { get; set; }
        public bool? Payroll { get; set; }
        public bool? Ap { get; set; }
        public bool? Ar { get; set; }
        public bool? Cashbook { get; set; }
        public bool? Gl { get; set; }
        public bool? Inventory { get; set; }
        public bool? Production { get; set; }
        public bool? Pj { get; set; }
        public bool? ProjectTo { get; set; }
        public bool? Customer { get; set; }
        public bool? CustomerTo { get; set; }
        public bool? CustomerTypeFrom { get; set; }
        public bool? CustomerTypeTo { get; set; }
        public bool? VendorFrom { get; set; }
        public bool? VendorTo { get; set; }
        public bool? VendorTypeFrom { get; set; }
        public bool? ProjectTypeTo { get; set; }
        public bool? VendorTypeTo { get; set; }
        public bool? AccountFrom { get; set; }
        public bool? AccountTo { get; set; }
        public bool? AnalysisTypeFrom { get; set; }
        public bool? AnalysisTypeTo { get; set; }
        public bool? AnalysisFrom { get; set; }
        public bool? LedgerAccountFrom { get; set; }
        public bool? LedgerAccountTo { get; set; }
        public bool? AnalysisTo { get; set; }
        public bool? Bank { get; set; }
        public bool? BankAccountType { get; set; }
        public bool? ProjectFrom { get; set; }
        public bool? ProjectTypeFrom { get; set; }
        public bool? WarehouseFrom { get; set; }
        public bool? WarehouseTo { get; set; }
        public bool? WarehouseBinFrom { get; set; }
        public bool? WarehouseBinTo { get; set; }
        public bool? ItemFrom { get; set; }
        public bool? ItemTo { get; set; }
        public bool? TransactionFrom { get; set; }
        public bool? TransactionTo { get; set; }
        public string BranchCode { get; set; }
    }
}
