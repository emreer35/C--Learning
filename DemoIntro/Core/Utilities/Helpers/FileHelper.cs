using System;
using System.Reflection;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers;

public class FileHelper : IFileHelper
{
    string _getCurrentFolder = Path.Combine(Environment.CurrentDirectory, "wwwroot");
    string _uploadFolder = Path.Combine("images", "uploads");
    string[] whiteList = new[] { ".jpg", ".png", ".jpeg" };

    public IResult Upload(IFormFile file)
    {
        var folderAbs = Path.Combine(_getCurrentFolder, _uploadFolder);

        // dosya kontorlu
        CheckFileExists(file);
        // size control 
        CheckFileLength(file);
        // get extension
        var fileExtension = Path.GetExtension(file.FileName);
        var newFileName = Guid.NewGuid().ToString() + fileExtension;

        CheckTypeControl(fileExtension);
        

        // path var mi yok mu 
        CheckDirectoryExists(folderAbs);
        
        var fileAbs = Path.Combine(folderAbs, newFileName);
        CreateFile(file, fileAbs);
        
        var relativeWebPath = Path.Combine(_uploadFolder, newFileName).Replace("\\", "/");
        return new SuccessResult(relativeWebPath);

    }

    public IResult CheckFileExists(IFormFile file)
    {
        if (file == null || file!.Length == 0)
        {
            return new ErrorResult("Dosya bulunamiyor");
        }
        return new SuccessResult();
    }
    public IResult CheckTypeControl(string extension)
    {
        if (!whiteList.Contains(extension))
        {
            return new ErrorResult($"Beklenmeyen dosya tipi: {string.Join(",", whiteList)}");
        }
        return new SuccessResult();
    }
    public void CheckDirectoryExists(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }
    public void CreateFile(IFormFile file, string path)
    {
        using (FileStream fs = File.Create(path))
        {
            file.CopyTo(fs);
            // flush kullanmamiza gerek yok zaten using onu yapiyor
        }
    }
    public IResult CheckFileLength(IFormFile file)
    {
        if (file.Length > 5 * 1024 * 1024)
        {
            return new ErrorResult("Dosya buyuklugunuz maksimum 5mb");
        }
        return new SuccessResult();
    }


}
