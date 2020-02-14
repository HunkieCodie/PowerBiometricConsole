using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollAutoIncrementHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string AutoIncrementId { get; set; }
        public DateTime AutoIncrementPeriod { get; set; }
        public string AutoIncrementTypeId { get; set; }
        public string AutoIncrementDescription { get; set; }
        public DateTime? SystemDate { get; set; }
        public string EnteredBy { get; set; }
        public bool? Cleared { get; set; }
        public string ClearedBy { get; set; }
        public DateTime? ClearedDate { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
    }
}
