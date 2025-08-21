using System;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfProductDal : IProductDal
{
    public void Add(Product entity)
    {
        // using kullanimi bellekte kullandiktan sonra bellekten disari atar yani performansli bir sey 
        // IDisposable pattern implemantation 
        using (NorthwindContext northwindContext = new NorthwindContext())
        {
            var addedEntity = northwindContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            northwindContext.SaveChanges();
        }
    }

    public void Delete(Product entity)
    {
        using (NorthwindContext northwindContext = new NorthwindContext())
        {
            var deletedEntity = northwindContext.Entry(entity); // bu entity yi bulur
            deletedEntity.State = EntityState.Deleted; // entitity siler
            northwindContext.SaveChanges(); // kayit eder
        }
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        using (NorthwindContext northwindContext = new NorthwindContext())
        {
            // return northwindContext.Set<Product>().Where(filter).First();
            return northwindContext.Set<Product>().SingleOrDefault(filter);
        }
    }

    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        using (NorthwindContext northwindContext = new NorthwindContext())
        {
            return filter == null
            ? northwindContext.Set<Product>().ToList()
            : northwindContext.Set<Product>().Where(filter).ToList();
        }
    }



    public void Update(Product entity)
    {
        using (NorthwindContext northwindContext = new NorthwindContext())
        {
            northwindContext.Entry(entity).State = EntityState.Modified; // bulunan entity i statetiniden gunceller kisaltmasi
            northwindContext.SaveChanges();
        }
    }
}
