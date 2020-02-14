using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CurrencyTypesHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CurrencyId { get; set; }
        public DateTime CurrencyIddateTime { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string BranchCode { get; set; }
    }
}
