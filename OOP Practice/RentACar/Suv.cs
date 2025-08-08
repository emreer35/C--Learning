using System;

namespace RentACar;

public class Suv : ICar
{
    public string Marka { get; private set; }
    public string Model { get; private set; }

    public Suv(string marka, string model)
    {
        Marka = marka;
        Model = model;
    }
    public decimal KiralamaUcretiHesapla(int day)
    {

        if (day >= 5)
        {
            decimal price = 1499.99m * day;
            return price;
        }
        else
        {
            decimal price = 1800 * day;
            return price;
        }
    }
    public override string ToString()
    {
        return $"Suv | Marka: {Marka} | Model: {Model}";
    }
}
