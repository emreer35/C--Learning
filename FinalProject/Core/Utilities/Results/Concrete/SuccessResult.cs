using System;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete;

public class SuccessResult : Result
{
    // eger kullaniciya mesaj bilgisini verecekse burada mesaj bilgisini veren constructor kullanilacak
    public SuccessResult(string message) : base(true, message)
    {

    }
    // eger kullaniciya sadece true false degerini vereceksek mesaj bilgisi yoksa bunu kullanir
    // yani parametresiz degerde bunu kullanir 
    public SuccessResult() : base(true)
    {

    }
    
}
