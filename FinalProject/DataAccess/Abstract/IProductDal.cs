using System;
using Entities.Concrete;
namespace DataAccess.Abstract;
// IProductDal 
// Interface Product Data access layer 
public interface IProductDal: IEntityRepository<Product>
{
    
}
