// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

/*
string[] names = new string[] { "yunus", "emre", "ibo", "kenan" };
System.Console.WriteLine(names[0]);
System.Console.WriteLine(names[1]);
System.Console.WriteLine(names[2]);
System.Console.WriteLine(names[3]);

// burada index in disindasin hatasi veriyor 
// names[4] = "suedam";
// System.Console.WriteLine(names[4]);

// bu sekilde yapsak burada yeni bir refercance kismi 
// bellekte yeni bir isimle tutmus oluyoruz ve artik names[4] farkli bir bellekte oluyor 
// diger elemanlari goremiyoruzz
names = new string[5];
names[4] = "suedam";
System.Console.WriteLine(names[4]);
// diger elemanlari goremiyoruzz
// cli da yazmiyor bu 
System.Console.WriteLine(names[0]);
*/


//Collectionlarda List adi altinda kullaniriz ve bir string lite kolayca ekleme yapabiliriz
List<string> products = new List<string> { "yunus", "emre", "ibo", "kenan" };
// System.Console.WriteLine(products[0]);
// System.Console.WriteLine(products[1]);
// System.Console.WriteLine(products[2]);
// System.Console.WriteLine(products[3]);
// sonradan ekleme yaptik ve bellek numarasi degismedi
// ayni bellek uzerinden calisma yaptik 
products.Add("susumm");
// System.Console.WriteLine(products[4]);
// System.Console.WriteLine(products[1]);


// Collections 
/*
 * array
 * List<T>
 * Dictionary<Tkey, TValue>
 * HashSet<T>
 * Queue<T>
 * Stack<T>
*/

int[] sayilar = new int[3];
sayilar[0] = 10;
sayilar[1] = 20;
sayilar[2] = 30;
// array 3 elemanli eklenilmez cikarilmaz 

List<string> isimler = new List<string>();
isimler.Add("yunus");
isimler.Add("emre");
// listeye istedigimiz kadar eleman ekleyip cikarabilirz 

Dictionary<string, int> yaslar = new Dictionary<string, int>();
yaslar.Add("Yunus Emre", 20);
yaslar["ahmet"] = 20;
// key value mantigiyla calisir

HashSet<string> sehirler = new HashSet<string>();
sehirler.Add("Ankara");
sehirler.Add("Ankara"); // bu tekrardan eklenmeyecek
// hashset tekrar eden elemanlari gormezden gelir engeller

Queue<string> harfler = new Queue<string>();
harfler.Enqueue("A"); // ilk giren oldugundan ilk basta bu cikar
harfler.Enqueue("B");
harfler.Dequeue();
// FIFO mantigini kullanir ilk giren ilk cikar

Stack<string> books = new Stack<string>();
books.Push("Kitap 1");
books.Push("kitap 2"); // son giren ilk cikar mantigiyla kullanilir
books.Pop();
// pop ile son giren ilk cikar


// Collection Fonksiyonlari
List<string> words = new List<string>();

// Add 
words.Add("Yunus");
words.Add("Emre");
words.Add("Sueda");


// Remove bir collection dan silme 

words.Remove("Yunus");

// Contains urun var mi yok mu 
System.Console.WriteLine(words.Contains("Sueda")); // true - false

// Count kac adet item var onu gosterir
words.Count();

// clear metodu tum itemlari siler
words.Clear();

foreach (var item in words)
{
    System.Console.WriteLine(item);
}

List<int> numbers1 = new List<int>
{
    1,2,3,4
};

//Sort kucukten buyuge siralar
numbers1.Sort();
//Reverse tersine cevirir
numbers1.Reverse();


// IndefOf() metodu 5 hangi indexte 
// eger yoksa -1 olarak verir
var kacinci = numbers1.IndexOf(6); // ilk buldugu indexi seyi verir
System.Console.WriteLine(kacinci);

// insert(key,value) key inci index e value degerini ekler ekliyor
// 0.indexte eklersek diger indexler bir sonraki indexe geciyor
System.Console.WriteLine("------ 0. index");
System.Console.WriteLine(numbers1[0]);
numbers1.Insert(0, 999);
System.Console.WriteLine(numbers1[0]);


