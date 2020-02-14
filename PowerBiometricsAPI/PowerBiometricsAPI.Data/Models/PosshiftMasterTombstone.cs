using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PosshiftMasterTombstone
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public int ShiftId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? DeletionDate { get; set; }
        public string BranchCode { get; set; }
    }
}
