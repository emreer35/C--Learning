using System;

namespace ShapeCalculation;

public class Kare : ISekil
{
    public int Kenar { get; set; }
    public Kare(int kenar)
    {
        Kenar = kenar;
    }

    public int CevreHesapla()
    {
        return 4 * Kenar;
    }

    public double AlanHesapla()
    {
        return Kenar * Kenar;
    }

    public void Ciz()
    {
        System.Console.WriteLine($"Kare Cizildi | Kenar: {Kenar}");
    }
    public override string ToString()
    {
        return $"{this.GetType().Name} | Kenar: {Kenar}";
    }
}
