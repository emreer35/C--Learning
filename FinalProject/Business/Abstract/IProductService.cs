using System;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface IProductService
{
    List<Product> GetAll();
    List<Product> GetAllByCategoryId(int id);
    List<Product> GetByUnitPrice(decimal min, decimal max);
    List<ProductDetailDto> GetProductDetails();
    Product GetById(int productId);
    IResult Add(Product product);
}
