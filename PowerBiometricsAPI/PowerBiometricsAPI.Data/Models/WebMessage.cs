using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class WebMessage
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string MessageType { get; set; }
        public string SourceTable { get; set; }
        public string SourceColumn { get; set; }
        public string CriteriaColumn { get; set; }
        public string SmssenderName { get; set; }
        public string EmailSubject { get; set; }
        public string Body { get; set; }
        public string Attachment { get; set; }
        public string Parameter1 { get; set; }
        public string Parameter2 { get; set; }
        public string Parameter3 { get; set; }
        public string Parameter4 { get; set; }
        public string Parameter5 { get; set; }
        public string Parameter6 { get; set; }
        public string Parameter7 { get; set; }
        public string Parameter8 { get; set; }
        public string Parameter9 { get; set; }
        public string Parameter10 { get; set; }
        public bool? CustomisedMessage { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
