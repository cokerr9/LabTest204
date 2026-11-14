using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace LabTest
{
    /// <summary>
    /// Centralized database helper for SQL Server operations using Microsoft.Data.SqlClient.
    /// Supports both stored procedures and parameterized SQL commands.
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

        #region Query Execution (DataTable)

        /// <summary>
        /// Executes a command with specified CommandType and returns the results in a DataTable.
        /// </summary>
        public static DataTable ExecuteQuery(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
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
        /// Executes an ad-hoc SQL query string and returns a DataTable.
        /// </summary>
        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            return ExecuteQuery(query, CommandType.Text, parameters);
        }

        /// <summary>
        /// Executes a Stored Procedure and returns the results in a DataTable.
        /// </summary>
        public static DataTable ExecuteStoredProcedure(string procedureName, params SqlParameter[] parameters)
        {
            return ExecuteQuery(procedureName, CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region Non-Query Execution (INSERT, UPDATE, DELETE)

        /// <summary>
        /// Executes an INSERT, UPDATE, or DELETE command and returns affected row count.
        /// </summary>
        public static int ExecuteNonQuery(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Executes an ad-hoc non-query command text.
        /// </summary>
        public static int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
        {
            return ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        /// <summary>
        /// Executes a Stored Procedure for INSERT, UPDATE, or DELETE and returns affected row count.
        /// </summary>
        public static int ExecuteNonQueryProcedure(string procedureName, params SqlParameter[] parameters)
        {
            return ExecuteNonQuery(procedureName, CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region Scalar Execution (SCOPE_IDENTITY, COUNT)

        /// <summary>
        /// Executes a scalar command and returns the first column of the first row.
        /// </summary>
        public static object? ExecuteScalar(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Executes an ad-hoc scalar query.
        /// </summary>
        public static object? ExecuteScalar(string commandText, params SqlParameter[] parameters)
        {
            return ExecuteScalar(commandText, CommandType.Text, parameters);
        }

        /// <summary>
        /// Executes a Stored Procedure that returns a scalar value (e.g. SCOPE_IDENTITY()).
        /// </summary>
        public static object? ExecuteScalarProcedure(string procedureName, params SqlParameter[] parameters)
        {
            return ExecuteScalar(procedureName, CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region Connection Testing

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

        #endregion
    }
}
