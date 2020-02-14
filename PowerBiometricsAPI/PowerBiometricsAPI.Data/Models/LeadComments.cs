﻿using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LeadComments
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CommentNumber { get; set; }
        public string LeadId { get; set; }
        public DateTime? CommentDate { get; set; }
        public string CommentType { get; set; }
        public string Comment { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
