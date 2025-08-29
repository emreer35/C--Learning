

using ADONet;

ProductDal productDal = new ProductDal();

var result = productDal.GetAll();

System.Console.WriteLine(result);