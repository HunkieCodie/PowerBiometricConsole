using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class HelpMessageBoard
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string MessageHeadingId { get; set; }
        public string MessageTopicId { get; set; }
        public string MessageTitleId { get; set; }
        public string MessageParentTitleId { get; set; }
        public string ProductId { get; set; }
        public string MessageTitle { get; set; }
        public string MessageName { get; set; }
        public string MessageEmail { get; set; }
        public DateTime? MessageDate { get; set; }
        public string MessageText { get; set; }
        public string MessagePictureUrl { get; set; }
        public bool? Valid { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
