-- joins
-- cross joins
SELECT *
FROM Employee AS e1 CROSS JOIN Employee AS e2;

-- inner joins
--  most commonly used
--  mostly used with foreign key = primary key
SELECT *
FROM Track INNER JOIN Genre ON Track.GenreId = Genre.GenreId;

-- 3 kinds of outer joins
--  left join: preserves data in left table while filling missing values with null
--  right join: same just opposite
--  full join

-- getting artist name and genre
SELECT *
FROM Track as t
	INNER JOIN Album AS al ON t.AlbumId = al.AlbumId
	INNER JOIN Artist AS ar ON al.ArtistId = ar.ArtistId
	INNER JOIN Genre AS g ON t.GenreId = g.GenreId
WHERE g.Name = 'Rock';

-- every employee together with who they report to if any
SELECT emp.FirstName + ' ' + emp.LastName AS Employee,
	mng.FirstName + ' '  + mng.LastName AS Manager
FROM Employee AS emp
	LEFT OUTER JOIN Employee AS mng ON emp.ReportsTo = mng.EmployeeId;

-- subqueries
-- more ways to combine info from multiple tables

-- every track that has never been purchased
SELECT *
FROM Track AS t
where t.TrackId NOT IN(
	SELECT TrackId
	FROM InvoiceLine
);

-- TOP(n) to take the first n results
SELECT t.Name
FROM Track AS t
WHERE t.TrackId = (
	SELECT TOP(1) TrackId
	FROM InvoiceLine
	GROUP BY TrackId
	ORDER BY COUNT(*) DESC
);

-- subqueries can go in the HAVING clause and in the FROM clause

SELECT *
FROM
SELECT Artist.Name AS Artist, Album.Title AS Album.AlbumId as Album,Id
FROM Artist JOIN Album ON Album.ArtistId = Artist.ArtistId

WITH purchased_tracks AS(
	SELECT DISTINCT TrackId
	FROM InvoiceLine
	)
SELECT *
FROM Track AS t
WHERE t.TrackId NOT IN (
	SELECT TrackId
	FROM purchased_tracks
	);

-- other subquery operators
-- EXISTS, NOT EXISTS
-- SOME, ANY, ALL

-- get the artist who made the album with the longest title

SELECT *
FROM Artist
WHERE ArtistId = (
	SELECT ArtistId
	FROM Album
	WHERE LEN(Title) >= ALL (SELECT LEN(Title) FROM Album)
	);

SELECT *
FROM Artist
WHERE ArtistId = (
	SELECT TOP(1) ArtistId
	FROM Album
	ORDER BY LEN(Title) DESC
	);

-- set operations
-- we have mathematical sets the concepts of
-- UNION, INTERSECT, and (set difference) EXCEPT

-- all first names of customers and employees
SELECT FirstName FROM Customer
UNION
SELECT FirstName FROM Employee;

-- for each set op, we have a DISTINCT version and an ALL version
-- DISTINCT is the default

-- UNION gives values that are in EITHER result
-- INTERSECT gives you the values that are in BOTH
-- EXCEPT gives values that are only in one side (not in both)


-- DML
--  SELECT, INSERT, UPDATE, DELETE, TRUNCATE TABLE
--  INSTERT

INSERT INTO Genre (GenreId, Name) VALUES
(
(SELECT MAX(genreId)FROM Genre) +1,
'ElectroTek'
)

-- UPDATE

UPDATE Genre
SET Name = 'funk' -- can change more than 1 col
WHERE Name = 'discotek'
-- if we leave out WHERE we would update every row


-- DELETE
DELETE Genre
WHERE GenreId = 26;

-- TRUNCATE TABLE
-- TRUNCATE TABLE Genre
-- deletes whole table with no conditions



-- DDL
-- whole table manipulation
-- CREATE, ALTER, DROP

-- CREATE SCHEMA
GO -- GO is a special keyword to separate batches of commands
CREATE SCHEMA Movie;
GO
--CREATE table
CREATE TABLE Movie.Movie(
	MovieId INT
);

ALTER TABLE Movie.Movie ADD Title NVARCHAR(200);

DROP TABLE Movie.Movie

-- Constraints when creating
-- NOT NULL
-- NULL
-- PRIMARY KEY (sets PK, enforces uniqueness, sets clustered index)
-- UNIQUE
-- CHECK (arbitrary condition that must be true)
-- DEFAULT (gives default value for column)
-- FORIEGN KEY
-- IDENTITY (AUTO INCREMENT)
CREATE TABLE Movie.Movie(
	MovieId INT NOT NULL PRIMARY KEY IDENTITY,
	Title NVARCHAR(200) NOT NULL,
	ReleaseDate DATETIME2 NOT NULL,
	DateModified DATETIME2 NOT NULL DEFAULT(GETDATE())
	CONSTRAINT U_Movie_Title_Date UNIQUE (Title, ReleaseDate),
	CONSTRAINT CHK_Date CHECK (ReleaseDate > 1900)


