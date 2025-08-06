// See https://aka.ms/new-console-template for more information
using OOP1;

Console.WriteLine("Hello, World!");



Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 3;
product1.ProductName = "Kiraz";
product1.UnitPrice = 450;
product1.UnitsInStock = 5;


Product product2 = new Product { Id = 1, CategoryId = 4, ProductName = "Ayva", UnitPrice = 190, UnitsInStock = 12 };

// System.Console.WriteLine(product1.ProductName);
System.Console.WriteLine("--------------------------");
// Pascal Case // camelCase
ProductManager productManager = new ProductManager();
productManager.Add(product1);
System.Console.WriteLine(product1.ProductName);



// int sayi = 1000;
// productManager.AnotherWay(sayi);
// System.Console.WriteLine(sayi);



