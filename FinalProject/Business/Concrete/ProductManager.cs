using System;
using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public IResult Add(Product product)
    {
        // is kodlari
        if (product.ProductName.Length < 2)
        {
            return new ErrorResult("Urun adi min 2 karakter olmak zorunda");
        }
        _productDal.Add(product);
        return new SuccessResult("Urun Eklendi");
    }

    public List<Product> GetAll()
    {
        // is kodlari 
        // yetki kotrolu 
        return _productDal.GetAll();
    }

    public List<Product> GetAllByCategoryId(int id)
    {
        return _productDal.GetAll(p => p.CategoryId == id);
    }

    public Product GetById(int productId)
    {
        return _productDal.Get(p => p.ProductId == productId);
    }

    public List<Product> GetByUnitPrice(decimal min, decimal max)
    {
        return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
    }

    public List<ProductDetailDto> GetProductDetails()
    {
        return _productDal.GetProductDetails();
    }
}
