// Ödev 3 – Araba Kiralama Sistemi (Interface + Polymorphism + Open/Closed)
// Senaryo:
// Farklı tipte arabalar kiralanabiliyor:

// Sedan
// SUV
// Elektrikli
// Her birinin:

// KiralamaUcretiHesapla(int gun)
// Marka
// Model
// Yap:
// Tüm araba türleri IAraba interface’ini uygulasın.
// List<IAraba> listesi oluştur.
// 5 gün kiralanan tüm araçların toplam kirasını yazdır.
// Kodun bir yerinde if(arac is Sedan) gibi kontroller kullanma ❌ → polimorfizmle çöz.


using RentACar;

List<ICar> cars = new List<ICar>
{
    new Sedan("BMW","X5"),
    new Sedan("Mercedes", "CLA180"),
    new Suv("KIA", "Sportage"),
    new Electric("Tesla","Tesla"),
    new Kamyonet("Mercedes", "A12341")
};
decimal totalPrice = 0;
foreach (var car in cars)
{
    decimal price = car.KiralamaUcretiHesapla(5);
    System.Console.WriteLine(car.ToString());
    System.Console.WriteLine($"5 Gunluk {car.Marka} marka {car.Model} modelinin ucreti {price}");
    totalPrice += price;
}

System.Console.WriteLine("TOTAL PRICE: " + totalPrice);
