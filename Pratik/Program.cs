

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

List<Product> products = new List<Product>
{
    new Product {Name = "Laptop", Category = "Elektronik", Price = 12000, Stock = 5},
    new Product {Name = "Iphone", Category = "Elektronik", Price = 21000, Stock = 13},
    new Product {Name = "Masa", Category = "Ev", Price = 1135, Stock = 21},
    new Product { Name = "Klavye", Category = "Elektronik", Price = 700, Stock = 0 },
    new Product { Name = "Sandalye", Category = "Ev", Price = 900, Stock = 3 },
    new Product { Name = "Telefon", Category = "Elektronik", Price = 10000, Stock = 7 },
    new Product { Name = "Lamba", Category = "Ofis", Price = 300, Stock = 15 }
};

var filter = products.Where(i => i.Stock > 0 && i.Category == "Elektronik").OrderBy(i => i.Name).Select(i => i.Name.ToUpper()).ToList();

foreach (var item in filter)
{
    System.Console.WriteLine(item);
}

var rapor = products.GroupBy(i => i.Category).ToList();
var uptoThousnd = products.Where(i => i.Price > 1000).ToList();
// orderByDescending cok fazla calistiran kod o yzuden kolay yolu hemen altinda
var Expensive = products.OrderByDescending(i => i.Price).First();

var exp = products.Max(i => i.Price);
var expesniveProduct = products.First(i => i.Price == exp);
System.Console.WriteLine(expesniveProduct);


var dict = products.ToDictionary(p => p.Name, p => p.Stock);
var stock = dict.Where(i => i.Value > 5).ToList();
foreach (var item in stock)
{
    System.Console.WriteLine("Item Adi : " + item.Key + "| Item Stogu: " + item.Value);
}
