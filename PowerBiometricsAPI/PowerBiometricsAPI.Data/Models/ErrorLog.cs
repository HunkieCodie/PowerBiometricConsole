using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class ErrorLog
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public int ErrorId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? ErrorDate { get; set; }
        public DateTime? ErrorTime { get; set; }
        public string ScreenName { get; set; }
        public string ModuleName { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ProcedureName { get; set; }
        public DateTime? CallTime { get; set; }
        public string Error { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
