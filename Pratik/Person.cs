using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;


namespace Pratik;

// public class Person
// {
//     public string Name { get; set; } = string.Empty;
//     public int Age { get; set; }

// }

/*
Adres nesnesi oluştur: "İstanbul"
Kisi nesnesi oluştur: "Ayşe" ve bu adresi ata
Yeni bir Kisi oluştur (kopya = orijinal) — adresi de otomatik kopyalanır.
kopya.Adres.Sehir = "Ankara" yap.
Her iki kişinin Ad ve Adres.Sehir bilgisini yazdır.
✅ Hem Kisi hem Adres referans tipi olduğu için ne oluyor?
*/
class Pratik
{
    
        // // kelimeler listesinden tekrar edenleri temizle.
        // // Yeni listede a harfi ile başlayan kelimeleri ayrı bir listeye ata.
        // // Bu listeyi alfabetik sırala ve ekrana yazdır.
        // List<string> words = new List<string>
        // {
        //     "elma", "armut", "üzüm", "muz", "karpuz", "çilek", "erik", "elma", "üzüm", "elma"
        // };
        // List<string> newList = new List<string>();
        // foreach (var word in words)
        // {
        //     if (!newList.Contains(word))
        //     {
        //         newList.Add(word);
        //     }
        // }


        // List<string> firstLetterA = new List<string>();
        // foreach (var word in words)
        // {
        //     if (word.StartsWith('a'))
        //     {
        //         firstLetterA.Add(word);
        //     }
        // }

        // words.Sort();
        // for (int i = 0; i < words.Count; i++)
        // {
        //     System.Console.WriteLine("key: " + i);
        //     System.Console.WriteLine(words[i]);
        // }
        // foreach (var item in firstLetterA)
        // {
        //     System.Console.WriteLine(item);
        // }




        /*
            Görev:
Notu 70’in üstünde olanları başka bir sözlüğe aktar.
Bu yeni sözlükteki öğrencileri notlarına göre büyükten küçüğe sırala.
En yüksek notu alan öğrenciyi ve notunu yazdır.
        


        Dictionary<string, int> notes = new Dictionary<string, int>
        {
            {"Ali", 85},
            {"Ayse",92},
            { "Veli", 45 },
            { "Zeynep", 75 },
            { "Kemal", 60 },
            { "Ayşe", 70 }
        };

        Dictionary<string, int> plus70 = new Dictionary<string, int>();
        foreach (var item in notes)
        {
            if (item.Value > 70)
            {
                plus70.Add(item.Key, item.Value);
            }
        }

        List<KeyValuePair<string, int>> sirala = new List<KeyValuePair<string, int>>(plus70);
        // kiyaslama yap COMPARE
        sirala.Sort((x, y) => y.Value.CompareTo(x.Value));

        foreach (var item in sirala)
        {
            System.Console.WriteLine(item.Key + " : " + item.Value);
        }

        if (sirala.Count() > 0)
        {
            var basarili = sirala[0];
            System.Console.WriteLine(basarili.Key + " : " + basarili.Value);
        }
        */

        /*

        Görev:
Stack’in en tepesindeki (son yapılan) adımı geri al ve ekrana yazdır.
Geriye kalan tüm adımları ilk adımdan son adıma doğru ekrana yazdır.
        

        Stack<string> adimlar = new Stack<string>();
        adimlar.Push("Ac");
        adimlar.Push("Duzenle");
        adimlar.Push("Kaydet");
        adimlar.Push("Kapat");

        System.Console.WriteLine(adimlar.Pop());

        List<string> siralaAdimlar = new List<string>(adimlar);

        siralaAdimlar.Reverse();
        foreach (var item in siralaAdimlar)
        {
            System.Console.WriteLine(item);
        }
        */

