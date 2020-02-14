using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollDocumentation
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public int DocId { get; set; }
        public string DocDescription { get; set; }
        public DateTime? DocDate { get; set; }
        public string DocLocation { get; set; }
        public string Remarks { get; set; }
        public byte[] Picture { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
