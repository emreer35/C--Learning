using System;

namespace RentACar;

public interface ICar
{
    string Marka { get; }
    string Model { get; }
    decimal KiralamaUcretiHesapla(int day);

    
}
