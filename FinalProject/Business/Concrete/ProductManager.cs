using System;
using Business.Abstract;
using Business.Constans;
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
            return new ErrorResult(Messages.ProductNameInvalid);
        }
        _productDal.Add(product);
        return new SuccessResult(Messages.ProdutAdded);
    }

    public IDataResult<List<Product>> GetAll()
    {
        // is kodlari 
        // yetki kotrolu 
        if (DateTime.Now.Hour == 22)
        {
            return new ErrorDataResult();
        }
        return new SuccessDataResult<List<Product>>(_productDal.GetAll(), "Urunler basariyla listelendi");
    }

    public IDataResult<List<Product>> GetAllByCategoryId(int id)
    {
        return _productDal.GetAll(p => p.CategoryId == id);
    }

    public IDataResult<Product> GetById(int productId)
    {
        return _productDal.Get(p => p.ProductId == productId);
    }

    public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
    {
        return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
    }

    public IDataResult<List<ProductDetailDto>> GetProductDetails()
    {
        return _productDal.GetProductDetails();
    }
}
