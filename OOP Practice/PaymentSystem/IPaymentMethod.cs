using System;

namespace PaymentSystem;

public interface IPaymentMethod
{
    void Pay(int amount);
}
public interface ICardInfo
{
    string CardNumber { get; }
    string Expiration { get; }
    string Cvv { get; }
}
