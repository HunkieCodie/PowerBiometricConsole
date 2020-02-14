using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class VendorComments
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string VendorId { get; set; }
        public int CommentLineId { get; set; }
        public DateTime? CommentDate { get; set; }
        public string CommentTypeId { get; set; }
        public string Comment { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
