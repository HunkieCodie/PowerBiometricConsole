using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerTypes
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CustomerTypeId { get; set; }
        public string CustomerTypeDescription { get; set; }
        public string SalesControlAccount { get; set; }
        public string CoscontrolAccount { get; set; }
        public string DebtorsControlAccount { get; set; }
        public string CurrencyExchangeGainOrLossAccount { get; set; }
        public string DiscountsAccount { get; set; }
        public double? DiscountRate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BillingType { get; set; }
        public string BranchCode { get; set; }
    }
}
