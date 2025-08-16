// Senaryo:
// Market 3 tür ödeme kabul ediyor:
// Kredi kartı
// Nakit
// Cüzdan (örnek: Papara)
// Yap:
// IOdemeYontemi adında genel bir interface tanımla.
// Her ödeme tipi bu interface’i uygulasın.
// OdemeIsleyici sınıfı constructor'da interface üzerinden ödeme yapsın. (Dependency Injection kullan)
// Yeni bir ödeme tipi eklendiğinde mevcut OdemeIsleyici kodu hiç değişmemeli.


using PaymentSystem;

IPaymentMethod papara = new Papara("Yunus Emre", "1234 1234 1234 1234", "28/06", "333");
IPaymentMethod cash = new Cash("Gorkem");
IPaymentMethod creditCart = new CreditCart("4321 4321 4321 4321", "111", "Sueda", "24/03");

List<IPaymentMethod> methods = new List<IPaymentMethod> { papara, cash, creditCart };

PaymentManager paymentManager = new PaymentManager();

foreach (var method in methods)
{
    paymentManager.Payment(method, 100);

}

