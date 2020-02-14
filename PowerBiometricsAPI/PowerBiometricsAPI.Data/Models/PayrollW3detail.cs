using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollW3detail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ControlNumber { get; set; }
        public int? TotalNoStatements { get; set; }
        public string EstablishmentNo { get; set; }
        public string EmployerIdentifyicationNumber { get; set; }
        public string OtherEmployerIdentifyicationNumber { get; set; }
        public decimal? Box1 { get; set; }
        public decimal? Box2 { get; set; }
        public decimal? Box3 { get; set; }
        public decimal? Box4 { get; set; }
        public decimal? Box5 { get; set; }
        public decimal? Box6 { get; set; }
        public decimal? Box7 { get; set; }
        public decimal? Box8 { get; set; }
        public decimal? Box9 { get; set; }
        public decimal? Box10 { get; set; }
        public decimal? Box11 { get; set; }
        public decimal? Box12 { get; set; }
        public decimal? Box15 { get; set; }
        public bool? _941 { get; set; }
        public bool? Military { get; set; }
        public bool? _943 { get; set; }
        public bool? Ct1 { get; set; }
        public bool? Hshld { get; set; }
        public bool? MedicareGovtEmp { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
