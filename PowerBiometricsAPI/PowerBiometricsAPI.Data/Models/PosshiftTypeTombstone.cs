﻿using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PosshiftTypeTombstone
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ShiftTypeId { get; set; }
        public DateTime? DeletionDate { get; set; }
        public string BranchCode { get; set; }
    }
}
