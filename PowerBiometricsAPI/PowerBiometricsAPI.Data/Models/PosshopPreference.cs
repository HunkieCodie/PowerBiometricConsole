using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PosshopPreference
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopDepartmentId { get; set; }
        public string ShopDivisionId { get; set; }
        public string CossalesAccount { get; set; }
        public string SalesAccount { get; set; }
        public string StockAccount { get; set; }
        public string DebtorCashAccount { get; set; }
        public bool? ServiceCharge { get; set; }
        public double? ServiceChargeRate { get; set; }
        public string ServerIpname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public bool? TaxCharge { get; set; }
        public double? TaxRate { get; set; }
        public string WareHouseId { get; set; }
        public string WareHouseBinId { get; set; }
        public string BankId { get; set; }
        public string TaxGroup { get; set; }
        public int? NextOrderNumber { get; set; }
        public string DisplayPort { get; set; }
        public int? ReceiptCopies { get; set; }
        public bool? PayChange { get; set; }
        public string Ftpconfiguration { get; set; }
        public string UserName { get; set; }
        public string FtpaccessCode { get; set; }
        public string FtpcompanyCode { get; set; }
        public string FtpbranchCode { get; set; }
        public int? TimeSetup { get; set; }
        public bool? AmountTendered { get; set; }
        public bool? AllowAppShutdown { get; set; }
        public int? EndofDayDuration { get; set; }
        public bool? EndofDayDurationTrigger { get; set; }
        public string BranchCode { get; set; }
    }
}
