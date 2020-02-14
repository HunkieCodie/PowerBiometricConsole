using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class WebParameters
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string Ipaddress { get; set; }
        public bool? SendMail { get; set; }
        public bool? SendText { get; set; }
        public string EmailSmtpserver { get; set; }
        public string EmailUserName { get; set; }
        public string EmailPassword { get; set; }
        public string TextUrl { get; set; }
        public string TextUserName { get; set; }
        public string TextPassword { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string TextSubAcct { get; set; }
        public string PortNumber { get; set; }
        public string BranchCode { get; set; }
    }
}
