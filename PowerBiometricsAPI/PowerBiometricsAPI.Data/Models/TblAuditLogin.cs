using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class TblAuditLogin
    {
        public int AuditTrailId { get; set; }
        public string CAgentName { get; set; }
        public string MachineName { get; set; }
        public string Ipaddress { get; set; }
        public string Status { get; set; }
        public DateTime? DateTimeStamp { get; set; }
        public string WarehouseId { get; set; }
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BranchCode { get; set; }
    }
}
