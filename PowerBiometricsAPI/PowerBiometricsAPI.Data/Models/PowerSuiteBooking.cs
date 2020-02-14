using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PowerSuiteBooking
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public int BookingId { get; set; }
        public DateTime? BookingDate { get; set; }
        public DateTime? BookingexpirationDate { get; set; }
        public string RoomCategory { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime? CheckingInDate { get; set; }
        public bool? CheckingIn { get; set; }
        public DateTime? CheckingOutDate { get; set; }
        public bool? CheckingOut { get; set; }
        public int? NumOfRooms { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentCardNumber { get; set; }
        public string CardCvv2 { get; set; }
        public string NumberOfAdults { get; set; }
        public string NumberOfChildren { get; set; }
        public string BookingExpiration { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
