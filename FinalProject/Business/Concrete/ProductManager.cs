using System;
using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    [ValidationAspect(typeof(ProductValidator))]
    public IResult Add(Product product)
    {
        // is kodlari
        // validation
        // validation ile business kodlarini karistirma 
        // if (product.ProductName.Length < 2)
        // {
        //     return new ErrorResult(Messages.ProductNameInvalid);
        // }
        // yukaridaki kodlari zaten validation da verdik


        // var context = new ValidationContext<Product>(product);
        // ProductValidator productValidator = new ProductValidator();
        // var result = productValidator.Validate(context);
        // if (!result.IsValid)
        // {
        // throw new ValidationException(result.Errors);    
        // }
        // yukaridaki kodu direkt heryerde kullabilelim diye asagida ekledik 
        // CCC ( Cross Cutting Concerns)
        // ValidationTool.Validate(new ProductValidator(), product);
        _productDal.Add(product);
        return new SuccessResult(Messages.ProdutAdded);
    }

    public IDataResult<List<Product>> GetAll()
    {
        // is kodlari 
        // yetki kotrolu 
        if (DateTime.Now.Hour == 0)
        {
            return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
        }
        return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
    }

    public IDataResult<List<Product>> GetAllByCategoryId(int id)
    {
        return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
    }

    public IDataResult<Product> GetById(int productId)
    {
        return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
    }

    public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
    {
        return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
    }

    public IDataResult<List<ProductDetailDto>> GetProductDetails()
    {
        if (DateTime.Now.Hour == 0)
        {
            return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
        }
        return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
    }
}
