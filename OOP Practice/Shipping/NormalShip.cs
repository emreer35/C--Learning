using System;

namespace Shipping;

class NormalShip : Ship
{
    // base mantigi base classi n ctorunu kullanmak
    public NormalShip(string alici, string gonderici, decimal agirlik) : base(alici, gonderici, agirlik)
    {
    }
    public override decimal UcretHesapla()
    {
        return 10 + (Agirlik * 2);
    }
}
