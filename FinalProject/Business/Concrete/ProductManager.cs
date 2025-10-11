using System;
using Business.Abstract;
using Business.CCS;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
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
    ICategoryService _categoryService;


    public ProductManager(IProductDal productDal, ICategoryService categoryService)
    {
        _productDal = productDal;
        _categoryService = categoryService;
    }
    // claim (iddia etmek)
    // [SecuredOperation]
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

        // Asagidaki kodu zaten refactore ettik 
        // var productCount = _productDal.GetAll(p => p.CategoryId == product.CategoryId).Count();
        // if (productCount >= 10)
        // {
        //     return new ErrorResult(Messages.ProductCountError);
        // }

        // if (CheckIfProductOfCategoryCountCorrect(product.CategoryId).Success)
        // {
        //     if (CheckIfProductNameExists(product.ProductName).Success)
        //     {
        //         _productDal.Add(product);
        //         return new SuccessResult(Messages.ProdutAdded);
        //     }
        // }
        // surekli ic ice yazmak yerine Core icine static business rule yapip asagidaki sekilde cagiririz

        IResult result = BusinessRules.Run(
            CheckIfProductOfCategoryCountCorrect(product.CategoryId),
            CheckIfProductNameExists(product.ProductName),
            CheckIfCategoryLimitExceded()
        );

        if (result != null)
        {
            return result;
        }
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

    public IResult Update(Product product)
    {

        if (CheckIfProductOfCategoryCountCorrect(product.CategoryId).Success)
        {
            if (CheckIfProductNameExists(product.ProductName).Success)
            {
                _productDal.Update(product);
                return new SuccessResult(Messages.ProdutAdded);
            }
        }
        return new ErrorResult();
    }
    // eger ki bu bir is parcacaigi ise bunu gelip buraya yazacaksin 
    // ama aa ben bu kodu baska seylerde de yazarim dersen o zaman public yapamazsin 
    // gidersin service e yazarsin implemente edersin 
    private IResult CheckIfProductOfCategoryCountCorrect(int categoryId)
    {
        var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count();
        if (result >= 10)
        {
            return new ErrorResult(Messages.ProductCountError);
        }
        return new SuccessResult();
    }
    private IResult CheckIfProductNameExists(string productName)
    {
        var result = _productDal.GetAll(p => p.ProductName == productName).Any();
        if (result)
        {
            return new ErrorResult(Messages.ProductNameExist);
        }
        return new SuccessResult();
    }

    // product iicn kategory servisi nasil uyarlaniyor onu goruyoruz
    private IResult CheckIfCategoryLimitExceded()
    {
        var result = _categoryService.GetAll();
        if (result.Data.Count() > 15)
        {
            return new ErrorResult(Messages.CategoryLimitExceded);
        }
        return new SuccessResult();
    }
}
