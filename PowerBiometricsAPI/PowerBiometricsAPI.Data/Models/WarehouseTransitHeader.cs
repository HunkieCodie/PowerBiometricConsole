using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class WarehouseTransitHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string TransitId { get; set; }
        public DateTime? TransitEnteredDate { get; set; }
        public DateTime? TransitEtalDate { get; set; }
        public string TransitShipVia { get; set; }
        public bool? TransitShipped { get; set; }
        public DateTime? TransitShipDate { get; set; }
        public string TransitTrackingNumber { get; set; }
        public string TransitBillOfLadingNumber { get; set; }
        public string TransitTralierNumber { get; set; }
        public string TransitTrailerPrefix { get; set; }
        public string TransitShippingInstructions { get; set; }
        public bool? TransitReceived { get; set; }
        public DateTime? TransitReceivedDate { get; set; }
        public string TransitRequestedBy { get; set; }
        public string TransitHeaderMemo1 { get; set; }
        public string TransitHeaderMemo2 { get; set; }
        public string TransitHeaderMemo3 { get; set; }
        public string TransitHeaderMemo4 { get; set; }
        public string TransitHeaderMemo5 { get; set; }
        public string TransitHeaderMemo6 { get; set; }
        public string TransitHeaderMemo7 { get; set; }
        public string TransitHeaderMemo8 { get; set; }
        public string TransitHeaderMemo9 { get; set; }
        public string TransitHeaderMemo10 { get; set; }
        public bool? Memorized { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string EnteredBy { get; set; }
        public string Signature { get; set; }
        public string SignaturePassword { get; set; }
        public string SupervisorSignature { get; set; }
        public string SupervisorSignaturePassword { get; set; }
        public string ManagerSignature { get; set; }
        public string ManagerSignaturePassword { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
