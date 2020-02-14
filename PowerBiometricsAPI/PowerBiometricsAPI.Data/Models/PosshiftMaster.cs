using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PosshiftMaster
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public int ShiftId { get; set; }
        public string EmployeeId { get; set; }
        public string TerminalId { get; set; }
        public decimal? OpeningBalance { get; set; }
        public decimal? CurrentBalance { get; set; }
        public decimal? ClosingBalance { get; set; }
        public DateTime? ShiftOpenDate { get; set; }
        public DateTime? ShiftOpenTime { get; set; }
        public DateTime? ShiftCloseDate { get; set; }
        public DateTime? ShiftCloseTime { get; set; }
        public string LastEmployeeId { get; set; }
        public string NextEmployeeId { get; set; }
        public bool? ShiftOpen { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string MachineName { get; set; }
        public decimal? LeaveAmt { get; set; }
        public DateTime? LastEditDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ShiftOpenBy { get; set; }
        public string ShiftClosedBy { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? NextTransNumber { get; set; }
        public string BranchCode { get; set; }
    }
}
