using System;

namespace RentACar;

public class Electric : ICar
{
    public string Marka { get; private set; }

    public string Model { get; private set; }

    public Electric(string marka, string model)
    {
        Marka = marka;
        Model = model;
    }
    public decimal KiralamaUcretiHesapla(int day)
    {

        if (day >= 5)
        {
            decimal price = 1100 * day;
            return price;
        }
        else
        {
            decimal price = 1250 * day;
            return price;
        }
        
    }
    public override string ToString()
    {
        return $"Electric | Marka: {Marka} | Model: {Model}";
    }
}
