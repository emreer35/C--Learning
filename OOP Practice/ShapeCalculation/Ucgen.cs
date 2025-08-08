using System;

namespace ShapeCalculation;

public class Ucgen : ISekil
{
    public int Kenar { get; set; }
    public int Yukseklik { get; set; }

    public Ucgen(int kenar, int yukseklik)
    {
        Kenar = kenar;
        Yukseklik = yukseklik;
    }

    public int CevreHesapla()
    {
        return Kenar * 3;
    }

    public double AlanHesapla()
    {
        return (Kenar * Yukseklik) / 2.0;
    }

    public void Ciz()
    {
        System.Console.WriteLine($"Ucgen Cizildi | Kenar: {Kenar}, Yukseklik: {Yukseklik}");
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} | Kenar: {Kenar} | Yukseklik: {Yukseklik}";
    }
}
