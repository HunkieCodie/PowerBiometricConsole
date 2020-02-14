using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollSetup
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string FederalTaxIdnumber { get; set; }
        public string State { get; set; }
        public string StateTaxIdnumber { get; set; }
        public string County { get; set; }
        public string CountyTaxIdnumber { get; set; }
        public string CityName { get; set; }
        public string CityTaxIdnumber { get; set; }
        public float? Fitrate { get; set; }
        public float? FitwageBase { get; set; }
        public float? Ficarate { get; set; }
        public float? FicaemployerPortion { get; set; }
        public float? FicawageBase { get; set; }
        public float? Futarate { get; set; }
        public float? FutawageBase { get; set; }
        public float? Sutarate { get; set; }
        public float? SutawageBase { get; set; }
        public float? Sitrate { get; set; }
        public float? SitwageBase { get; set; }
        public float? Sdirate { get; set; }
        public float? SdiwageBase { get; set; }
        public float? Ssirate { get; set; }
        public float? SsiwageBase { get; set; }
        public float? FicamedRate { get; set; }
        public float? FicamedWageBase { get; set; }
        public bool? CreatePayroll { get; set; }
        public bool? PayCommissions { get; set; }
        public int? Otafter { get; set; }
        public string GlfitpayrollAccount { get; set; }
        public string GlfitexpenseAccount { get; set; }
        public string GlficapayrollAccount { get; set; }
        public string GlficaexpenseAccount { get; set; }
        public string GlfutapayrollAccount { get; set; }
        public string GlfutaexpenseAccount { get; set; }
        public string GlsutapayrollAccount { get; set; }
        public string GlsutaexpenseAccount { get; set; }
        public string GlsitpayrollAccount { get; set; }
        public string GlsitexpenseAccount { get; set; }
        public string GlsdipayrollAccount { get; set; }
        public string GlsdiexpenseAccount { get; set; }
        public string GlficamedPayrollAccount { get; set; }
        public string GlficamedExpenseAccount { get; set; }
        public string GlpayrollCashAccount { get; set; }
        public string GllocalPayrollAccount { get; set; }
        public string GlsalesPayrollExpenseAccount { get; set; }
        public string GlofficePayrollExpenseAccount { get; set; }
        public string GlwarehousePayrollExpenseAccount { get; set; }
        public string GlproductionPayrollExpenseAccount { get; set; }
        public string GlovertimePayrollExpenseAccount { get; set; }
        public string GlwagesPayrollAccount { get; set; }
        public string GlpayrollTaxExpenseAccount { get; set; }
        public string GlbonusPayrollAccount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
