

using Pratik;

// k2 nesnesine k1’i ata (Kisi k2 = k1;).
// k2.Ad değerini "Veli" olarak değiştir.
// Hem k1 hem k2'nin Ad ve Yas değerlerini ekrana yazdır.

// Person k1 = new Person();
// k1.Name = "Ali";
// k1.Age = 30;

// Person k2 = k1;
// k2.Name = "Veli";

// System.Console.WriteLine(k1.Name);
// System.Console.WriteLine(k1.Age);
// System.Console.WriteLine("---");
// System.Console.WriteLine(k2.Name);
// System.Console.WriteLine(k2.Age);

// k1 yeni bir adres olsuturdu
// k2 nesnesi k1 nesnesinin adresini aldi 


/*
2. Görev:

Adres nesnesi oluştur: "İstanbul"
Kisi nesnesi oluştur: "Ayşe" ve bu adresi ata
Yeni bir Kisi oluştur (kopya = orijinal) — adresi de otomatik kopyalanır.
kopya.Adres.Sehir = "Ankara" yap.
Her iki kişinin Ad ve Adres.Sehir bilgisini yazdır.
✅ Hem Kisi hem Adres referans tipi olduğu için ne oluyor?
*/


/*
Görev 1 – Filtreleme

Stokta olan (Stock > 0) ürünleri listele.
Sadece Elektronik kategorisindeki ürünleri al.
Ürün adlarını büyük harfe çevir, alfabetik sırala.
🔸 Görev 2 – Raporlama

Her kategori için kaç ürün var? (GroupBy)
Ortalama fiyatı 1000 TL'nin üstünde olan ürünleri listele.
En pahalı ürünün adını ve fiyatını ekrana yazdır.
🔸 Görev 3 – Dictionary ile Eşleme

Yeni bir Dictionary<string, int> oluştur.
Bu sözlük: ürün adı → stok miktarı şeklinde olacak.
LINQ kullanarak, stok miktarı 5'ten fazla olan ürünleri bu sözlükten çek ve yazdır.
*/

// List<Product> products = new List<Product>
// {
//     new Product {Name = "Laptop", Category = "Elektronik", Price = 12000, Stock = 5},
//     new Product {Name = "Iphone", Category = "Elektronik", Price = 21000, Stock = 13},
//     new Product {Name = "Masa", Category = "Ev", Price = 1135, Stock = 21},
//     new Product { Name = "Klavye", Category = "Elektronik", Price = 700, Stock = 0 },
//     new Product { Name = "Sandalye", Category = "Ev", Price = 900, Stock = 3 },
//     new Product { Name = "Telefon", Category = "Elektronik", Price = 10000, Stock = 7 },
//     new Product { Name = "Lamba", Category = "Ofis", Price = 300, Stock = 15 }
// };

// var filter = products.Where(i => i.Stock > 0 && i.Category == "Elektronik").OrderBy(i => i.Name).Select(i => i.Name.ToUpper()).ToList();

// foreach (var item in filter)
// {
//     System.Console.WriteLine(item);
// }

// var rapor = products.GroupBy(i => i.Category).ToList();
// var uptoThousnd = products.Where(i => i.Price > 1000).ToList();
// // orderByDescending cok fazla calistiran kod o yzuden kolay yolu hemen altinda
// var Expensive = products.OrderByDescending(i => i.Price).First();

// var exp = products.Max(i => i.Price);
// var expesniveProduct = products.First(i => i.Price == exp);
// System.Console.WriteLine(expesniveProduct);


// var dict = products.ToDictionary(p => p.Name, p => p.Stock);
// var stock = dict.Where(i => i.Value > 5).ToList();
// foreach (var item in stock)
// {
//     System.Console.WriteLine("Item Adi : " + item.Key + "| Item Stogu: " + item.Value);
// }



// int toplam = 0;
// for (int i = 0; i < 10; i++)
// {

//     toplam = +i;

// }
// System.Console.WriteLine(toplam);

// int toplam1 = 0;
// for (int i = 1; i < 100; i++)
// {
//     if (i % 2 == 0)
//     {
//         toplam1 = +i;
//     }
// }


// int sayi1 = 10;
// int sayi2 = 50;
// int tekToplam = 0;
// int ciftToplam = 0;
// for (int i = sayi1; i < sayi2; i++)
// {
//     if (i % 2 != 0)
//     {
//         tekToplam = +i;
//     }
//     else
//     {
//         ciftToplam = +i;
//     }
// }

// System.Console.WriteLine("1-12 arasinda bir sayi secin");
// var s1 = Convert.ToInt32(Console.ReadLine());

