using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CurrencyTypes
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CurrencyId { get; set; }
        public string CurrencyType { get; set; }
        public string CurrenycySymbol { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public DateTime? CurrencyRateLastUpdate { get; set; }
        public int? CurrencyPrecision { get; set; }
        public string MajorUnits { get; set; }
        public string MinorUnits { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
