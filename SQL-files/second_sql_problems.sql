-- all invoices of customers from brazil (mailing address)
SELECT c.FirstName, c.LastName, i.*
FROM Invoice AS i JOIN Customer AS c ON i.CustomerId = c.CustomerId
WHERE c.Country = 'Brazil';

-- show all invoices together with the name of the sales agent of each one
SELECT i.*, e.FirstName, e.LastName
FROM Invoice AS i
	JOIN Customer AS c ON i.CustomerId = c.CustomerId
	JOIN Employee AS e ON c.SupportRepId = e.EmployeeId;

-- show all playlists ordered by the total number of tracks they have
SELECT *
FROM Track AS t
	JOIN PlaylistTrack AS pt ON t.TrackId = pt.TrackId
	JOIN Playlist AS pl ON pt.PlaylistId = pl.PlaylistId
WHERE; 

-- artists that did not make any albums
SELECT *
FROM Artist
WHERE ArtistId NOT IN (
	SELECT ArtistId
	FROM Album
	);
	
-- which artists did not record any tracks of the Latin genre?
SELECT *
FROM Artist AS ar
	JOIN Album AS al ON ar.ArtistId = al.ArtistId
	JOIN Track AS t ON al.Title = t.Name
	JOIN Genre AS g ON t.GenreId = g.GenreId
WHERE g.Name <> 'latin';

-- 1. insert two new records into the employee table.
INSERT INTO Employee (EmployeeId, LastName, FirstName, Title,
ReportsTo, BirthDate, HireDate, Address, City, State,
 Country, PostalCode, Phone, Fax,Email) VALUES
(9, 'Marshall', 'Lee', 'Coder', 10, 1994-05-29,
2019-02-18, '6479 flowa', 'flobra', 'GA', 'USA', 30542,
789, null, 'qwer@asdf.com'),
(10, 'Lunker', 'Lunk', 'Boss' ,null, 1997-06-26, null, null, null,
null, null, null, null, null, null);
SELECT * FROM Track;
-- 2. insert two new records into the tracks table.
INSERT INTO Track (TrackId, Name, AlbumId, MediaTypeId,
GenreId, Composer, Milliseconds, Bytes, UnitPrice) VALUES
(7895, 'djahv', 25, 2, 5, 'jaslkgha', 15688452, 56484, .85),
(11268, 'dlskjav', 65, 2,5,'vkajrh', 165846, 16546, .90);
-- 3. update customer Aaron Mitchell's name to Robert Walter
UPDATE Customer
SET FirstName = 'Robert', LastName = 'Walter'
WHERE FirstName = 'Aaron' and LastName = 'Mitchell'
-- 4. delete one of the employees you inserted.
DELETE FROM Employee
WHERE FirstName = 'Lee' AND LastName = 'Marshall'
SELECT * FROM Employee
-- 5. delete customer Robert Walter. (more complex than it seems!)
SELECT InvoiceId from Invoice WHERE CustomerId = 32
DELETE FROM Invoice
WHERE InvoiceId = 342
DELETE FROM InvoiceLine
WHERE InvoiceId = 342
DELETE FROM Customer
WHERE FirstName = 'Robert' AND LastName = 'Walter'
SELECT * FROM Customer WHERE FirstName = 'Robert' AND LastName = 'Walter'