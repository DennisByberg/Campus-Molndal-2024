## �vningsuppgifter

### Uppgift 1: J�mf�relsetabell
Skapa en j�mf�relsetabell �ver MySQL, SQLite och H2 med kriterier som skalbarhet, prestanda, s�kerhet och resurshantering.

| **Kriterium**       | **MySQL**                                                                 | **SQLite**                                                         | **H2**                                                                 |
|----------------------|---------------------------------------------------------------------------|----------------------------------------------------------------------|------------------------------------------------------------------------|
| **Skalbarhet**      | **H�g:** Designad f�r stora system, st�djer flera anv�ndare och stora databaser. | **Begr�nsad:** B�st f�r sm� applikationer och enanv�ndar-scenarion. | **M�ttlig:** Kan hantera mindre till medelstora databaser, men inte f�r stora produktionsmilj�er. |
| **Prestanda**       | **Bra:** Snabb vid h�g belastning och st�d f�r avancerad caching och optimering. | **Utm�rkt:** L�g overhead och snabb vid sm� datam�ngder.            | **Bra:** Snabb f�r in-memory-anv�ndning, men n�got l�ngsammare �n SQLite f�r st�rre dataset. |
| **S�kerhet**        | **Stark:** St�d f�r anv�ndarhantering, rollbaserad �tkomst och avancerad kryptering. | **Begr�nsad:** Ingen inbyggd anv�ndarhantering, baseras p� fil�tkomsts�kerhet. | **M�ttlig:** St�d f�r enkla autentiseringar och kryptering, men mindre robust �n MySQL. |
| **Resurshantering** | **Kr�ver resurser:** Kr�ver dedikerade resurser som server och RAM, men �r optimerad f�r prestanda. | **Minimal:** Extremt l�g resursf�rbrukning, l�mplig f�r inbyggda system. | **L�g:** L�g resursf�rbrukning, s�rskilt f�r in-memory-databaser.                            |


### Uppgift 2: V�lj r�tt databas
F�r varje scenario nedan, v�lj den mest l�mpliga databasen och motivera valet:

* En e-handelsplattform med tusentals dagliga anv�ndare.
> F�r en e-handelsplattform med tusentals dagliga anv�ndare passar MySQL b�st eftersom det �r skalbart och hanterar h�g trafik effektivt.
Det erbjuder avancerad s�kerhet och prestanda som kr�vs f�r en komplex plattform med flera samtidiga anv�ndare. 

* En app f�r personlig ekonomi p� mobilen.
> F�r en app f�r personlig ekonomi p� mobilen �r SQLite idealisk eftersom den �r l�ttviktig, resurseffektiv och fungerar bra som en inb�ddad databas, vilket g�r den perfekt f�r lokala data p� mobila enheter.

* Ett testsystem f�r en Java-baserad applikation.
> F�r ett testsystem f�r en Java-baserad applikation �r H2 mest l�mplig eftersom den erbjuder in-memory-funktioner f�r snabba tester, �r enkel att integrera med Java och kr�ver minimal konfiguration.

### Uppgift 3: Implementera i MySQL och SQLite

Skapa en tabell Users med kolumner UserID, Name, och Email.

`SQLite` :
```Sqlite
CREATE TABLE Users (
    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Email TEXT NOT NULL
)
```

`MySQL` : 
```MySQL
CREATE TABLE Users (
    UserId INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL
);
```

L�gg till och l�s data fr�n tabellen med SQL-fr�gor.

`SQLite` :
```Sqlite
INSERT INTO Users(Name, Email)
    VALUES('Dennis', 'Dennis@mail.com');

SELECT * FROM Users;
```

`MySQL` : 
```MySQL
INSERT INTO Users (Name, Email)
    VALUES ('Dennis', 'Dennis@mail.com');

SELECT * FROM Users;
```