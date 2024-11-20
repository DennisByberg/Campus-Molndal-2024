## Här är en serie övningsuppgifter som bygger på det vi har gått igenom under dagen, med stegrande svårighetsgrad:

<i>Skapa en tabell för "Movies" med kolumner för ID, titel, regissör, utgivningsår och genre. Lägg till minst fem filmer i tabellen.</i>
```sqlite
CREATE TABLE Movies (
	ID INTEGER PRIMARY KEY AUTOINCREMENT,
	Title TEXT NOT NULL,
	Director TEXT NOT NULL,
	PublicationYear INTEGER,
	Genre TEXT NOT NULL
);

INSERT INTO Movies (Title, Director, PublicationYear, Genre)
VALUES
    ('The Damned United', 'Tom Hooper', 2009, 'Sports Drama'),
    ('Goal! The Dream Begins', 'Danny Cannon', 2005, 'Sports Drama'),
    ('Rudy', 'David Anspaugh', 1993, 'Sports Drama'),
    ('The Mighty Ducks', 'Stephen Herek', 1992, 'Sports Comedy'),
    ('Bend It Like Beckham', 'Gurinder Chadha', 2002, 'Comedy Drama');
```
<br>

<i>Skriv en SQL-fråga som hämtar alla filmer sorterade efter utgivningsår i fallande ordning.</i>
```sqlite
SELECT * FROM Movies
ORDER BY PublicationYear DESC
```
<br>

<i>Skapa en tabell för "Actors" med kolumner för ID, namn och födelsedatum. Lägg till minst fem skådespelare.</i>
```sqlite
CREATE TABLE Actors (
	ID INTEGER PRIMARY KEY AUTOINCREMENT,
	ActorName TEXT NOT NULL,
	Birthday DATE
);

INSERT INTO Actors (ActorName, Birthday)
VALUES
    ('Leonardo DiCaprio', '1974-11-11'),
    ('Meryl Streep', '1949-06-22'),
    ('Denzel Washington', '1954-12-28'),
    ('Scarlett Johansson', '1984-11-22'),
    ('Morgan Freeman', '1937-06-01');
```
<br>

<i>Skapa en kopplingstabell "MovieActors" som kopplar ihop filmer och skådespelare (många-till-många relation). Lägg till några kopplingar mellan filmer och skådespelare.</i>
```sqlite
CREATE TABLE MovieActors (
	MovieID INTEGER,
	ActorID INTEGER,
	PRIMARY KEY (MovieID, ActorID),
	FOREIGN KEY (MovieID) REFERENCES Movies(ID),
	FOREIGN KEY (ActorID) REFERENCES Actors(ID)
);

INSERT INTO MovieActors(MovieID, ActorID)
VALUES
	(1,1),
	(2,2),
	(3,3),
	(4,4),
	(5,5);
```
<br>

<i>Skriv en SQL-fråga som visar alla filmer tillsammans med deras skådespelare.</i>
```sqlite
SELECT
	Movies.Title AS MovieTitle,
	Actors.ActorName AS ActorName
FROM
	MovieActors
INNER JOIN
	Movies ON MovieActors.MovieID = Movies.ID
INNER JOIN
	Actors ON MovieActors.ActorID = Actors.ID;
```
<br>

<i>Använd GROUP BY för att visa hur många filmer varje regissör har gjort.</i>
```sqlite
SELECT
	Director,
	COUNT(*) AS NumberOfMovies
FROM 
	Movies
GROUP BY 
	Director;
```
<br>

<i>Skapa en vy (VIEW) som visar filmer tillsammans med antalet skådespelare för varje film.</i>
```sqlite
CREATE VIEW MoviesWithActorCount
AS
SELECT
	Movies.Title AS MovieTitle,
	Count(MovieActors.ActorID) AS ActorCount
FROM
	Movies
LEFT JOIN
	MovieActors ON Movies.ID = MovieActors.MovieID
GROUP BY
	Movies.ID, Movies.Title
```
<br>

<i>Skriv en SQL-fråga som använder en subquery för att hitta alla filmer som har fler än genomsnittligt antal skådespelare.</i>
```sqlite
SELECT Movies.Title, COUNT(MovieActors.ActorID) AS ActorCount
FROM Movies
LEFT JOIN MovieActors ON Movies.ID = MovieActors.MovieID
GROUP BY Movies.ID
HAVING COUNT(MovieActors.ActorID) > (
    SELECT AVG(ActorCount)
    FROM (
        SELECT COUNT(MovieActors.ActorID) AS ActorCount
        FROM Movies
        LEFT JOIN MovieActors ON Movies.ID = MovieActors.MovieID
        GROUP BY Movies.ID
    )
);
```
<br>

<i>Implementera en INNER JOIN för att visa alla filmer och deras skådespelare, men bara för filmer från 2000-talet.</i>
```sqlite
SELECT
	Movies.Title, Actors.ActorName
FROM 
	Movies
INNER JOIN
	MovieActors ON Movies.ID = MovieActors.MovieID
INNER JOIN
	Actors ON MovieActors.ActorID = Actors.ID
WHERE 
	Movies.PublicationYear 
		BETWEEN 2000
		AND 2099;
```
<br>

<i>Skapa en prepared statement för att lägga till nya filmer i databasen. Använd den sedan för att lägga till två nya filmer.</i>
```sqlite

```
<br>

<i>Skriv en SQL-fråga som använder UNION för att kombinera en lista av alla regissörer och alla skådespelare i en enda resultatlista utan dubbletter.</i>
```sqlite

```
<br>

<i>Skapa en trigger som automatiskt uppdaterar ett "last_updated" fält i Movies-tabellen varje gång en film ändras.</i>
```sqlite

```
<br>

<i>Implementera en stored procedure som tar ett årtal som input och returnerar alla filmer från det året tillsammans med deras skådespelare.</i>
```sqlite

```
<br>

<i>Skriv en komplex SQL-fråga som använder JOIN, GROUP BY, HAVING, och en subquery för att hitta alla skådespelare som har medverkat i mer än två filmer av samma regissör.</i>
```sqlite

```
<br>

<i>Skapa ett UML-diagram som visar relationerna mellan Movies, Actors, och MovieActors tabellerna. Inkludera primärnycklar och främmande nycklar.</i>
```sqlite

```
<br>
