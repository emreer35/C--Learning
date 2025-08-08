using System;

namespace Shipping;

abstract class Ship
{
    public string Alici { get; set; }
    public string Gonderici { get; set; }
    public decimal Agirlik { get; set; }

    public Ship(string alici, string gonderici, decimal agirlik)
    {
        Alici = alici;
        Gonderici = gonderici;
        Agirlik = agirlik;
    }
    public abstract decimal UcretHesapla();

    public virtual void BilgiYazdir()
    {
        Console.WriteLine($"Gönderen: {Gonderici}, Alıcı: {Alici}, Ağırlık: {Agirlik}kg, Ücret: {UcretHesapla()} TL");
    }
}
