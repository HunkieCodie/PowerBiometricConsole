using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Divisions
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string DivisionName { get; set; }
        public string DivisionDescription { get; set; }
        public string DivisionAddress1 { get; set; }
        public string DivisionAddress2 { get; set; }
        public string DivisionCity { get; set; }
        public string DivisionState { get; set; }
        public string DivisionZip { get; set; }
        public string DivisionCountry { get; set; }
        public string DivisionPhone { get; set; }
        public string DivisionFax { get; set; }
        public string DivisionEmail { get; set; }
        public string DivisionWebAddress { get; set; }
        public string DivisionNotes { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public DateTime? LastEditDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string BranchCode { get; set; }
    }
}
