using System;
using System.Data.SQLite;

namespace campus_molndal_oop_adv_library
{
    enum TablesSchema
    {
        Books,
        Borrowers,
        Loans
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

    enum LoansSchema
    {
        Loan_Id,
        Book_Id,
        Borrower_Id,
        Loan_Date,
        Return_Date
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

                string CREATE_BOOKS_TABLE_QUERY = $@"
                    CREATE TABLE IF NOT EXISTS {TablesSchema.Books} (
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

                string CREATE_LOANS_TABLE_QUERY = $@"
                    CREATE TABLE IF NOT EXISTS {TablesSchema.Loans} (
                    {LoansSchema.Loan_Id} INTEGER PRIMARY KEY AUTOINCREMENT,
                    {LoansSchema.Book_Id} INTEGER NOT NULL,
                    {LoansSchema.Borrower_Id} INTEGER NOT NULL,
                    {LoansSchema.Loan_Date} TEXT,
                    {LoansSchema.Return_Date} TEXT,
                    FOREIGN KEY ({LoansSchema.Book_Id}) REFERENCES {TablesSchema.Books}(Id),
                    FOREIGN KEY ({LoansSchema.Borrower_Id}) REFERENCES {TablesSchema.Borrowers}(Id)
                );";

                string CREATE_INDEXES_QUERY = $@"
                    CREATE INDEX IF NOT EXISTS idx_books_title ON {TablesSchema.Books}(Title);
                    CREATE INDEX IF NOT EXISTS idx_books_author ON {TablesSchema.Books}(Author);
                    CREATE INDEX IF NOT EXISTS idx_books_publication_year ON {TablesSchema.Books}(Publication_Year);
                    CREATE INDEX IF NOT EXISTS idx_borrowers_name ON {TablesSchema.Borrowers}(Name);
                    CREATE INDEX IF NOT EXISTS idx_loans_book_id ON {TablesSchema.Loans}({LoansSchema.Book_Id});
                    CREATE INDEX IF NOT EXISTS idx_loans_borrower_id ON {TablesSchema.Loans}({LoansSchema.Borrower_Id});
                ";

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

                    using (var command = new SQLiteCommand(CREATE_LOANS_TABLE_QUERY, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (var command = new SQLiteCommand(CREATE_INDEXES_QUERY, connection))
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

        public void BorrowBook(int bookId, int borrowerId, DateTime loanDate)
        {
            try
            {
                using (var connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    const string QUERY = @"
                    INSERT INTO Loans (
                        Book_Id,
                        Borrower_Id,
                        Loan_Date
                    )
                    VALUES (
                        @BookId,
                        @BorrowerId,
                        @LoanDate
                    );";

                    using (var command = new SQLiteCommand(QUERY, connection))
                    {
                        command.Parameters.AddWithValue("@BookId", bookId);
                        command.Parameters.AddWithValue("@BorrowerId", borrowerId);
                        command.Parameters.AddWithValue("@LoanDate", loanDate);

                        command.ExecuteNonQuery();

                        Console.WriteLine("Loan successfully recorded.");
                    }
                }
            }
            catch (SQLiteException sqEx)
            {
                Console.WriteLine($"Database error: {sqEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void ReturnBook(int loanId, DateTime returnDate)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    string query = $@"
                    UPDATE Loans
                    SET Return_Date = @Return_Date
                    WHERE Loan_Id = @Loan_Id;";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Return_Date", returnDate);
                        command.Parameters.AddWithValue("@Loan_Id", loanId);

                        command.ExecuteNonQuery();

                        Console.WriteLine($"Updated loan #{loanId}");
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