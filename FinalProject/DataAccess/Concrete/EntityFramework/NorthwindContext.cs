using System;
using Core.Entitites.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;
// context : Db tablolari ile proje classlarini baglama
public class NorthwindContext : DbContext
{
    // bu metod senin projen hangi veritabani ile iliskili belirttigin yer 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost,8080;Database=Northwind;User Id=sa;Password=123123qwe-*.;Encrypt=True;TrustServerCertificate=True");
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
}
