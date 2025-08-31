using System;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework;

public class ProductDal
{
    public List<Product> GetAll()
    {
        using (ETradeContext context = new ETradeContext())
        {
            return context.Products.ToList();
        }
    }
    public void Add(Product product)
    {
        using (ETradeContext context = new ETradeContext())
        {
            context.Products.Entry(product).State = EntityState.Added;
            context.SaveChanges();
        }
    }
    public void Update(Product product)
    {
        using (ETradeContext context = new ETradeContext())
        {
            context.Products.Entry(product).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
    public void Delete(Product product)
    {
        using (ETradeContext context = new ETradeContext())
        {
            context.Products.Entry(product).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