// switch (s1)
// {
//     case 1:
//         System.Console.WriteLine(31);
//         break;
//     case 2:
//         System.Console.WriteLine(28);
//         break;
//     case 3:
//         System.Console.WriteLine(31);
//         break;
//     case 4:
//         System.Console.WriteLine(30);
//         break;
//     case 5:
//         System.Console.WriteLine(31);
//         break;
//     case 6:
//         System.Console.WriteLine(30);
//         break;
//     case 7:
//         System.Console.WriteLine(31);
//         break;
//     case 8:
//         System.Console.WriteLine(31);
//         break;
//     case 9:
//         System.Console.WriteLine(30);
//         break;

//     case 10:
//         System.Console.WriteLine(31);
//         break;
//     case 11:
//         System.Console.WriteLine(30);
//         break;
//     case 12:
//         System.Console.WriteLine(31);
//         break;
//     default:
//         System.Console.WriteLine("Gecerli sayi girin");
//         break;
// }

// switch (s1)
// {
//     case 1:
//     case 3:
//     case 5:
//     case 7:
//     case 8:
//     case 10:
//     case 12:
//         Console.WriteLine("31 gün");
//         break;

//     case 4:
//     case 6:
//     case 9:
//     case 11:
//         Console.WriteLine("30 gün");
//         break;

//     case 2:
//         Console.WriteLine("28 gün");
//         break;

//     default:
//         Console.WriteLine("Geçerli bir sayı girin (1-12).");
//         break;
// }

// 🧭 1. Algoritmik Düşünce
// Kullanıcıya bir menü göster:
// 1 → Toplama
// 2 → Çıkarma
// 3 → Çarpma
// 4 → Bölme
// 5 → Çıkış
// Kullanıcının seçimini al.
// Seçime göre uygun işlemi yap (switch-case ile).
// 5 seçilmedikçe menüyü tekrar göster (while döngüsüyle).



int secim = 0;

while (secim != 5)
{
    MenuGoster();
    secim = Convert.ToInt32(Console.ReadLine());
    if (secim == 5)
    {
        break;
    }

    try
    {
        switch (secim)
        {
            case 1:
                Topla();
                break;
            case 2:
                Cikar();
                break;
            case 3:
                Carp();
                break;
            case 4:
                Bol();
                break;
            default:
                Console.WriteLine("Geçersiz seçim yaptınız!");
                break;
        }
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Sadece Sayi giriniz");

    }
    catch (Exception e)
    {
        System.Console.WriteLine("Bir hata olustu: " + e.Message);
    }
    finally
    {
        System.Console.WriteLine("Islemniz tamamlanmistir");
    }
}
// refactoring

static void MenuGoster()
{
    System.Console.WriteLine("Bu Bir Hesap makinesidir");
    System.Console.WriteLine("1- Toplama");
    System.Console.WriteLine("2- Cikarma");
    System.Console.WriteLine("3- Carpma");
    System.Console.WriteLine("4- Bolme");
    System.Console.WriteLine("5- Cikis");
    Console.Write("Bir seçim yapınız: ");
}

static double GirdiAl(string mesaj)
{
    System.Console.WriteLine(mesaj);
    return Convert.ToDouble(Console.ReadLine());
}

static void Topla()
{
    try
    {
        double s1 = GirdiAl("Ilk sayiyi giriniz: ");
        double s2 = GirdiAl("Ikinci Sayiyi giriniz: ");
        System.Console.WriteLine($"Sonuc : {s1 + s2}");
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Sadece Sayi giriniz");
        
    }
}
static void Cikar()
{
    try
    {
        double s1 = GirdiAl("Ilk sayiyi giriniz: ");
        double s2 = GirdiAl("Ikinci Sayiyi giriniz: ");
        System.Console.WriteLine($"Sonuc : {s1 - s2}");
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Sadece Sayi giriniz");
        
    }
}
static void Carp()
{
    try
    {
        double s1 = GirdiAl("Ilk sayiyi giriniz: ");
        double s2 = GirdiAl("Ikinci Sayiyi giriniz: ");
        System.Console.WriteLine($"Sonuc : {s1 * s2}");
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Sadece Sayi giriniz");
        
    }
}
static void Bol()
{
    try
    {
        double s1 = GirdiAl("Ilk sayiyi giriniz: ");
        double s2 = GirdiAl("Ikinci Sayiyi giriniz: ");
        if (s2 != 0)
        {
            System.Console.WriteLine($"Sonuc : {s1 / s2}");
        }
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Sadece Sayi giriniz");

    }
    catch (DivideByZeroException)
    {
        System.Console.WriteLine("Bir sayi sifira bolunemez");
    }
}
    


