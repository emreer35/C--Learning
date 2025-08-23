using System;
using Core.Entities;
using Core.Entitites;

namespace Entities.DTOs;

public class ProductDetailDto : IDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public short UnitsInStock { get; set; }
}
