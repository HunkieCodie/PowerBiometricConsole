using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class MailSend
    {
        public int Counter { get; set; }
        public string SenderId { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Attachment { get; set; }
        public bool? Attached { get; set; }
        public string MessageType { get; set; }
        public string AccountName { get; set; }
        public string Pword { get; set; }
        public bool? Sent { get; set; }
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string Accounts { get; set; }
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
        public DateTime? DeliveryDate { get; set; }
        public bool? CustomisedMessage { get; set; }
        public bool? IsAlert { get; set; }
        public string RequestBy { get; set; }
        public string SentTo { get; set; }
        public string PortNumber { get; set; }
        public string Priority { get; set; }
        public string Module { get; set; }
    }
}
