## Skapa en ny SQLite-databas kallad "Library" och använd DB Browser för SQLite för att utföra följande uppgifter:


<i>Skapa en tabell kallad "Genres" med kolumnerna GenreID (primärnyckel) och GenreName</i>
```sqlite
CREATE TABLE Genres (
    GenreID INTEGER PRIMARY KEY AUTOINCREMENT,
    GenreName TEXT
);
```
<br />

<i>Lägg till minst 5 olika genrer i tabellen</i>
```sqlite
INSERT INTO Genres (GenreName)
VALUES
    ('Rock'),
    ('Techno'),
    ('House'),
    ('Metal'),
    ('Punk');
```
<br />

<i>Visa alla genrer sorterade i alfabetisk ordning</i>
```sqlite
SELECT *
FROM Genres
ORDER BY GenreName ASC;
```
<br />

<i>I "Library"-databasen, skapa en ny tabell kallad "Publishers" med kolumnerna PublisherID (primärnyckel), PublisherName och FoundedYear</i>
```sqlite
CREATE TABLE Publishers (
    PublisherID INTEGER PRIMARY KEY AUTOINCREMENT,
    PublisherName TEXT NOT NULL,
    FoundedYear INTEGER
);
```
<br />

<i>lägg till minst 3 förlag i tabellen</i>
```sqlite
INSERT INTO Publishers (PublisherName, FoundedYear)
VALUES 
    ('Penguin Random House', 1927),
    ('HarperCollins', 1989),
    ('Simon & Schuster', 1924);
```
<br />

<i>Skapa en tabell kallad "Books" i "Library"-databasen med följande kolumner 
* BookID (primärnyckel)
* Title
* PublicationYear
* ISBN
* GenreID (främmande nyckel som refererar till Genres-tabellen)
* PublisherID (främmande nyckel som refererar till Publishers-tabellen)</i>
```sqlite
CREATE TABLE Books (
	BookID INTEGER PRIMARY KEY AUTOINCREMENT,
	Title TEXT,
	PublicationYear INTEGER,
	ISBN TEXT UNIQUE,
	GenreID INTEGER,
	PublisherID INTEGER,
	FOREIGN KEY (GenreID) REFERENCES Genres(GenreID),
	FOREIGN KEY (PublisherID) REFERENCES Publishers(PublisherID)
);
```
<br />

<i>Lägg till minst 10 böcker i "Books"-tabellen. Se till att använda olika genrer och förlag för böckerna</i>
```sqlite
INSERT INTO Books(Title, PublicationYear, ISBN, GenreID, PublisherID)
VALUES
    ('To Kill a Mockingbird', 1960, '9780061120084', 1, 1),
    ('1984', 1949, '9780451524935', 1, 2),
    ('Pride and Prejudice', 1813, '9780141439518', 2, 3),
    ('The Great Gatsby', 1925, '9780743273565', 1, 1),
    ('Moby-Dick', 1851, '9781853260087', 1, 3),
    ('The Catcher in the Rye', 1951, '9780316769488', 1, 2),
    ('The Hobbit', 1937, '9780618968633', 3, 1),
    ('Harry Potter and the Sorcerers Stone', 1997, '9780439708180', 3, 2),
    ('The Road', 2006, '9780307387899', 4, 3),
    ('Sapiens: A Brief History of Humankind', 2011, '9780062316097', 5, 1);
```
> Tagit från ChatGPT, kan inga böcker själv! :D

<br />

<i>Skriv en SQL-fråga som visar titeln på alla böcker publicerade efter år 2000</i>
```sqlite
SELECT Title
FROM Books
WHERE PublicationYear > 2000
```
<br />

<i>Skriv en SQL-fråga som räknar antalet böcker per genre. Resultatet ska visa GenreName och antalet böcker</i>
```sqlite
SELECT GenreName, COUNT(BookID) AS NumberOfBooks
FROM Books
JOIN Genres ON Books.GenreID = Genres.GenreID
GROUP BY GenreName;
```
<br />

