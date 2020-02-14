using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PowerBiometricsAPI.Data.Models;
using PowerBiometricsAPI.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBiometricsAPI.Controllers
{
    public class MappingController : Controller
    {

        EnterpriseBaseContext _DBContext = new EnterpriseBaseContext();

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [Route("api/Mapping")]
        [HttpPost]
        public async Task<List<PayrollEmployees>> Post([FromBody]JObject jObject)
        {
            List<PayrollEmployees> list = new List<PayrollEmployees>();
            //APIToken apiToken = new APIToken();

            //apiToken.CompanyId = "ABRAAJ";
            //apiToken.DivisionId = "DEFAULT";
            //apiToken.DepartmentId = "DEFAULT";
            PayrollEmployees payrollEmployees = jObject["payrollEmp"].ToObject<PayrollEmployees>();
            APIToken apiToken = jObject["apiToken"].ToObject<APIToken>();

            try
            {
                var empDetails = await _DBContext.PayrollEmployees.Where(x => x.CompanyId == apiToken.CompanyId &&
                                                              x.DivisionId == apiToken.DivisionId &&
                                                              x.DepartmentId == apiToken.DepartmentId &&
                                                              x.EmployeeId == payrollEmployees.EmployeeId &&
                                                              x.EmployeePassword == payrollEmployees.EmployeePassword).ToListAsync();

                if (empDetails != null)
                {
                    list = empDetails;
                }
            }
            catch (Exception dd)
            {

            }

            return list;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] List<PayrollEmployees> employees)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
