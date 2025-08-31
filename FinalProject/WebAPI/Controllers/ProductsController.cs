using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] //API olduğunu belirtir
    [ApiController] // bu class bir kontrollerdir /  products gibi URL belirler
    public class ProductsController : ControllerBase
    {
        // loose coupled gevsek bagimlilik
        // naming conversiton _productService
        // bunu api de cagirdigimizda resolve hatasi aliyoruz o yuzden
        // IoC kullaniyoruz -- > Inversion of Control
        // liste icinde bellekte yer tutan nesneler olusturup burada onlari kullaniyoruz
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            // dependency chain var 
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
