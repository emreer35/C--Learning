using System;

namespace RentACar;

public class Kamyonet : ICar
{
    public string Marka { get; private set; }

    public string Model { get; private set; }
    public Kamyonet(string marka, string model)
    {
        Marka = marka;
        Model = model;
    }

    public decimal KiralamaUcretiHesapla(int day)
    {
        if (day <= 5)
        {
            decimal price = day * 2300;
            return price;

        }
        else
        {
            decimal price = day * 2599;
            return price;

        }
    }
    public override string ToString()
    {
        return $"Kamyonet | Marka: {Marka} | Model: {Model}";
    }
}
