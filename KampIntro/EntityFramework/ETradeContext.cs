using System;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework;

public class ETradeContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost,8080;Database=ETrade;User Id=sa;password=123123qwe-*.;TrustServerCertificate=True");
        // @"Server=localhost,8080;Database=Northwind;User Id=sa;Password=123123qwe-*.;Encrypt=True;TrustServerCertificate=True"
    }

    public DbSet<Product> Products { get; set; }
}
