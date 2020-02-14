using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CompaniesWorkflow
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public bool? ActivateWorkFlow { get; set; }
        public bool? ActivateWorkFlowAr { get; set; }
        public bool? ActivateWorkFlowAp { get; set; }
        public bool? ActivateWorkFlowGl { get; set; }
        public bool? ActivateWorkFlowIn { get; set; }
        public bool? ActivateWorkFlowOe { get; set; }
        public bool? ActivateWorkFlowPo { get; set; }
        public bool? ActivateWorkFlowWo { get; set; }
        public bool? ActivateWorkflowWh { get; set; }
        public bool? ActivateWorkFlowPr { get; set; }
        public bool? ActivateWorkFlowEm { get; set; }
        public bool? ActivateWorkFlowCrm { get; set; }
        public bool? ActivateWorkFlowEcart { get; set; }
        public bool? ActivateWorkFlowSupport { get; set; }
        public bool? ActivateWorkFlowCollections { get; set; }
        public bool? ActivateWorkflowChallange { get; set; }
        public bool? ActivateWorkFlowExternal { get; set; }
        public bool? ActivateWorkFlowOther { get; set; }
        public string WorkFlowNotes { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
