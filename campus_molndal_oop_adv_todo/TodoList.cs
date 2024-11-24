using campus_molndal_oop_adv_todo.Interfaces;
using System;
using System.Data.SQLite;

namespace campus_molndal_oop_adv_todo
{
    internal class TodoList : ITodoList
    {
        const string CONNECTION_STRING = "Data Source=todolist.db;";

        //CTOR
        public TodoList()
        {
            CreateDatabaseAndTable();
        }

        private void CreateDatabaseAndTable()
        {
            using (var connection = new SQLiteConnection(CONNECTION_STRING))
            {
                connection.Open();

                const string QUERY = @"
                CREATE TABLE IF NOT EXISTS Todos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Description TEXT NOT NULL,
                    CreatedOn TEXT NOT NULL,
                    IsCompleted INTEGER NOT NULL
                );";

                using (var cmd = new SQLiteCommand(QUERY, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddTodo(string description, string createdOn, int isCompleted)
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    const string QUERY = @"
                INSERT INTO Todos(Description, CreatedOn, IsCompleted)
                VALUES(@Description, @CreatedOn, @IsCompleted)";

                    using (var command = new SQLiteCommand(QUERY, connection))
                    {
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@CreatedOn", createdOn);
                        command.Parameters.AddWithValue("@IsCompleted", isCompleted);
                        command.ExecuteNonQuery();

                        Console.WriteLine("Added todo");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding todo: {ex.Message}");
            }
        }

        public void DisplayAllTodos()
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    const string QUERY = "SELECT * FROM Todos";

                    using (var cmd = new SQLiteCommand(QUERY, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Read the IsCompleted value as an integer
                                var isCompleted = reader["IsCompleted"];

                                // Use a conditional expression to display "Completed" or "Not Completed"
                                string completionStatus = (isCompleted.ToString() == "1") ? "Completed" : "Not Completed";

                                // Display the data
                                Console.WriteLine($"{reader["Id"]} | {reader["Description"]} | {completionStatus} | {reader["CreatedOn"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong viewing the todos: " + ex);
            }
        }

        public void DisplayCompletedTodos()
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    const string QUERY = "SELECT * FROM Todos Where IsCompleted = 1";

                    using (var cmd = new SQLiteCommand(QUERY, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Read the IsCompleted value as an integer
                                var isCompleted = reader["IsCompleted"];

                                // Use a conditional expression to display "Completed" or "Not Completed"
                                string completionStatus = (isCompleted.ToString() == "1") ? "Completed" : "Not Completed";

                                // Display the data
                                Console.WriteLine($"{reader["Id"]} | {reader["Description"]} | {completionStatus} | {reader["CreatedOn"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong viewing the todos: " + ex);
            }
        }

        public void DisplayNotCompletedTodos()
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    const string QUERY = "SELECT * FROM Todos Where IsCompleted = 0";

                    using (var cmd = new SQLiteCommand(QUERY, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Read the IsCompleted value as an integer
                                var isCompleted = reader["IsCompleted"];

                                // Use a conditional expression to display "Completed" or "Not Completed"
                                string completionStatus = (isCompleted.ToString() == "1") ? "Completed" : "Not Completed";

                                // Display the data
                                Console.WriteLine($"{reader["Id"]} | {reader["Description"]} | {completionStatus} | {reader["CreatedOn"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong viewing the todos: " + ex);
            }
        }

        public void UpdateTodo(int id, string description, int isCompleted, string createdOn)
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    const string SQLITE_UPDATE_QUERY = @"UPDATE Todos SET
                        Id = @Id,
                        Description = @Description,
                        IsCompleted = @IsCompleted,
                        CreatedOn = @CreatedOn
                    WHERE Id = @Id";

                    using (var cmd = new SQLiteCommand(SQLITE_UPDATE_QUERY, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@IsCompleted", isCompleted);
                        cmd.Parameters.AddWithValue("@CreatedOn", createdOn);

                        var rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            Console.WriteLine("Successfully updated todo");
                        else
                            Console.WriteLine("Failed to update todo");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, something went wrong trying deleteing todo: {ex.Message}");
            }
        }

        public void DeleteTodo(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    const string Query = @"DELETE FROM Todos WHERE ID = @Id";

                    using (var command = new SQLiteCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        var rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            Console.WriteLine("Successfully deleted todo");
                        else
                            Console.WriteLine("No todo with that id");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong trying to delete todo: {ex.Message}");
            }
        }


    }
}
