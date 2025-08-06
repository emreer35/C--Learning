// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Deger Value Tips

// Bellekte Stack (yığın) bölgesinde tutulur.
// Bir değişkeni başka bir değişkene atadığında kopyası alınır.
// Biri değişirse diğeri değişmez.

int a = 5;
int b = a; // b'ye a'nın değeri kopyalandı (b = 5)

b = 10;

Console.WriteLine(a); // 5
Console.WriteLine(b); // 10

// Value Type Örnekleri:
// int, float, double, decimal
// bool, char
// struct (yapılar)
// enum


// Referance Tips

// Heap (yığın dışında daha büyük bir bellek alanı) içinde tutulur.
// Stack'te sadece o Heap'teki verinin adresi saklanır.
// Bir değişkeni başka bir değişkene atarsan, aynı adresi paylaşırlar.
// Biri değişirse, diğerine de yansır.


int[] dizi1 = new int[] { 1, 2, 3 };
int[] dizi2 = dizi1;

dizi2[0] = 99;

Console.WriteLine(dizi1[0]); // 99
Console.WriteLine(dizi2[0]); // 99

// Reference Type Örnekleri:
// class (sınıflar)
// array (diziler)
// string
// object
// interface
// delegate


// 🗂 Stack	Küçük, hızlı erişimli bellek. Değişkenlerin değerleri veya referans adresleri tutulur.
// 📦 Heap	Büyük, daha yavaş erişimli bellek. Nesnelerin kendisi tutulur (örneğin bir sınıfın örneği, bir dizi vb.).

// stack ve heap nasil anlasilir 

// class Kisi {
//     public string Ad;
// }

// Kisi kisi1 = new Kisi();
// kisi1.Ad = "Ali";
// kisi1 değişkeni Stack üzerindedir → sadece Heap’teki objeyi işaret eder.
// new Kisi() ile oluşturulan nesne Heap’te durur.
// kisi1.Ad = "Ali" dediğimizde, Heap’teki nesnenin içindeki Ad alanına veri yazılır.