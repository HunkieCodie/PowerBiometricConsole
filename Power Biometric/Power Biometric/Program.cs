using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Power_Biometric
{
    public class Program
    {
        string Token = Utility.Token;
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            populateHeaderTable();
         
        }


        private static List<AttendanceDetail> getAttendanceDetail(DateTime AttendanceDate)
        {
            DataTable getData = new DataTable();
            List<AttendanceDetail> attendanceDetail = new List<AttendanceDetail>();
            try
            {
                getData = DataAccess.GetTransactionTimeDetails("NGAC_SYSLOG", "TransactionTime", "UserID", "Synchronized", AttendanceDate);
                foreach (DataRow dr in getData.Rows)
                {
                    AttendanceDetail transactionDetailObj = new AttendanceDetail();

                    string userid = dr["UserID"].ToString();
                    transactionDetailObj.EmployeeId = userid;
                    DateTime dtTransactionDate = Convert.ToDateTime(dr["TransactionTime"].ToString());
                    dtTransactionDate = dtTransactionDate.Date;
                    transactionDetailObj.AttendanceDate = dtTransactionDate;
                    transactionDetailObj.TimeIn = Convert.ToDateTime(dr["TransactionTime"].ToString());

                    attendanceDetail.Add(transactionDetailObj);

                }
            }
            catch (Exception exception)
            {
            }
            return attendanceDetail;
        }

        private static void populateHeaderTable()
        {
            DataTable getData = new DataTable();
            List<Attendance> attendanceList = new List<Attendance>();
            string statusMessage = "";
            try
            {
                getData = DataAccess.GetTransactionTimeHeader("NGAC_SYSLOG", "TransactionTime", "Synchronized");
                if (getData != null)
                {
                    if (getData.Rows.Count > 0)
                    {
                        foreach (DataRow dr in getData.Rows)
                        {
                            Attendance transactionObj = new Attendance();
                            transactionObj.AttendanceDate = Convert.ToDateTime(dr["Clock"].ToString());
                            transactionObj.EnteredDate = DateTime.Now;
                            transactionObj.apiToken = Utility.Token;
                            transactionObj.attendanceDetail = getAttendanceDetail(Convert.ToDateTime(dr["Clock"].ToString()));
                            attendanceList.Add(transactionObj);
                        }

                        var att = JsonConvert.SerializeObject(attendanceList);
                        string url = "http://localhost/PowerBiometricsAPI/api/powerbiometrics";
                        var response = client.PostAsync(url, new StringContent(att, Encoding.UTF8, "application/json"));

                        response.Wait();
                        var result = response.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            Uri attendanceUrl = result.Headers.Location;
                            statusMessage = result.Content.ReadAsStringAsync().Result;
                            Console.WriteLine(statusMessage);

                            if(statusMessage == "success")
                            {
                                DataAccess.UpdateSyncDetail("NGAC_SYSLOG", "Synchronized", "1");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Sync failed");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Record already synchronized");
                    }
                }
                else
                {
                    Console.WriteLine("Record does not exist.");
                }
            }
            catch(Exception exception)
            {
                string errorMessage = exception.Message;
                if(errorMessage == "One or more errors occured.")
                {
                    Console.WriteLine("Is API running?");
                }
                else
                {
                    Console.WriteLine("API url is incorrect.");
                }
            }
        }
    }
}
