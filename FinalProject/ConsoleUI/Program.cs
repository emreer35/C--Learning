// See https://aka.ms/new-console-template for more information



using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());

// foreach (var product in productManager.GetAll())
// {
//     System.Console.WriteLine(product.ProductName);
// }

foreach (var product in productManager.GetAllByCategoryId(2))
{
    System.Console.WriteLine(product.ProductName);
}