using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Ediaddresses
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ReferenceId { get; set; }
        public string ReferenceAddressShipTo { get; set; }
        public string ReferenceAddressShipFor { get; set; }
        public string EdidirectionTypeId { get; set; }
        public string EdidocumentTypeId { get; set; }
        public bool? Ediopen { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipAddress3 { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipZip { get; set; }
        public string ShipCountry { get; set; }
        public string ShipAttention { get; set; }
        public string ShipPhone { get; set; }
        public string ShipFax { get; set; }
        public string ShipEmail { get; set; }
        public string ShipWebPage { get; set; }
        public string ShipNotes { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
