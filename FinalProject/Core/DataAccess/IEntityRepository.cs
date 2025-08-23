using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess;
// namespace leri degistridik
// artik core katmanimiz bizim diger projelere bagimli degil 
// diger projeler core katmanina bagimli hale geliyor 
// ve arti kbirden fazla projeyi de core katmaninda yapabilirz

// generic constraints generik kisitlamalar 
// class : referance type
// IEntity : ya IEntity yada IEntity implement eden bir nesne olabilir
// new lenebilir olsun yani IEntity vermeyelim oraya sadece implement edilebilenleri verelim 
public interface IEntityRepository<T> where T : class, IEntity, new()
{
    // expression getAll(p => p.categoruId == categoryId) buna expression deniyor
    List<T> GetAll(Expression<Func<T, bool>> filter = null);
    // yukarida filtreyee null verip asagidakine vermeme sebebimiz 
    // yukarida filter vermezsek verinin hespini istiyoruz demektir
    // ama asagida filtre vermek zorunlu en basitinden filter sey olabilir cateogryId gibi 
    T Get(Expression<Func<T, bool>> filter);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    // GetAllByCategoryId bunu artik iptal edebiliriz cunku getall da filtreleme yaptik zaten 
    // List<T> GetAllByCategoryId(int categoryId);
}
