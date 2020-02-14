using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class OrderTrackingHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string OrderNumber { get; set; }
        public double? OrderQuantity { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderDescription { get; set; }
        public string OrderLongDescription { get; set; }
        public string SpecialInstructions { get; set; }
        public string SpecialNeeds { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public bool? Cleared { get; set; }
        public string ClearedBy { get; set; }
        public DateTime? ClearedDate { get; set; }
        public bool? Booked { get; set; }
        public DateTime? BookedDate { get; set; }
        public string BookedBy { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? Void { get; set; }
        public DateTime? VoidDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
