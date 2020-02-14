using Microsoft.AspNetCore.Mvc;
using PowerBiometricsAPI.Data.Models;
using PowerBiometricsAPI.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBiometricsAPI.Controllers
{
    [Route("api/[controller]")]
    public class ChangePasswordController : Controller
    {
        private EnterpriseBaseContext _DBContext;
        // GET api/values

        public ChangePasswordController(EnterpriseBaseContext enterpriseBaseContext)
        {
            _DBContext = enterpriseBaseContext;
        }

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
        //[Route("api/ChangePassword")]
        [HttpPost]
        public bool Post([FromBody] UserInfo user)
        {
            bool status = false;
            //UserInfo user = new UserInfo()
            //{
            //    CompanyId = "ABRAAJ",
            //    DepartmentId = "DEFAULT",
            //    DivisionId = "DEFAULT",
            //    EmployeeId = "Admin",
            //    //Password = "isaaaac"
            //};
            if (user != null)
            {
                PayrollEmployees payrollEmployees = _DBContext.PayrollEmployees
                                                                .Where(a => a.CompanyId == user.CompanyId &&
                                                                a.DivisionId == user.DivisionId &&
                                                                a.DepartmentId == user.DepartmentId &&
                                                                a.EmployeeId == user.EmployeeId).FirstOrDefault();
                if (payrollEmployees != null)
                {
                    status = true;
                }
            }
            
            return status;
        }
        //public List<PayrollEmployees> Post([FromBody]PayrollEmployees payrollEmployees)
        //{
        //    List<PayrollEmployees> list = new List<PayrollEmployees>();
        //    APIToken apiToken = new APIToken();

        //    apiToken.CompanyId = "ABRAAJ";
        //    apiToken.DivisionId = "DEFAULT";
        //    apiToken.DepartmentId = "DEFAULT";

        //    try
        //    {
        //        var empDetails = _DBContext.PayrollEmployees.Where(x => x.CompanyId == apiToken.CompanyId &&
        //                                                      //x.DivisionId == apiToken.DivisionId &&
        //                                                      //x.DepartmentId == apiToken.DepartmentId &&
        //                                                      x.EmployeeId == payrollEmployees.EmployeeId &&
        //                                                      x.EmployeePassword == payrollEmployees.EmployeePassword).ToList();

        //        if (empDetails != null)
        //        {
        //            list = empDetails;
        //        }
        //    }
        //    catch (Exception dd)
        //    {

        //    }

        //    return list;
        //}

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
