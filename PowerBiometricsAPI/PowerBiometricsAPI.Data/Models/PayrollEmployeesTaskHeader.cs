using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeesTaskHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeTaskId { get; set; }
        public string TaskTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? Completed { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string PriorityId { get; set; }
        public string RelatedDocumentType { get; set; }
        public string RelatedDocumentNumber { get; set; }
        public string LeadId { get; set; }
        public string CustomerId { get; set; }
        public string VendorId { get; set; }
        public string Description { get; set; }
        public string DelegatedTo { get; set; }
        public DateTime? DelegatedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public bool? Cleared { get; set; }
        public string EnteredBy { get; set; }
        public bool? Posted { get; set; }
        public string PostedBy { get; set; }
        public bool? Void { get; set; }
        public string BranchCode { get; set; }
    }
}
