



using EntityFramework;

ProductDal productDal = new ProductDal();

foreach (var item in productDal.GetAll())
{
    System.Console.WriteLine(item.Name);
}
System.Console.WriteLine("------------------");

productDal.Add(new Product
{
    Name = "Urun 1",
    StockAmount = 11,
    UnitPrice = 1500
});
System.Console.WriteLine("------------------");
foreach (var item in productDal.GetAll())
{
    System.Console.WriteLine(item.Name);
}

productDal.Update(new Product
{
    Id = 2,
    Name = "Guncellenen urun",
    StockAmount = 15,
    UnitPrice = 15000
});
System.Console.WriteLine("------------------");
foreach (var item in productDal.GetAll())
{
    System.Console.WriteLine(item.Name);
}

productDal.Delete(new Product
{
    Id = 4
});

