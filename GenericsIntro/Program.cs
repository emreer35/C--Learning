

using GenericsIntro;
// generic tip oldugundan dolayi buraya bir variable vermemiz gerekiyor
// MyList myList = new MyList();

MyList<string> myList = new MyList<string>();
// mylist class inda T tipi olarak verdigim icin fonskiyona burda da cagirirken 
// string olmasinini istedigimden string seklinde veri istiyor
myList.Add("yunus emre");

// burda da int istedigimden dolayi int seklinde veri istiyor
MyList<int> myList1 = new MyList<int>();
myList1.Add(123);


// bu list collection i cagirdigimiz zaman count ile olustrudugumuzda 0 degerini verir bize
List<string> list = new List<string>();
System.Console.WriteLine(list.Count); // ciktisi 0 olarak cikiyor
// simdi biz mylist countunu cagirdigimizda null olarak cikacak cunku bos bir array tutmuyor
// hatta bir array tutmuyor
// myList direkt bizim olsutrudugumuz collection generic tipli bir collection
// bizim olusturdgumuz classta da biz bos bir array olusturarak ilerlemek istiyoruz
// 1-- simdi buranin devami mylist te 

