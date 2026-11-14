using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace LabTest
{
    /// <summary>
    /// Centralized database helper for SQL Server operations using Microsoft.Data.SqlClient.
    /// Provides connection management, parameterized query execution, and connection testing.
    /// </summary>
    public static class DbHelper
    {
        // Default connection string targets localhost or local SQL Server instance.
        // Can be customized at runtime or in App.config.
        public static string ConnectionString { get; set; } =
            "Server=localhost;Database=LabTestDB;Integrated Security=True;TrustServerCertificate=True;";

        // Alternate local DB fallback connection string
        public const string LocalDbFallback =
            @"Server=(localdb)\MSSQLLocalDB;Database=LabTestDB;Integrated Security=True;TrustServerCertificate=True;";

        /// <summary>
        /// Creates and returns an unopened SqlConnection object.
        /// </summary>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        /// <summary>
        /// Executes a SELECT query and returns the results in a DataTable.
        /// </summary>
        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        /// <summary>
        /// Executes an INSERT, UPDATE, or DELETE command and returns affected row count.
        /// </summary>
        public static int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(commandText, conn))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Executes a scalar command (e.g. SCOPE_IDENTITY() or COUNT(*)) and returns the first column of the first row.
        /// </summary>
        public static object? ExecuteScalar(string commandText, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(commandText, conn))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Tests whether the current SQL Server connection is accessible.
        /// </summary>
        public static bool TestConnection(out string message)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT @@VERSION;", conn))
                    {
                        var version = cmd.ExecuteScalar()?.ToString();
                        message = "Connected successfully to SQL Server!\n\n" + (version ?? "");
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}
