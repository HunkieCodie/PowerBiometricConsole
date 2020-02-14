using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class HelpMessageTopic
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string MessageHeadingId { get; set; }
        public string MessageTopicId { get; set; }
        public string MessageTopicTitle { get; set; }
        public string MessageTopicDescription { get; set; }
        public string MessageTopicPictureUrl { get; set; }
        public DateTime? MessageTopicDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
