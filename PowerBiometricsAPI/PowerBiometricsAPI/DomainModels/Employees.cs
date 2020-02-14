using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBiometricsAPI.DomainModels
{
    public class Employees
    {
        public string EmployeeId { get; set; }
        public string apiToken { get; set; }
        public string EmployeePassword { get; set; }
    }
}
