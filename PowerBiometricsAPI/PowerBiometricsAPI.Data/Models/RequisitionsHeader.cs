using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class RequisitionsHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string RequisitionId { get; set; }
        public string RequisitionTypeId { get; set; }
        public DateTime? RequisitionDate { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string Description { get; set; }
        public string EntityId { get; set; }
        public double? SubTotal { get; set; }
        public double? Total { get; set; }
        public DateTime? SystemDate { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public bool? Cleared { get; set; }
        public string ClearedBy { get; set; }
        public string ClearedDate { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string RequestedBy { get; set; }
        public bool? Posted { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public string BranchCode { get; set; }
    }
}
