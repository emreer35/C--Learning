using System;

namespace Core.Utilities.Results.Abstract;

public class Result : IResult
{

    public bool Success { get; }
    public string Message { get; } = string.Empty;
    // asagida ki this success i inherit etmemizin sebebi kullaniciya sadece true false 
    // bilgisini vermek istedigimiz zaman kullanacagimiz sistemden kaynakli 
     
    public Result(bool success, string message) : this(success)
    {
        Message = message;
    }
    public Result(bool success)
    {
        Success = success;
    }
    


    
}
