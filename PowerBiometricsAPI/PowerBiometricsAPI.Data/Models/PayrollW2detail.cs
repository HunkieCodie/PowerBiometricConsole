using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollW2detail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string W2year { get; set; }
        public string W2controlNumber { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSsnumber { get; set; }
        public string EmployeeAddress1 { get; set; }
        public string EmployeeAddress2 { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeState { get; set; }
        public string EmployeeZip { get; set; }
        public string EmployeeCountry { get; set; }
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
        public decimal? Box13 { get; set; }
        public string Box13b { get; set; }
        public decimal? Box14 { get; set; }
        public string Box15 { get; set; }
        public bool? Box15Check1 { get; set; }
        public bool? Box15Check2 { get; set; }
        public bool? Box15Check3 { get; set; }
        public bool? Box15Check4 { get; set; }
        public bool? Box15Check5 { get; set; }
        public bool? Box15Check6 { get; set; }
        public bool? Box15Check7 { get; set; }
        public decimal? Box17 { get; set; }
        public decimal? Box18 { get; set; }
        public decimal? Box19 { get; set; }
        public decimal? Box20 { get; set; }
        public decimal? Box21 { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
