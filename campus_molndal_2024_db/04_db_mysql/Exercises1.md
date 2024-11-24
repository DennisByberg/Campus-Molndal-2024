## Övningsuppgifter

### Uppgift 1: Jämförelsetabell
Skapa en jämförelsetabell över MySQL, SQLite och H2 med kriterier som skalbarhet, prestanda, säkerhet och resurshantering.

| **Kriterium**       | **MySQL**                                                                 | **SQLite**                                                         | **H2**                                                                 |
|----------------------|---------------------------------------------------------------------------|----------------------------------------------------------------------|------------------------------------------------------------------------|
| **Skalbarhet**      | **Hög:** Designad för stora system, stödjer flera användare och stora databaser. | **Begränsad:** Bäst för små applikationer och enanvändar-scenarion. | **Måttlig:** Kan hantera mindre till medelstora databaser, men inte för stora produktionsmiljöer. |
| **Prestanda**       | **Bra:** Snabb vid hög belastning och stöd för avancerad caching och optimering. | **Utmärkt:** Låg overhead och snabb vid små datamängder.            | **Bra:** Snabb för in-memory-användning, men något långsammare än SQLite för större dataset. |
| **Säkerhet**        | **Stark:** Stöd för användarhantering, rollbaserad åtkomst och avancerad kryptering. | **Begränsad:** Ingen inbyggd användarhantering, baseras på filåtkomstsäkerhet. | **Måttlig:** Stöd för enkla autentiseringar och kryptering, men mindre robust än MySQL. |
| **Resurshantering** | **Kräver resurser:** Kräver dedikerade resurser som server och RAM, men är optimerad för prestanda. | **Minimal:** Extremt låg resursförbrukning, lämplig för inbyggda system. | **Låg:** Låg resursförbrukning, särskilt för in-memory-databaser.                            |


### Uppgift 2: Välj rätt databas
För varje scenario nedan, välj den mest lämpliga databasen och motivera valet:

* En e-handelsplattform med tusentals dagliga användare.
> För en e-handelsplattform med tusentals dagliga användare passar MySQL bäst eftersom det är skalbart och hanterar hög trafik effektivt.
Det erbjuder avancerad säkerhet och prestanda som krävs för en komplex plattform med flera samtidiga användare. 

* En app för personlig ekonomi på mobilen.
> För en app för personlig ekonomi på mobilen är SQLite idealisk eftersom den är lättviktig, resurseffektiv och fungerar bra som en inbäddad databas, vilket gör den perfekt för lokala data på mobila enheter.

* Ett testsystem för en Java-baserad applikation.
> För ett testsystem för en Java-baserad applikation är H2 mest lämplig eftersom den erbjuder in-memory-funktioner för snabba tester, är enkel att integrera med Java och kräver minimal konfiguration.

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

Lägg till och läs data från tabellen med SQL-frågor.

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