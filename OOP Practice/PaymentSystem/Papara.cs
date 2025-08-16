using System;

namespace PaymentSystem;

public class Papara : IPaymentMethod , ICardInfo
{
    public string Name { get; set; }
    public string CardNumber { get; set; }
    public string Expiration { get; set; }
    public string Cvv { get; set; }
    public Papara(string name, string cardNumber, string expiration, string cvv)
    {
        Name = name;
        CardNumber = cardNumber;
        Expiration = expiration;
        Cvv = cvv;
    }
    public void Pay(int amount)
    {
        System.Console.WriteLine($"Papara Ile {amount}$ Odeme Alindi");
    }
    public override string ToString()
    {
        return $"Kart Numarasi : {CardNumber} | CVV : {Cvv} | Name : {Name} | Son Kullanma Tarihi : {Expiration}";
    }
}
