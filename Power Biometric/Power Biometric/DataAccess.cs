using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Biometric
{
    public static class DataAccess
    {

        public static SqlConnection sqlConnection;
        public static SqlCommand sqlCommand;
        public static SqlDataAdapter sqlDataAdapter;
        public static DataTable dataTable;
        public static SqlDataReader sqlDataReader;
        public static string connectionString = "Data Source=.;User ID = enterprise; password=entx!2003n;Database=Biometrics;Persist Security Info=True";
        static DataAccess()
        {
            sqlConnection = new SqlConnection(connectionString);

            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {

            }
        }

        public static DataTable ReturnDataTable()
        {
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable ReturnDataTable(string query)
        {
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable GetTimeDetailForUserID(String TableName, String UserID, String TransactionTime, DateTime TransactionTimeValue)
        {
            try
            {
                string query = "SELECT " + UserID + ", " + TransactionTime +
                    " FROM " + TableName + " WHERE CAST(" + TransactionTime + " AS DATE) = '" + TransactionTimeValue + "'";
                sqlCommand = new SqlCommand(query, sqlConnection);
            }
            catch (Exception ex)
            {

            }
            return ReturnDataTable();
        }

        public static DataTable GetTransactionTimeDetails(String TableName, String TransactionTime, String Synchronized, DateTime TransactionTimeValue)
        {
            try
            {
                string query = "SELECT " + TransactionTime + " FROM " + TableName +
                    " WHERE CAST(" + TransactionTime + " AS DATE) = '" + TransactionTimeValue + "' AND ISNULL(" + Synchronized +", 0) = 0";
                sqlCommand = new SqlCommand(query, sqlConnection);
            }
            catch (Exception ex)
            {
            }
            return ReturnDataTable();
        }

        public static DataTable GetTransactionTimeHeader(String TableName, String TransactionTime, String Synchronized)
        {
            try
            {
                string query = "SELECT DISTINCT CAST(" + TransactionTime + " AS DATE) AS Clock FROM " +
                    TableName + " WHERE ISNULL(" + Synchronized + ", 0) = 0" + " ORDER BY Clock ASC";
                sqlCommand = new SqlCommand(query, sqlConnection);
            }
            catch (Exception ex)
            {

            }
            return ReturnDataTable();
        }

        public static DataTable GetClockInClockOutById(String TableName, String UserID, String TransactionTime, String UserIDValue, DateTime TransactionTimeValue)
        {
            try
            {
                string query = "SELECT " + UserID + ", Min(" + TransactionTime + ") AS 'ClockIn', Max(" + TransactionTime + ") AS 'ClockOut' " +
                    "FROM " + TableName + "WHERE(CAST(" + TransactionTime + " AS DATE) = '" + TransactionTimeValue + "') " +
                    "AND UserID = '" + UserIDValue + "' GROUP BY '" + UserID + "'";
                sqlCommand = new SqlCommand(query, sqlConnection);

            }
            catch (Exception ex)
            {

            }
            return ReturnDataTable();

        }

        //public static void UpdateSyncDetails(String TableName, )

    }
}
