using System;

namespace RentACar;

public class Sedan : ICar
{
    public string Marka { get; private set; }
    public string Model { get; private set; }

    public Sedan(string marka, string model)
    {
        Marka = marka;
        Model = model;
    }


    public decimal KiralamaUcretiHesapla(int day)
    {

        if (day >= 5)
        {
            decimal price = 899.99m * day;
            return price;
        }
        else
        {
            decimal price = 1000 * day;
            return price;
        }
    }
    public override string ToString()
    {
        return $"Sedan | Marka: {Marka} | Model: {Model}";
    }
}
