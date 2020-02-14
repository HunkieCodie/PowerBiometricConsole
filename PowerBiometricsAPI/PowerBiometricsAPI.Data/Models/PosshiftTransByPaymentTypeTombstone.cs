using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PosshiftTransByPaymentTypeTombstone
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ShiftId { get; set; }
        public string PosreceiptId { get; set; }
        public string OrderNumber { get; set; }
        public string PaymentType { get; set; }
        public DateTime? DeletionDate { get; set; }
        public string BranchCode { get; set; }
    }
}
