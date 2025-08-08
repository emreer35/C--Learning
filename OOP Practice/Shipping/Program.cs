// Ödev 2 – Kargo Takip Sistemi (Inheritance + Polymorphism)
// Senaryo:
// Farklı türde kargolar gönderiliyor:

// NormalKargo
// HassasKargo (ek güvenlik)
// AgirKargo (ek ücret)
// Yap:
// Tüm kargolar için bir Kargo base class oluştur (virtual metotlar dahil).
// Alt sınıflar bu sınıftan türesin ve Hesapla() metodunu override etsin.
// Tüm kargolar için polymorphic olarak çalışan bir List<Kargo> oluştur ve her birini aynı döngüyle çalıştır.


using Shipping;


List<Ship> ships = new List<Ship>
{
    new NormalShip("Yunus Emre", "Sueda", 12),
    new HeavyShipManager("Berk Kenan", "Ibrahim", 23),
    new FragileShipManager("Berkay","Emircan", 8),
    new FragileShipManager("Yunus","Emre",3),
    new NormalShip("sergen","Yalcin",12.75m),
    new HeavyShipManager("ali","Atakan",5.89m)
};

foreach (var ship in ships)
{
    ship.BilgiYazdir();
}