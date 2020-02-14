using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryAssembliesInstructions
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string AssemblyId { get; set; }
        public string AssemblyBuildInstructions { get; set; }
        public string AssemblySchematicUrl { get; set; }
        public string AssemblyPictureUrl { get; set; }
        public string AssemblyDiagramUrl { get; set; }
        public string AssemblyOtherUrl { get; set; }
        public int? AssemblyTimeToBuild { get; set; }
        public string AssemblyTimeToBuildUnit { get; set; }
        public DateTime? AssemblyLastUpdated { get; set; }
        public string AssemblyLastUpdatedBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Approve { get; set; }
        public string ApproveBy { get; set; }
        public DateTime? ApproveDate { get; set; }
        public bool? Cleared { get; set; }
        public string ClearedBy { get; set; }
        public DateTime? ClearedDate { get; set; }
        public string BranchCode { get; set; }
    }
}
