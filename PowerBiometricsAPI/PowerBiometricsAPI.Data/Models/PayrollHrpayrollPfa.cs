using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollPfa
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string Pfaid { get; set; }
        public string Pfadescription { get; set; }
        public string Pfaaddress { get; set; }
        public string Pfaphone { get; set; }
        public string Pfaemail { get; set; }
        public string Pfacontact { get; set; }
        public string ReceivingBank { get; set; }
        public string ReceivingAcctNo { get; set; }
        public string Pfalogo { get; set; }
        public string PfafreeCode { get; set; }
        public string InstrumentNumber { get; set; }
        public string EmployerCode { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
