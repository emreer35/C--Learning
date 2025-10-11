using System;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract;

public interface IImageService
{
    IResult Upload(IFormFile formFile);
}
