using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class OrderTrackingDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string OrderNumber { get; set; }
        public double OrderQuantity { get; set; }
        public DateTime? OrderDate { get; set; }
        public string TruckNumber { get; set; }
        public string ShippingAddress { get; set; }
        public decimal? CommentNumber { get; set; }
        public DateTime? CommentDate { get; set; }
        public string Comment { get; set; }
        public string CommentDetails { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
