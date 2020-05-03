# LinqExcercises
https://github.com/emilj858/SQL-Exercises/blob/master/sql-exercises.sql
https://www.geeksengine.com/database/problem-solving/northwind-queries-part-1.php
https://docs.microsoft.com/en-us/samples/dotnet/try-samples/101-linq-samples/


SELECT CategoryName, Description 
FROM Categories
/* 1.  Write a query to return all category names with their descriptions from the Categories table. */ 

SELECT ContactName, CustomerID, CompanyName, City 
FROM Customers 
Where City = 'London';
/* 2. Write a query to return the contact name, customer id, company name and city name of all Customers in London */

Select * 
From Suppliers 
Where Fax != 'null' AND (ContactTitle = 'Marketing Manager' OR ContactTitle = 'Sales Representative');
/* 3. Write a query to return all available columns in the Suppliers tables for the marketing managers and sales representatives that have a FAX number */

SELECT CustomerID 
FROM Orders
Where RequiredDate BETWEEN '1997-1-1' AND '1997-12-31' AND Freight < 100
/* 4. Write a query to return a list of customer id's from the Orders table with required dates between Jan 1, 1997 and Dec 31, 1997 and with freight under 100 units. */

SELECT CompanyName, ContactName
FROM  Customers
Where Country = 'Mexico' OR Country = 'Germany' OR Country = 'Sweden';
/* 5. Write a query to return a list of company names and contact names of all customers from Mexico, Sweden and Germany. */

SELECT COUNT(Discontinued) 
FROM Products
/* 6. Write a query to return a count of the number of discontinued products in the Products table */

SELECT CategoryName, Description
FROM Categories
WHERE CategoryName LIKE 'co%';
/* 7. Write a query to return a list of category names and descriptions of all categories beginning with 'Co' from the Categories table. */

SELECT CompanyName, City, Country, PostalCode
FROM Suppliers
WHERE Address LIKE '%rue%' ORDER BY CompanyName;
/* 8. Write a query to return all the company names, city, country and postal code from the Suppliers table with the word 'rue' in their address. The list should ordered alphabetically by company name. */

Select ProductID, Quantity AS 'QuantityPurchased' 
From [Order Details]
ORDER BY QuantityPurchased Desc;
/* 9. Write a query to return the product id and the quantity ordered for each product labelled as 'Quantity Purchased' in the Order Details table ordered by the Quantity Purchased in descending order. */

Select CompanyName, Address, City, PostalCode, Country, OrderDate
From Orders
INNER JOIN Customers
ON Customers.CustomerID = Orders.CustomerID
Where Shipvia=1 
/* 10. Write a query to return the company name, address, city, postal code and country of all customers with orders that shipped using Speedy Express, along with the date that the order was made. */

Select CompanyName, ContactName, ContactTitle, Region
From Suppliers 
/* 11. Write a query to return a list of Suppliers containing company name, contact name, contact title and region description. */

Select ProductName
From Products
Where CategoryID = 2
/* 12. Write a query to return all product names from the Products table that are condiments. */

Select ContactName
From Customers
Where Customers.CustomerID NOT IN(
	Select CustomerID
	From Orders)
/* 13. Write a query to return a list of customer names who have no orders in the Orders table. */

INSERT INTO Shippers (CompanyName)
VALUES ('Amazon') 
/* 14. Write a query to add a shipper named 'Amazon' to the Shippers table using SQL. */

UPDATE Shippers 
Set CompanyName = 'Amazon Prime Shipping'
Where CompanyName = 'Amazon'
/* 15. Write a query to change the company name from 'Amazon' to 'Amazon Prime Shipping' in the Shippers table using SQL. */ 

SELECT Orders.ShipName, CONVERT(int,ROUND(SUM(Orders.Freight),0)) AS 'Freight Total'
FROM ORDERS
INNER JOIN Shippers
ON Shippers.ShipperID = Orders.ShipVia
GROUP BY Orders.ShipName;
/* 16. Write a query to return a complete list of company names from the Shippers table. Include freight totals rounded to the nearest whole number for each shipper from the Orders table for those shippers with orders. */

Select CONCAT (FirstName, + ' ' + LastName) AS 'DisplayName'
From Employees
/* 17. Write a query to return all employee first and last names from the Employees table by combining the 2 columns aliased as 'DisplayName'. The combined format should be 'LastName, FirstName'. */
