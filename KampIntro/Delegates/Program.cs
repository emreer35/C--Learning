internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person();

        MyDelegate myDelegate1 = person.Alert;
        myDelegate1 += person.Show;
        myDelegate1 -= person.Alert;
        myDelegate1();

        // MyDelegate2 myDelegate2 = person.Alert() // hata verir parametresi yok 
        MyDelegate2 myDelegate2 = person.ShowParametersAlert;
        myDelegate2 += person.ShowParametersAlert;

        myDelegate2("Bu bir delegate kullanimidir");

        Maths maths = new Maths();
        MyDelegate3 myDelegate3 = maths.Topla;
        myDelegate3 += maths.Carp;

        // bir int tipinde sonuc dondurugunden doalyi en son olani yazar
        int sonuc = myDelegate3(1, 3);
        System.Console.WriteLine(sonuc);

        Func<int, int, int, int> add = Topla; // ilk 3 u arguman 4. su donus tipi
        System.Console.WriteLine("Func islem sonucu : " + add(1,2,3));


    }
    // Func kullanimi 

    static int Topla(int x, int y, int z)
    {
        return x + y + z;
    }
}

public delegate void MyDelegate(); // parametresiz
public delegate void MyDelegate2(string text);

public delegate int MyDelegate3(int number1, int number2);

public class Person
{
    public void Show()
    {
        System.Console.WriteLine("Goster");
    }
    public void Alert()
    {
        System.Console.WriteLine("Dikkatli ol");
    }
    public void ShowParametersAlert(string text)
    {
        System.Console.WriteLine(text);
    }
}

public class Maths
{
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public int Carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }
}



