using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PosshiftTransByPaymentType
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ShiftId { get; set; }
        public string PosreceiptId { get; set; }
        public string OrderNumber { get; set; }
        public string PaymentType { get; set; }
        public string EmployeeId { get; set; }
        public string TerminalId { get; set; }
        public string CustomerId { get; set; }
        public DateTime? TransDateTime { get; set; }
        public string ChequeName { get; set; }
        public string ChequeNumber { get; set; }
        public decimal? OrderAmount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? BalanceDue { get; set; }
        public decimal? ChangeDue { get; set; }
        public bool? Status { get; set; }
        public bool? Reconcilled { get; set; }
        public bool? Void { get; set; }
        public DateTime? LastEditDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string BranchCode { get; set; }
    }
}
