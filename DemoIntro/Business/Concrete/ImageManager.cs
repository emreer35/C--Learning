using System;
using Business.Abstract;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete;

public class ImageManager : IImageService
{
    IFileHelper _fileHelper;
    public ImageManager(IFileHelper fileHelper)
    {
        _fileHelper = fileHelper;
    }
    public IResult Upload(IFormFile file)
    {
        var result = _fileHelper.Upload(file);
        if (!result.Success)
        {
            return new ErrorResult(result.Message);
        }
        return new SuccessResult(result.Message);
    }
}
