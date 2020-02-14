using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollDisciplinaryDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string DisciplinaryId { get; set; }
        public string EmployeeId { get; set; }
        public string Note { get; set; }
        public decimal? Amount { get; set; }
        public int? NoOfDays { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public DateTime? Date { get; set; }
        public string Employeename { get; set; }
        public string BranchCode { get; set; }
    }
}
