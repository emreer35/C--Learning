// See https://aka.ms/new-console-template for more information



using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductTest();

// CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    // foreach (var product in productManager.GetAll())
    // {
    //     System.Console.WriteLine(product.ProductName);
    // }
    var result = productManager.GetProductDetails();
    if (result.Success)
    {

        foreach (var product in result.Data)
        {
            System.Console.WriteLine(product.ProductName + " / " + product.CategoryName);
        }
    }
    else
    {
        System.Console.WriteLine(result.Message);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        System.Console.WriteLine(category.CategoryName);
    }
}