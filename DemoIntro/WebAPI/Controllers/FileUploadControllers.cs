using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        [HttpPost]
        [Route("add")]
        public IActionResult Upload(IFormFile file)
        {
            IImageService imageService = new ImageManager(new FileHelper());
            var result = imageService.Upload(file);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
