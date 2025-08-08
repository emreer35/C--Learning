using System;

namespace Shipping;

class FragileShipManager : Ship
{
    public FragileShipManager(string a, string g, decimal ag) : base(a, g, ag)
    {

    }
    public override decimal UcretHesapla()
    {
        decimal temel = 10 + (Agirlik * 2);
        return temel * 1.10m;
    }
    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        System.Console.WriteLine("Dikkat Bu Hassas Kargodur");
    }
}
