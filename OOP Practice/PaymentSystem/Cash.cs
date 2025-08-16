using System;

namespace PaymentSystem;

public class Cash : IPaymentMethod
{
    public string Name { get; set; }

    public Cash(string name)
    {
        Name = name;
    }
    public void Pay(int amount)
    {
        System.Console.WriteLine($"Nakit ile {amount}$ odeme yapildi");
    }
    public override string ToString()
    {
        return $"Name : {Name}";
    }
}
