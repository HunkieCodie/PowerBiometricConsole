using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Ediexceptions
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ExceptionId { get; set; }
        public string ExceptionTypeId { get; set; }
        public string DirectionId { get; set; }
        public string DocumentId { get; set; }
        public string ExactErrorMessage { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
