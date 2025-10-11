using System;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers;

public interface IFileHelper
{
    IResult Upload(IFormFile file);
    IResult CheckFileExists(IFormFile file);
    IResult CheckTypeControl(string extension);
    void CheckDirectoryExists(string path);
    IResult CheckFileLength(IFormFile file);
    void CreateFile(IFormFile file, string path);
}
