using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Projects
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string CustomerId { get; set; }
        public string ProjectTypeId { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectCompleteDate { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? ProjectEstRevenue { get; set; }
        public decimal? ProjectActualRevenue { get; set; }
        public decimal? ProjectEstCost { get; set; }
        public decimal? ProjectActualCost { get; set; }
        public string EmployeeId { get; set; }
        public string ProjectNotes { get; set; }
        public string GlsalesAccount { get; set; }
        public bool? ProjectOpen { get; set; }
        public bool? Memorize { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string OrderNumber { get; set; }
        public decimal? ProjectOrderValue { get; set; }
        public decimal? ProjectAbsorbedCost { get; set; }
        public string Glcosaccount { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? Cleared { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? ClearedDate { get; set; }
        public bool? Void { get; set; }
        public double? Commission { get; set; }
        public string BranchCode { get; set; }
    }
}
