using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PosbalancePay
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ShiftId { get; set; }
        public string OrderNumber { get; set; }
        public decimal? ChangeAmount { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? Posted { get; set; }
        public string BranchCode { get; set; }
    }
}
