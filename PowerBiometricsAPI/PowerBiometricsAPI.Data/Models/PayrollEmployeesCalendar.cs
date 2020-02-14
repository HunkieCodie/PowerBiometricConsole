using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeesCalendar
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime AppointmenStart { get; set; }
        public DateTime? AppointmentEnd { get; set; }
        public string AppointmentReason { get; set; }
        public string AppointmentDescription { get; set; }
        public string RelatedTaskId { get; set; }
        public string RelatedDocumentId { get; set; }
        public string RelatedCustomerId { get; set; }
        public string RelatedLeadId { get; set; }
        public string RelatedVendorId { get; set; }
        public string AppointmentNotes { get; set; }
        public string RequestedBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
