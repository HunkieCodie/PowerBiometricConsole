using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBiometricsAPI.DomainModels
{
    public class Attendance
    {
        //public string CompanyId { get; set; }
        //public string DivisionId { get; set; }
        //public string DepartmentId { get; set; }
        public string apiToken { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string Remarks { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ClosedBy { get; set; }
        public DateTime? Period { get; set; }
        public string Status { get; set; }
        public bool? Closed { get; set; }
        public bool? Cleared { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public string BranchCode { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string token { get; set; }
        public List<AttendanceDetail> attendanceDetail { get; set; }

    }
}
