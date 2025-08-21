using System;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;
// inmemory icinde product data access layer
public class InMemoryProductDal : IProductDal
{
    List<Product> _products;

    public InMemoryProductDal()
    {
        _products = new List<Product>
        {
            new Product{ProductId=1, CategoryId=1, ProductName="Telefon", UnitPrice=1500, UnitsInStock= 3},
            new Product{ProductId=2, CategoryId=1, ProductName="Bilgisayar", UnitPrice=24000, UnitsInStock= 12},
            new Product{ProductId=3, CategoryId=1, ProductName="Koruyucu Ekran", UnitPrice=122, UnitsInStock= 19},
            new Product{ProductId=4, CategoryId=2, ProductName="Klayve", UnitPrice=2300, UnitsInStock= 65},
            new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=1350, UnitsInStock= 43},
        };
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Delete(Product product)
    {
        Product deleteProductInList = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
        // foreach (var p in _products)
        // {
        //     if (p.ProductId == product.ProductId)
        //     {
        //         deleteProductInList = p;
        //         _products.Remove(deleteProductInList);
        //     }
        // }

        // deleteProductInList = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        _products.Remove(deleteProductInList);
      
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        return _products;
    }

    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAllByCategoryId(int categoryId)
    {
        return _products.Where(p => p.CategoryId == categoryId).ToList();
    }

    public void Update(Product product)
    {
        Product p = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
        p.CategoryId = product.CategoryId;
        p.ProductName = product.ProductName;
        p.UnitPrice = product.UnitPrice;
        p.UnitsInStock = product.UnitsInStock;

    }
}
