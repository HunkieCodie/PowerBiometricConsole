using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PosdailyCash
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string OrderNumber { get; set; }
        public int PosdailyCash1 { get; set; }
        public DateTime? CashDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? CashOpen { get; set; }
        public decimal? CashClose { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
