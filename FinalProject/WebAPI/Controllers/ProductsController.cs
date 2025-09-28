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

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            // dependency chain var 
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
            // c# IActionResult return responslarini ogren 
                    // routing arastir
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        // routing arastir
        // alias ver simdilik
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
