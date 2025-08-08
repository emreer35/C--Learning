using System;

namespace ShapeCalculation;

public class Dikdortgen : ISekil
{
    public int KisaKenar { get; set; }
    public int UzunKenar { get; set; }
    public Dikdortgen(int kisaKenar, int uzunKenar)
    {
        KisaKenar = kisaKenar;
        UzunKenar = uzunKenar;
    }
    public double AlanHesapla()
    {
        return KisaKenar * UzunKenar;
    }

    public int CevreHesapla()
    {
        return (2 * KisaKenar) + (2 * UzunKenar);
    }

    public void Ciz()
    {
        System.Console.WriteLine($"Dikdortgen Cizildi| Kisa Kenar: {KisaKenar} | Uzun Kenar: {UzunKenar}");
    }
    public override string ToString()
    {
        return $"{this.GetType().Name} | Kisa Kenar: {KisaKenar} | Uzun Kenar: {UzunKenar}";
    }
}
