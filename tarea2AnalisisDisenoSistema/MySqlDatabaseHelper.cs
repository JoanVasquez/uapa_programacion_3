using MySql.Data.MySqlClient;
using System;

namespace tarea2AnalisisDisenoSistema
{
    internal class MySqlDatabaseHelper
    {
        private string connectionString;
        private MySqlConnection connection;

        public MySqlDatabaseHelper()
        {
            this.connectionString = "Server=localhost;Database=biblioteca;User ID=root;Password=pass22;";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection successful!");
                return connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Connection closed.");
            }
        }
    }
}
