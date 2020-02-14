using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollAutoIncrementType
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string AutoIncrementTypeId { get; set; }
        public string AutoIncrementDescription { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
    }
}
