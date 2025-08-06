using System;

namespace OOP3;

public class IhtiyacKrediManager : IKrediManager
{
    public void BiseyYap()
    {
        throw new NotImplementedException();
    }

    public void Hesapla()
    {
        System.Console.WriteLine("Ihtiyac Kredisi Odeme plani hesaplandi");
    }
}
