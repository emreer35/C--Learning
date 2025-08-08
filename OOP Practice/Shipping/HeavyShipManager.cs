using System;

namespace Shipping;

class HeavyShipManager : Ship
{
    public HeavyShipManager(string a, string g, decimal ag) : base(a,g,ag){}

    public override decimal UcretHesapla()
    {
        decimal temel = 10 + (Agirlik * 2);
        if (Agirlik > 20)
            temel += 50;
        return temel;
    }
}
