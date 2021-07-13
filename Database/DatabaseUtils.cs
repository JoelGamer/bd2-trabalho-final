using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace bd2_trabalho_final.Database
{
    static class DatabaseUtils
    {

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(Properties.Settings.Default.SqlConnectionString);
        }

        public static SqlCommand GetSqlCommand(string command, SqlConnection sqlConnection)
        {
            return new SqlCommand(command, sqlConnection);
        }

        public static DataTable GenerateDataTable(string command, SqlConnection sqlConnection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static void ExecuteSqlCommand(string command, Action<SqlConnection, SqlCommand> callback)
        {
            using (SqlConnection sqlConnection = GetSqlConnection())
            using (SqlCommand sqlCommand = GetSqlCommand(command, sqlConnection))
            {
                callback(sqlConnection, sqlCommand);
            }
        }

        public static void ExecuteSqlCommandWithDataTable(string command, Action<SqlConnection, SqlCommand, DataTable> callback)
        {
            using (SqlConnection sqlConnection = GetSqlConnection())
            using (SqlCommand sqlCommand = GetSqlCommand(command, sqlConnection))
            {
                callback(sqlConnection, sqlCommand, GenerateDataTable(command, sqlConnection));
            }
        }

        public static string FormatDateTimeToSQLDate(DateTime dateTime)
        {
            return dateTime.Year != 1 ? "'" + dateTime.ToString("yyyy-MM-dd") + "'" : "null";
        }
    }
}
