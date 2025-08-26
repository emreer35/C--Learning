using System;

namespace Core.Utilities.Results.Abstract;
// DATA dondereceginden dolayi
// data result T tipinde bir data donderecek
// icerisinde success || error gibi bool donderip
// mesaj ile donderecek 
// ve bunlari IResult tan implemente edecek 
public interface IDataResult<T> : IResult
{
    // veriyi T tipinde donderdigi icin 
    T Data { get; }
}
