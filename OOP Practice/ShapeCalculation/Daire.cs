using System;

namespace ShapeCalculation;

public class Daire : ISekil
{
    public int YariCap { get; set; }
    public Daire(int yariCap)
    {
        YariCap = yariCap;
    }
    public double AlanHesapla()
    {
        return Math.PI * YariCap * YariCap;
    }

    public int CevreHesapla()
    {
        return (int)(2 * Math.PI * YariCap);
    }

    public void Ciz()
    {
        System.Console.WriteLine($"Daire Cizildi | YariCap {YariCap}");
    }
    public override string ToString()
    {
        return $"{this.GetType().Name} | yari cap {YariCap}";
    }
}
