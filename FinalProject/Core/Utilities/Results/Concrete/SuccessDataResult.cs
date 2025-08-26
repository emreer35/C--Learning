using System;

namespace Core.Utilities.Results.Concrete;

public class SuccessDataResult<T> : DataResult<T>
{
    // hem data hem mesaj
    public SuccessDataResult(T data, string message) : base(data, true, message)
    {

    }
    // sadece data
    public SuccessDataResult(T data) : base(data, true)
    {

    }
    // sadece mesaj
    public SuccessDataResult(string message) : base(default, true, message)
    {

    }
    // bos 
    public SuccessDataResult() : base(default, true)
    {

    }
}