        /*
            En az 5 belge ekle.
Kuyruktan sırayla belge çıkarıp “Yazdırılıyor: [belgeAdı]” diye ekrana yazdır.
Kuyruk tamamen boşaldığında “Tüm belgeler yazdırıldı.” mesajını göster.
        
        Queue<string> yaziciKuyrugu = new Queue<string>();
        yaziciKuyrugu.Enqueue("yazici nedir");
        yaziciKuyrugu.Enqueue("yazicilarin amaci nedir");
        yaziciKuyrugu.Enqueue("yazicilarin kullandigi yer");
        yaziciKuyrugu.Enqueue("yazici ilk neyi yazdi");
        yaziciKuyrugu.Enqueue("yazici icin gerekli olan seyler nelerdir");

        while (yaziciKuyrugu.Count() > 0)
        {
            System.Console.WriteLine(yaziciKuyrugu.Dequeue());
            if (yaziciKuyrugu.Count() == 0)
            {
                System.Console.WriteLine("Tum belgeler yazdirildi");
            }
        }
        */
        /*
        Tüm şehirleri HashSet<string> içine aktararak tekrar edenleri sil.
Bu set’i alfabetik sıraya göre liste haline çevir.
Sırayla ekrana yazdır.

        string[] sehirler = new string[] { "Ankara", "İstanbul", "İzmir", "Ankara", "Bursa", "İzmir", "Adana" };

        HashSet<string> cities = new HashSet<string>(sehirler);

        List<string> sortCities = new List<string>(cities);

        sortCities.Sort();

        foreach (var item in sortCities)
        {
            System.Console.WriteLine("Sehir: " + item);
        }
*/

        //Collection pratik

        /*
            Görevler:
            Harf sayısı 5’ten büyük olan meyveleri al.
            Bu meyveleri alfabetik olarak sırala.
            Her meyveyi büyük harfe çevir.
            Sonuçları ekrana yazdır.
        

        List<string> kelimeler = new List<string>
        {
            "elma", "armut", "üzüm", "karpuz", "muz", "kavun", "erik", "çilek", "mandalina", "kayısı"
        };

        var result = kelimeler.Where(i => i.Length > 5).OrderByDescending(i => i).Select(i => i.ToUpper()).ToList();

        foreach (var item in result)
        {
            System.Console.WriteLine(item);
        }

        */

        /*
        Notu 70 ve üzeri olan öğrencileri bul.
        Öğrencilerin adlarını büyük harfle yazdır.
        En yüksek notu alan öğrencinin adını ve notunu göster.
        Sadece adları “A” harfi ile başlayan öğrenciler için ortalama notu hesapla.
        
        List<string> ogrenciler = new List<string> { "Ali", "Ayşe", "Mehmet", "Zeynep" };
        List<int> notlar = new List<int> { 80, 45, 92, 67 };

        var studentNotes = ogrenciler.Zip(notlar, (ad, not) => new { ogrenci = ad, not = not }).ToList();

        var basariliOgrenci = studentNotes.Where(i => i.not > 70).Select(i => i.ogrenci);
        foreach (var ogrenci in basariliOgrenci)
        {
            System.Console.WriteLine(ogrenci);
        }

        var upperCase = ogrenciler.Select(i => i.ToUpper());
        foreach (var upper in upperCase)
        {
            System.Console.WriteLine(upper);
        }

        var HighStudent = studentNotes.OrderByDescending(i => i.not).First();
        System.Console.WriteLine(HighStudent);


        var firstLetterA = studentNotes.Where(i => i.ogrenci.StartsWith("A")).Select(i => i.not).ToList();
        foreach (var item in firstLetterA)
        {
            System.Console.WriteLine(item);
        }
        if (firstLetterA.Any())
        {
            double avg = firstLetterA.Average();
            System.Console.WriteLine(avg);
        }  
*/

        /*

        T harfiyle başlayan ürünleri gruplara ayır (uzunluklarına göre).
Her grubun:
Kaç elemanı olduğunu yazdır
En uzun ismini yazdır
Toplamda kaç harf içerdiğini hesapla (tüm listedeki string’lerin toplam karakter sayısı)

        List<string> urunler = new List<string>
            {
                "Telefon", "Televizyon", "Tablet", "Tost Makinesi", "Termos", "Tıraş Makinesi", "Tavla", "Tüp"
            };

        var firstLetterT = urunler.Where(i => i.StartsWith('T')).GroupBy(i => i.Length).ToList();
        foreach (var item in firstLetterT)
        {
            System.Console.WriteLine("Kac Eleman Oldugu: " + item.Key);
            System.Console.WriteLine("Count : " + item.Count());

            string enuzun = item.OrderByDescending(i => i.Length).First();
            System.Console.WriteLine(enuzun);

            int howManyCharacter = item.Sum(i => i.Length);
            System.Console.WriteLine(howManyCharacter);
        }

        int charachter = urunler.Where(i => i.StartsWith('T')).Sum(i => i.Length);
        System.Console.WriteLine(charachter);
        
*/

    }