// ToArray() listeyi diziye cevriri

numbers1.ToArray();
foreach (var item in numbers1)
{
    System.Console.WriteLine("============");
    System.Console.WriteLine(item);
}

Dictionary<string, int> keyvalues = new Dictionary<string, int>();
keyvalues["ali"] = 1;
keyvalues["veli"] = 2;
keyvalues["hakan"] = 3;
foreach (var item in keyvalues.Keys)
{
    System.Console.WriteLine("keyler: " + item);
}
foreach (var item in keyvalues.Values)
{
    System.Console.WriteLine("values: " + item);
}


// LINQ fonksiyonlari 

List<string> names = new List<string>()
{
    "Ali",
    "Ayse",
    "Ibrahim",
    "mehmet"
};
/*
// Where
var longName = names.Where(i => i.Length > 3).ToList();

foreach (var name in longName)
{
    System.Console.WriteLine("---------------");
    System.Console.WriteLine(name);
}
// Selecet
var uzunluklar = names.Select(i => i.Length).ToList();
var firstUpper = names.Select(i => i.ToUpper()).ToList();
foreach (var uzunluk in uzunluklar)
{
    System.Console.WriteLine("uzun olanlar");
    System.Console.WriteLine(uzunluk);
}

foreach (var up in firstUpper)
{
    System.Console.WriteLine("ilk harf Buyuk");
    System.Console.WriteLine(up);
}
*/


// OrderBy
List<int> numbers = new List<int>
{
    5,8,5,2,1,3,888,654,55,677,455,326,1,1,1,1,1,1
};
/*
var order = numbers.OrderBy(i => i).ToList();
foreach (var or in order)
{
    System.Console.WriteLine("----------");
    System.Console.WriteLine(or);
}

var tersten = numbers.OrderByDescending(i => i).ToList();
foreach (var item in tersten)
{
    System.Console.WriteLine("-------------");
    System.Console.WriteLine(item);
}

// First FirstOrDefault();
// var ilkUzun = names.First(i => i.Length > 3).ToList();
var ilkUzun = names.FirstOrDefault(i => i.Length > 3);
System.Console.WriteLine(ilkUzun);

// Any() – En az bir tane var mı?

var isThere = names.Any(i => i.Length > 6);
System.Console.WriteLine(isThere); // true false

// All() – Hepsi şu koşulu sağlıyor mu?

var isAll = names.All(i => i.Length > 2);
System.Console.WriteLine(isAll); // true false
var pozitive = numbers.All(i => i > 0);
System.Console.WriteLine(pozitive); // true false

// Any() – En az bir tane var mı?

System.Console.WriteLine(names.Count); // 4
var howMany = names.Count(i => i.Length > 4);
System.Console.WriteLine(howMany); // 2

// Distinct() – Tekrar edenleri çıkar

var diff = numbers.Distinct().ToList();
foreach (var item in diff)
{
    System.Console.WriteLine(item);
}
*/
// Take(n) / Skip(n) – İlk n’yi al / geç
// ilk 2 yi al 
// ilk 2 yi gec

/*
var ilk2 = numbers.Take(2).ToList();
foreach (var item in ilk2)
{
    System.Console.WriteLine("==== ilk 2 ====");
    System.Console.WriteLine(item);
}
var sons = numbers.Skip(numbers.Count - 2).ToList();

foreach (var item in sons)
{
    System.Console.WriteLine("====Son2====");
    System.Console.WriteLine(item);
}


var group = names.GroupBy(i => i.Length);

foreach (var grup in group)
{
    System.Console.WriteLine("Uzunluk: " + grup.Key);
    foreach (var key in grup)
    {
        System.Console.WriteLine(key);
    }
}


var toplu = names.Where(i => i.Length > 3).OrderBy(i => i).Select(i => i.ToUpper()).ToList();

foreach (var iaa in toplu)
{
    System.Console.WriteLine("=------=-=-");
    System.Console.WriteLine(iaa);
}
*/