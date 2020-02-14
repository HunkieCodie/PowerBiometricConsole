using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class HelpNewsBoard
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string NewsId { get; set; }
        public string NewsProductId { get; set; }
        public string NewsTitle { get; set; }
        public DateTime? NewsDate { get; set; }
        public string NewsMessage { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
