﻿using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeesTaskPriority
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PriorityId { get; set; }
        public string PriorityDescription { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
