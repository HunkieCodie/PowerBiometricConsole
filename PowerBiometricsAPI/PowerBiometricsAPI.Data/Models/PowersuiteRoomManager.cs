using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PowersuiteRoomManager
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string RoomId { get; set; }
        public string RoomType { get; set; }
        public string RoomName { get; set; }
        public string RoomLocation { get; set; }
        public string RoomDescription { get; set; }
        public double? Price { get; set; }
        public bool? Availability { get; set; }
        public byte[] Picture { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
