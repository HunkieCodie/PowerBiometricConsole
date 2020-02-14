using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class HelpMessageHeading
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string MessageHeadingId { get; set; }
        public string MessageHeadingTitle { get; set; }
        public string MessageHeadingDescription { get; set; }
        public string MessageHeadingPictureUrl { get; set; }
        public DateTime? MessageHeadingDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
