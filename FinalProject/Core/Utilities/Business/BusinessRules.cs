using System;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Business;

public class BusinessRules
{
    // params kullanırsan, metoda sınırsız sayıda argümanı virgülle ayırarak gönderebilirsin.
    public static IResult Run(params IResult[] logics)
    {
        foreach (var result in logics)
        {
            if (!result.Success)
            {
                return result;
            }
        }
        return null;
    }

   
    // listIresult gonderip business tarafinda bunu kontrol edip kullaniciya gosterebiliriz
    // // errorresult bos ise dolu ise diye bir kullanim yapabiliriz
    // public static List<IResult> Run(params IResult[] logics)
    // {
    //     List<IResult> errorResults = new List<IResult>();
    //     foreach (var logic in logics)
    //     {
    //         if (!logic.Success)
    //         {
    //             errorResults.Add(logic);
    //         }
    //     }
    //     return errorResults;
    // }
}