<i>Uppdatera publikationsåret för en specifik bok i "Books"-tabellen</i>
```sqlite
UPDATE Books
SET Title = '1994'
WHERE Title = '1984'
```
<br />

<i>Ta bort alla böcker från en specifik genre från "Books"-tabellen</i>
```sqlite
DELETE FROM Books
WHERE GenreID = 1
```
<br />

<i>Skapa en ny tabell kallad "Authors" med kolumnerna AuthorID (primärnyckel), AuthorName och BirthYear</i>
```sqlite
CREATE TABLE Authors(
	AuthorID INTEGER PRIMARY KEY AUTOINCREMENT
	AuthorName TEXT
	BirthYear INTEGER
)
```
<br />

<i>Skapa en kopplingstabell kallad "BookAuthors" som representerar många-till-många-relationen mellan böcker och författare. Tabellen ska ha kolumnerna BookID och AuthorID som främmande nycklar</i>
```sqlite
CREATE TABLE BookAuthors (
    BookID INTEGER,
    AuthorID INTEGER,
    PRIMARY KEY (BookID, AuthorID),
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)
);
```
<br />

<i>Lägg till minst 5 författare i "Authors"-tabellen</i>
```sqlite
INSERT INTO Authors (AuthorName, BirthYear)
VALUES
    ('Harper Lee', 1926),
    ('George Orwell', 1903),
    ('Jane Austen', 1775),
    ('J.R.R. Tolkien', 1892),
    ('Mark Twain', 1835);
```
> Tagit från ChatGPT, kan inga författare själv! :D

<br />

<i>koppla dem till böcker i "BookAuthors"-tabellen</i>
```sqlite
INSERT INTO BookAuthors (BookID, AuthorID)
VALUES
    (3, 1),
    (7, 2),
    (8, 3),
    (9, 4),
    (10, 5);
```
> TRIGGER VARNING, detta är inte dom riktiga kopplingarna :P

<br />

<i>Skriv en SQL-fråga som visar titeln på alla böcker tillsammans med deras respektive författares namn</i>
```sqlite
SELECT Books.Title, Authors.AuthorName
FROM Books
JOIN BookAuthors ON Books.BookID = BookAuthors.BookID
JOIN Authors ON BookAuthors.AuthorID = Authors.AuthorID
```
<br />

<i>Skriv en SQL-fråga som hittar den författare som har skrivit flest böcker</i>
```sqlite
SELECT Authors.AuthorName, COUNT(BookAuthors.BookID) AS BookCount
FROM Authors
JOIN BookAuthors ON Authors.AuthorID = BookAuthors.AuthorID
GROUP BY Authors.AuthorID
ORDER BY BookCount DESC
LIMIT 1;
```
<br />

<i>Skapa en ny tabell kallad "Loans" som representerar utlåning av böcker. Tabellen ska ha kolumnerna LoanID (primärnyckel), BookID (främmande nyckel), LoanDate och ReturnDate</i>
```sqlite
CREATE TABLE Loans(
	LoanID INTEGER PRIMARY KEY AUTOINCREMENT,
	BookID INTEGER,
	Loandate date,
	ReturnDate, date
	FOREIGN KEY BookID REFERENCES Books.BookID
)
```
<br />

<i>Skriv SQL-frågor för att:
* Lägga till ett nytt lån i "Loans"-tabellen</i>
```sqlite
INSERT INTO Loans (BookID, LoanDate, ReturnDate)
VALUES 
	(10, '2024-11-20', NULL);
```

* <i>Visa alla böcker som för närvarande är utlånade (där ReturnDate är NULL)</i>
```sqlite
SELECT Books.Title, Loans.LoanDate
FROM Loans
JOIN Books ON Loans.BookID = Books.BookID
WHERE Loans.ReturnDate IS NULL;
```

* <i>Uppdatera ReturnDate när en bok returneras</i>
```sqlite
UPDATE Loans
SET ReturnDate = '2024-11-25'
WHERE BookID = 1 AND ReturnDate IS NULL;
```