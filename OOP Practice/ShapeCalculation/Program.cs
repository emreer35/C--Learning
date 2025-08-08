// Ödev 4 – Şekil Hesaplama (Advanced Inheritance + Interface + SOLID)
// Senaryo:
// Bir çizim uygulamasında farklı şekiller var:
// Daire
// Kare
// Dikdortgen
// Ucgen
// Hepsi:
// Alan hesaplıyor
// Çevre hesaplıyor
// Çiziliyor
// Görevler:
// Isekil interface tanımla: AlanHesapla(), CevreHesapla(), Ciz()
// Tüm şekiller bu interface'i uygulasın
// List<Isekil> listesiyle tüm şekiller bir foreach içinde ayrı ayrı çizilsin
// OCP prensibine uygun yap: Yeni şekil eklendiğinde eski kod değişmesin


using ShapeCalculation;


List<ISekil> sekils = new List<ISekil>
{
    new Daire(12),
    new Kare(23),
    new Ucgen(6,3),
    new Dikdortgen(8, 15),
};

foreach (var sekil in sekils)
{
    System.Console.WriteLine(sekil);
    sekil.Ciz();
    System.Console.WriteLine($"{sekil.GetType().Name} seklinin alani { sekil.AlanHesapla():F2}");
    System.Console.WriteLine($"{sekil.GetType().Name} seklinin cevresi { sekil.CevreHesapla()} ");
}
