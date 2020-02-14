using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PowerBiometricsAPI.Data.Models;
using PowerBiometricsAPI.Data.Validators;
using PowerBiometricsAPI.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBiometricsAPI.Controllers
{
    [Route("api/[controller]")]
    public class LoginController: Controller
    {

      
        Extras utilities = new Extras();

        private EnterpriseBaseContext _DBContext;
        // GET api/values

        public LoginController(EnterpriseBaseContext enterpriseBaseContext)
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
        [HttpPost]
        [Route("api/Login")]
        public string Post([FromBody]Employees employees)
        {
            string message = "no";
            if (employees != null)
            {
                //PayrollEmployees payrollEmployees = jObject["payrollEmp"].ToObject<PayrollEmployees>();

                //string apiToken = jObject["apiToken"].ToString();
                Apitoken apitoken = new Apitoken();
                string password = validatePassword(employees.EmployeePassword);
                try
                {
                    apitoken = _DBContext.ApiToken.Where(a => a.Token == employees.apiToken).FirstOrDefault();
                }
                catch (Exception ex)
                {

                }
                if (apitoken != null)
                {
                    try
                    {
                        PayrollEmployees empDetails = _DBContext.PayrollEmployees
                                                                      .Where(x => x.CompanyId == apitoken.CompanyId &&
                                                                      x.DivisionId == apitoken.DivisionId &&
                                                                      x.DepartmentId == apitoken.DepartmentId &&
                                                                      x.EmployeeId == employees.EmployeeId &&
                                                                      x.EmployeePassword == password &&
                                                                      x.EmployeeTypeId == "user").FirstOrDefault();

                        if (empDetails != null)
                        {
                            message = "yes";
                        }
                    }
                    catch (Exception dd)
                    {

                    }
                }
                else
                {
                    message = "Invalid Token";
                }


            };

            return message;
        }

        public string validatePassword(string password)
        {
            string cnvtdPwrd = "";

            cnvtdPwrd = utilities.doConvertPwd(password);

            return cnvtdPwrd;
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
