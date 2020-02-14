using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Departments
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public string DepartmentAddress1 { get; set; }
        public string DepartmentAddress2 { get; set; }
        public string DepartmentCity { get; set; }
        public string DepartmentState { get; set; }
        public string DepartmentZip { get; set; }
        public string DepartmentCountry { get; set; }
        public string DepartmentPhone { get; set; }
        public string DepartmentFax { get; set; }
        public string DepartmentEmail { get; set; }
        public string DepartmentWebAddress { get; set; }
        public string DepartmentNotes { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public DateTime? LastEditDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string BranchCode { get; set; }
    }
}
