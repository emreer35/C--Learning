-- Select
-- aslinda fake bir tabloyu gosteriyor
-- SELECT ContactName FROM Customers  

-- SELECT * FROM Customers WHERE City = 'London' 

-- SELECT * FROM Products WHERE CategoryID = 1 OR CategoryID = 3 

-- SELECT * FROM Products WHERE CategoryID = 1 AND UnitPrice >= 10

-- SELECT * from Products ORDER BY ProductName ASC -- ascending (artan)
-- SELECT * from Products ORDER BY ProductName DESC -- descending (azalan)
-- once category id ye gore sonra onlari da product name e gore siralar
-- SELECT * FROM Products ORDER BY CategoryID,ProductName  


SELECT COUNT(*) FROM Products
-- group by kategori id ye gore grupla 
SELECT CategoryID from Products GROUP BY CategoryID 
SELECT COUNT(*) from Products GROUP BY CategoryID 
SELECT CategoryID,COUNT(*) from Products GROUP BY CategoryID 

-- count kimulatiftir
-- having de kimulatif seylere konulur 
SELECT CategoryID,COUNT(*) from Products GROUP BY CategoryID HAVING COUNT(*) < 10 


SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName -- * kolonlari sectik 
from Products INNER JOIN Categories -- hangi tablolari kullancagimizi sectik
ON Products.CategoryID = Categories.CategoryID -- tablolarda ki hangi eslesmeleri yapacagimizi sectik


-- solda olup sagda olmayanlari getir

SELECT * from Products p LEFT JOIN Categories c ON
p.CategoryID = c.CategoryID 

SELECT * FROM Customers c INNER JOIN Orders o on
c.CustomerID = o.CustomerID -- 830 tane
INNER JOIN [Order Details] on o.OrderID = [Order Details].OrderID

SELECT * FROM Customers c LEFT JOIN Orders o on
c.CustomerID = o.CustomerID  -- 832 tane 
WHERE o.CustomerID is NULL
