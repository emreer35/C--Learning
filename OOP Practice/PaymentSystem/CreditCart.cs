using System;

namespace PaymentSystem;

public class CreditCart : IPaymentMethod, ICardInfo
{
    public string CardNumber { get; private set; }
    public string Cvv { get;private set; }
    public string Name { get;private set; }
    public string Expiration { get;private set; }
    public CreditCart(string cardNumber, string cvv, string name, string date)
    {
        CardNumber = cardNumber;
        Cvv = cvv;
        Name = name;
        Expiration = date;
    }
    public void Pay(int amount)
    {
        System.Console.WriteLine($"Kredi Karti Ile {amount}$ Odeme Alindi");
    }

    public override string ToString()
    {
        return $"Kart Numarasi : {CardNumber} | CVV : {Cvv} | Name : {Name} | Son Kullanma Tarihi : {Expiration}";
    }


}
