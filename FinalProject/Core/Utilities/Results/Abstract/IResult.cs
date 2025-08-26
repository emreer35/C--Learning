using System;

namespace Core.Utilities.Results.Abstract;
// temel voidler icin baslangic
public interface IResult
{
    bool Success { get; }
    string Message { get; }
}
