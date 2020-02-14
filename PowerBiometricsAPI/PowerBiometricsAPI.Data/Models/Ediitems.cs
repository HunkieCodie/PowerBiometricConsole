using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Ediitems
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ItemId { get; set; }
        public string ReferenceId { get; set; }
        public string ItemDescription { get; set; }
        public string ReferenceDescription { get; set; }
        public string EdidirectionTypeId { get; set; }
        public string EdidocumentTypeId { get; set; }
        public bool? Ediopen { get; set; }
        public string Upccode { get; set; }
        public string Epccode { get; set; }
        public string Rfidcode { get; set; }
        public string ItemCategory { get; set; }
        public string ItemFamily { get; set; }
        public double? ItemWeight { get; set; }
        public string ItemUom { get; set; }
        public string Uombasis { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public long? Quantity { get; set; }
        public string Nrfcolor { get; set; }
        public string Nrfstyle { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
