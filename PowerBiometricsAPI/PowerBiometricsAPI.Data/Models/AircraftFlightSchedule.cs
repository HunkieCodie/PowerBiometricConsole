using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class AircraftFlightSchedule
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CustomerId { get; set; }
        public string AircraftId { get; set; }
        public string FlightDayId { get; set; }
        public string Arrival { get; set; }
        public string Eta { get; set; }
        public string Departure { get; set; }
        public string Etd { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
