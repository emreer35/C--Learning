using System;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
namespace DataAccess.Abstract;
// IProductDal 
// Interface Product Data access layer 
public interface IProductDal: IEntityRepository<Product>
{
    List<ProductDetailDto> GetProductDetails();
}
