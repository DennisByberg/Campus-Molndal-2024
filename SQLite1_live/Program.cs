using System;
using System.Data.SQLite;

namespace SQLite1_live
{
    internal static class Program
    {
        static void Main()
        {
            string connectionString = "Data Source=Employee.db";

            string sql = "CREATE TABLE IF NOT EXISTS employees (" +
                         "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                         "name TEXT NOT NULL, " +
                         "position TEXT NOT NULL, " +
                         "salary REAL" +
                         ")";

            try
            {
                string sql = "INSERT INTO employees (name, position, salary) VALUES (@name, @position, @salary)";
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Table created successfully");
                    }


                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", "John Doe");
                        command.Parameters.AddWithValue("@position", "Manager");
                        command.Parameters.AddWithValue("@salary", 50000.0);
                        command.ExecuteNonQuery();

                        Console.WriteLine("Data inserted successfully");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
