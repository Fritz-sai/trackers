using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace tracker
{
    public class DatabaseConnection
    {
        private static string connectionString = "Server=localhost;Database=expenses_tracker;Uid=root;Pwd=;";
        private static MySqlConnection connection;

        public static MySqlConnection GetConnection()
        {
            try
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(connectionString);
                }
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating database connection: " + ex.Message);
            }
        }

        public static void OpenConnection()
        {
            try
            {
                if (connection == null)
                {
                    connection = GetConnection();
                }
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        throw new Exception("Cannot connect to server. Contact administrator");
                    case 1045:
                        throw new Exception("Invalid username/password");
                    case 1049:
                        throw new Exception("Database 'expenses_tracker' does not exist. Please create it first.");
                    default:
                        throw new Exception("Error connecting to database: " + ex.Message);
                }
            }
        }

        public static void CloseConnection()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error closing database connection: " + ex.Message);
            }
        }

        public static bool TestConnection()
        {
            try
            {
                OpenConnection();
                CloseConnection();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
} 