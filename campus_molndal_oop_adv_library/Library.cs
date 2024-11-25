using System;
using System.Data.SQLite;

namespace campus_molndal_oop_adv_library
{
    enum TablesSchema
    {
        Books,
        Borrowers
    }

    enum BorrowersSchema
    {
        Id,
        Name,
        Email
    }

    enum BooksSchema
    {
        Id,
        Title,
        Author,
        Publication_Year
    }

    internal class Library
    {

        private const string CONNECTION_STRING = "Data Source=library.db;";

        public Library()
        {
            try
            {
                CreateDatabaseAndTables();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ett fel uppstod vid skapandet av databasen eller tabellen: {ex.Message}");
            }
        }

        private void CreateDatabaseAndTables()
        {
            using (var connection = new SQLiteConnection(CONNECTION_STRING))
            {
                connection.Open();

                string CREATE_BOOKS_TABLE_QUERY = $@"CREATE TABLE IF NOT EXISTS {TablesSchema.Books} (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL,
                    Author TEXT NOT NULL,
                    Publication_Year INTEGER NOT NULL
                );";

                string CREATE_BORROWERS_TABLE_QUERY = $@"
                    CREATE TABLE IF NOT EXISTS {TablesSchema.Borrowers} (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Email TEXT NOT NULL
                    );";

                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = new SQLiteCommand(CREATE_BOOKS_TABLE_QUERY, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (var command = new SQLiteCommand(CREATE_BORROWERS_TABLE_QUERY, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }
        }

        public void AddBook(string title, string author, int publicationYear)
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    string INSERT_INTO_BOOKS_QUERY =
                       $"INSERT INTO {TablesSchema.Books}(Title, Author, Publication_Year) VALUES (@Title, @Author, @Publication_Year)";

                    using (var command = new SQLiteCommand(INSERT_INTO_BOOKS_QUERY, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Author", author);
                        command.Parameters.AddWithValue("@Publication_Year", publicationYear);

                        command.ExecuteNonQuery();

                        Console.WriteLine("Book Added");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void AddBorrower(string name, string email)
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    string QUERY = $@"
                    INSERT INTO {TablesSchema.Borrowers}(Name, Email)
                    VALUES(@Name, @Email)";

                    using (var command = new SQLiteCommand(QUERY, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);

                        command.ExecuteNonQuery();

                        Console.WriteLine("Borrower Added");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DisplayBooks()
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    string QUERY = $"SELECT * FROM {TablesSchema.Books}";

                    using (var command = new SQLiteCommand(QUERY, connection))
                    {
                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[$"{BooksSchema.Id}"]} | {reader[$"{BooksSchema.Title}"]} | {reader[$"{BooksSchema.Author}"]} | {reader[$"{BooksSchema.Publication_Year}"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DisplayBorrowers()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {TablesSchema.Borrowers}";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        SQLiteDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[$"{BorrowersSchema.Id}"]} | {reader[$"{BorrowersSchema.Name}"]} | {reader[$"{BorrowersSchema.Email}"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
