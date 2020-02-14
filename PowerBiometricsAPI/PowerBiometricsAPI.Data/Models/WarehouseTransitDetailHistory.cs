using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class WarehouseTransitDetailHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string TransitId { get; set; }
        public long TransitDetailLineId { get; set; }
        public string TransitItemId { get; set; }
        public double? TransitItemQuantity { get; set; }
        public string TransitSourceWarehouse { get; set; }
        public string TransitSourceWarehouseBin { get; set; }
        public string TransitInTransitWarehouse { get; set; }
        public string TransitInTransitWarehouseBin { get; set; }
        public string TransitDestinationWarehouse { get; set; }
        public string TransitDestinationWarehouseBin { get; set; }
        public string TransitInstructions { get; set; }
        public bool? TransitReceived { get; set; }
        public DateTime? TransitReceivedDate { get; set; }
        public string TransitRequestedBy { get; set; }
        public string TransitTrackingNumber { get; set; }
        public string TransitDetailMemo1 { get; set; }
        public string TransitDetailMemo2 { get; set; }
        public string TransitDetailMemo3 { get; set; }
        public string TransitDetailMemo4 { get; set; }
        public string TransitDetailMemo5 { get; set; }
        public string TransitDetailMemo6 { get; set; }
        public string TransitDetailMemo7 { get; set; }
        public string TransitDetailMemo8 { get; set; }
        public string TransitDetailMemo9 { get; set; }
        public string TransitDetailMemo10 { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
