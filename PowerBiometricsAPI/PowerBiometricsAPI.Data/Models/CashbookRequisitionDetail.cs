using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CashbookRequisitionDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string Id { get; set; }
        public DateTime? DateOfTransaction { get; set; }
        public decimal? Amount { get; set; }
        public string Description { get; set; }
        public int AutoNumber { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
