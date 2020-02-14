using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PurchaseAddonCostHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PurchaseNumber { get; set; }
        public string TransactionTypeId { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? Total { get; set; }
        public string EnteredBy { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ReceivingNumber { get; set; }
        public bool? Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
