using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PoscashUp
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CashierId { get; set; }
        public string Amount { get; set; }
        public DateTime? CashupDate { get; set; }
        public string ShifType { get; set; }
        public string Sales { get; set; }
        public string Receipt { get; set; }
        public string TerminalId { get; set; }
        public string SupervisorId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
