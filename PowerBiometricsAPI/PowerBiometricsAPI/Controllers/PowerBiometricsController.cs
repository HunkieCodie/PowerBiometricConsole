using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PowerBiometricsAPI.DomainModels;
using PowerBiometricsAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PowerBiometricsAPI.Controllers
{
    [Route("api/[controller]")]
    public class PowerBiometricsController : Controller
    {
        EnterpriseBaseContext _DBContext;
        public PowerBiometricsController(EnterpriseBaseContext _context)
        {
            _DBContext = _context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{periodFrom}/{periodTo}")]

        // POST api/values
        [HttpPost]//("{token}")]
        public string Post([FromBody]List<Attendance> attendance)
        {
            List<PayrollHrpayrollAttHeader> payrollHrpayrollAttHeader = new List<PayrollHrpayrollAttHeader>();
            Apitoken apiToken = new Apitoken();
            Attendance att = attendance.ElementAtOrDefault(0);

            bool status = false;
            string finalResult = "failed";
            try
            {
                apiToken = _DBContext.ApiToken.Where(a => a.Token == att.apiToken).FirstOrDefault();
                if (apiToken != null)
                {
                    if (attendance != null)
                    {
                        foreach (Attendance attendanceObj in attendance)
                        {
                            PayrollHrpayrollAttHeader payrollHrpayrollAttHeaderObj = new PayrollHrpayrollAttHeader();

                            payrollHrpayrollAttHeaderObj.CompanyId = apiToken.CompanyId;
                            payrollHrpayrollAttHeaderObj.DivisionId = apiToken.DivisionId;
                            payrollHrpayrollAttHeaderObj.DepartmentId = apiToken.DepartmentId;
                            payrollHrpayrollAttHeaderObj.AttendanceDate = attendanceObj.AttendanceDate;
                            payrollHrpayrollAttHeaderObj.Remarks = attendanceObj.Remarks;
                            payrollHrpayrollAttHeaderObj.ClosedDate = attendanceObj.ClosedDate;
                            payrollHrpayrollAttHeaderObj.ClosedBy = attendanceObj.ClosedBy;
                            payrollHrpayrollAttHeaderObj.Period = attendanceObj.Period;
                            payrollHrpayrollAttHeaderObj.Status = attendanceObj.Status;
                            payrollHrpayrollAttHeaderObj.Closed = attendanceObj.Closed;
                            payrollHrpayrollAttHeaderObj.Cleared = attendanceObj.Cleared;
                            payrollHrpayrollAttHeaderObj.EnteredBy = attendanceObj.EnteredBy;
                            payrollHrpayrollAttHeaderObj.EnteredDate = attendanceObj.EnteredDate;
                            payrollHrpayrollAttHeaderObj.BranchCode = attendanceObj.BranchCode;

                            _DBContext.Entry(payrollHrpayrollAttHeaderObj).State = EntityState.Added;

                            status = insertAttendanceDetail(apiToken, attendanceObj.attendanceDetail);

                            if (status)
                            {
                                _DBContext.SaveChanges();
                            }

                        }
                        return finalResult = "success";
                    }

                }
                else
                {
                    return finalResult = "Invalid Token";
                }
            }
            catch (Exception ex)
            {

            }
            return finalResult;
        }

        private bool insertAttendanceDetail(Apitoken apiToken, List<AttendanceDetail> attendanceDetail)
        {
            AttendanceDetail payrollHrpayrollAttDetail = new AttendanceDetail();
            List<AttendanceDetail> attend = attendanceDetail;

            bool status = false;
            string employeeID = "";
            try
            {
                if (attendanceDetail != null)
                {
                    List<AttendanceDetail> att = attendanceDetail.GroupBy(x => x.EmployeeId).Select(g => g.First()).ToList();
                    foreach (AttendanceDetail attendanceDetailObj in att)
                    {
                        PayrollHrpayrollAttDetail payrollHrpayrollAttDetailObj = new PayrollHrpayrollAttDetail();

                        payrollHrpayrollAttDetailObj.CompanyId = apiToken.CompanyId;
                        payrollHrpayrollAttDetailObj.DivisionId = apiToken.DivisionId;
                        payrollHrpayrollAttDetailObj.DepartmentId = apiToken.DepartmentId;
                        payrollHrpayrollAttDetailObj.AttendanceDate = attendanceDetailObj.AttendanceDate;

                        employeeID = getEmployeeID(apiToken, attendanceDetailObj);

                        payrollHrpayrollAttDetailObj.EmployeeId = employeeID == null || employeeID == "" ? attendanceDetailObj.EmployeeId : employeeID;
                        payrollHrpayrollAttDetailObj.EmployeeName = attendanceDetailObj.EmployeeName;
                        payrollHrpayrollAttDetailObj.ExpectedTimeIn = attendanceDetailObj.ExpectedTimeIn;
                        payrollHrpayrollAttDetailObj.TimeIn = attendanceDetailObj.TimeIn;
                        payrollHrpayrollAttDetailObj.ShiftType = attendanceDetailObj.ShiftType;
                        payrollHrpayrollAttDetailObj.Absent = attendanceDetailObj.Absent;
                        payrollHrpayrollAttDetailObj.Remarks = attendanceDetailObj.Remarks;
                        payrollHrpayrollAttDetailObj.LatePeriod = attendanceDetailObj.LatePeriod;
                        payrollHrpayrollAttDetailObj.Period = attendanceDetailObj.Period;
                        payrollHrpayrollAttDetailObj.BranchCode = attendanceDetailObj.BranchCode;

                       
                        _DBContext.Entry(payrollHrpayrollAttDetailObj).State = EntityState.Added;

                    }

                    return status = true;
                }

            }
            catch(Exception ex)
            {
                return status = false;
            }

            return status;
        }

        public string getEmployeeID(Apitoken apiToken, AttendanceDetail attendanceDetail)
        {
            string employeeID = "";
            try
            {
                PayrollEmployees empl = _DBContext.PayrollEmployees.Where(x => x.CompanyId == apiToken.CompanyId &&
                                                     x.DivisionId == apiToken.DivisionId &&
                                                     x.DepartmentId == apiToken.DepartmentId &&
                                                     x.EmployeeBiometricID == attendanceDetail.EmployeeId).AsNoTracking().
                                                     FirstOrDefault();

                employeeID = empl.EmployeeId;
            }
            catch (Exception ex)
            {
            }

            return employeeID; 
        }

        public bool apiResult()
        {
            bool apiStatus = false;
            return apiStatus;
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
