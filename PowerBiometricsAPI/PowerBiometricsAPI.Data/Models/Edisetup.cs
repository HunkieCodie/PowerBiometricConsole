using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Edisetup
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string Ediid { get; set; }
        public bool? Ediactive { get; set; }
        public string Ediqualifier { get; set; }
        public string EditestQualifier { get; set; }
        public string EditestId { get; set; }
        public bool? EdiinboundOrders { get; set; }
        public bool? EdioutboundOrders { get; set; }
        public bool? EdiinboundInvoices { get; set; }
        public bool? EdioutboundInvoices { get; set; }
        public bool? EdiinboundAsn { get; set; }
        public bool? EdioutboundAsn { get; set; }
        public bool? EdiinboundUpc { get; set; }
        public bool? EdioutboundUpc { get; set; }
        public bool? EdiinboundFinancial { get; set; }
        public bool? EdioutboundFinancial { get; set; }
        public bool? EdiinboundOrderStatus { get; set; }
        public bool? EdioutboundOrderStatus { get; set; }
        public bool? EdiinboundInventory { get; set; }
        public bool? EdioutboundInventory { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
