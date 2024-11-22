using System;
using System.Data.SQLite;

namespace campus_molndal_oop_adv_addressBook
{
    internal class AddressBook
    {
        // Connection string to the SQLite database
        private const string CONNECTION_STRING = "Data Source=addressbook.db;Version=3;";

        // Constructor
        public AddressBook()
        {
            CreateDatabaseAndTable();
        }

        // ----- CREATE DATABASE -----
        private void CreateDatabaseAndTable()
        {
            // Using statement ensures the connection is closed and disposed properly
            using (var connection = new SQLiteConnection(CONNECTION_STRING))
            {
                connection.Open(); // Open the connection to the database

                // SQL query to create the Contacts table if it does not exist
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Contacts (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Phone TEXT NOT NULL,
                    Email TEXT NOT NULL
                );";

                // Using statement ensures the command is disposed properly
                using (var cmd = new SQLiteCommand(createTableQuery, connection))
                {
                    cmd.ExecuteNonQuery(); // Execute the query to create the table
                }
            }
        }

        // ----- ADD CONTACT -----
        public void AddContact(string name, string phone, string email)
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    const string INSERT_QUERY = "INSERT INTO Contacts (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";

                    using (var cmd = new SQLiteCommand(INSERT_QUERY, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Kontakt tillagd.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid tillägg av kontakt: {ex.Message}");
            }
        }

        // ----- DISPLAY CONTACTS -----
        public void DisplayContacts()
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    const string QUERY = "SELECT * FROM Contacts";

                    using (var cmd = new SQLiteCommand(QUERY, connection))
                    {
                        // Execute the query and obtain a reader to read the results
                        using (var reader = cmd.ExecuteReader())
                        {

                            // Loop through the results and print each contact's details
                            while (reader.Read())
                            {
                                // Read and print the values of the Name, Phone, and Email columns
                                Console.WriteLine($"{reader["Id"]} | {reader["Name"]}, {reader["Phone"]}, {reader["Email"]}");
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid visning av kontakter: {ex.Message}");
            }
        }

        // ----- UPDATE A CONTACT -----
        public void UpdateContact(int id, string name, string phone, string email)
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    string QUERY = "UPDATE Contacts SET Name = @Name, Phone = @Phone, Email = @Email WHERE Id = @Id";

                    using (var command = new SQLiteCommand(QUERY, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Kontakt uppdaterad.");
                        }
                        else
                        {
                            Console.WriteLine("Ingen kontakt hittades med det ID:t.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid uppdatering av kontakt: {ex.Message}");
            }
        }

        // ----- DELETE A CONTACT -----
        public void DeleteContact(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    string QUERY = "DELETE FROM Contacts WHERE Id = @Id";

                    using (var command = new SQLiteCommand(QUERY, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        int rowsAffected = command.ExecuteNonQuery();
                        bool successDelete = rowsAffected > 0;

                        if (successDelete)
                            Console.WriteLine("Kontakt borttagen");
                        else
                            Console.WriteLine("Ingen kontakt hittades med det id");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid borttagning av kontakt: {ex.Message}");
            }
        }
    }
}
