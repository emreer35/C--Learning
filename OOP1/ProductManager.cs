using System;

namespace OOP1;

public class ProductManager
{


    // public void AnotherWay(int sayi)
    // {
    //     sayi = 99;
    // }
    // 
    public void Add(Product product)
    {
        product.ProductName = "Kavun";
        // System.Console.WriteLine(" Urun Adi: " + product.ProductName);
    }
    public void update(Product product)
    {
        System.Console.WriteLine(product.ProductName + " guncellendi");
    }

    public void topla(int sayi1, int sayi2)
    {
        System.Console.WriteLine(sayi1 + sayi2);
    }

    public int topla2(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
}
