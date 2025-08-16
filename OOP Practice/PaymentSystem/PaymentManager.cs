using System;

namespace PaymentSystem;

public class PaymentManager
{

    public void Payment(IPaymentMethod paymentMethod, int amount)
    {
        paymentMethod.Pay(amount);
        if (paymentMethod is ICardInfo cardInfo)
        {
            System.Console.WriteLine($"Kart Bilgileriniz: Kart Numarasi {cardInfo.CardNumber} | CVV: {cardInfo.Cvv} | Expiration Date: {cardInfo.Expiration}");
        }
    }
}
