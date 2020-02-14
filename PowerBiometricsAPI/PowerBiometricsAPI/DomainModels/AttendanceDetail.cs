using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBiometricsAPI.DomainModels
{
    public class AttendanceDetail
    {
        //public string CompanyId { get; set; }
        //public string DivisionId { get; set; }
        //public string DepartmentId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? ExpectedTimeIn { get; set; }
        public DateTime? TimeIn { get; set; }
        public string ShiftType { get; set; }
        public bool? Absent { get; set; }
        public string Remarks { get; set; }      
        public double? LatePeriod { get; set; }
        public DateTime? Period { get; set; }   
        public string BranchCode { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
    }
}
