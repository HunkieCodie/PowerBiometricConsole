using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerShipForLocations
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CustomerId { get; set; }
        public string ShipToId { get; set; }
        public string ShipForId { get; set; }
        public string ShipForName { get; set; }
        public string ShipForAddress1 { get; set; }
        public string ShipForAddress2 { get; set; }
        public string ShipForAddress3 { get; set; }
        public string ShipForCity { get; set; }
        public string ShipForState { get; set; }
        public string ShipForZip { get; set; }
        public string ShipForeCountry { get; set; }
        public string ShipForEmail { get; set; }
        public string ShipForWebPage { get; set; }
        public string ShipForAttention { get; set; }
        public string ShipForNotes { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
