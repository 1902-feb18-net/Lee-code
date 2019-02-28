select FirstName, LastName, CustomerId, Country from Customer where Country != 'USA';
select FirstName, LastName, CustomerId from Customer where Country = 'Brazil';
select FirstName, LastName, Title from Employee where Title = 'Sales Support Agent';
select distinct BillingCountry from Invoice;
select InvoiceDate from Invoice where datepart(year, InvoiceDate) = '2009';
select count(Invoicedate) as count, sum total as totalcost from invoiceLine where invoicedate >= '2009'and invoicedate < '2010'
