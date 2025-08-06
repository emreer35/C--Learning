// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
int number1 = 20;
int number2 = 100;

// var result = Add(number1, number2);
// System.Console.WriteLine(result); // 120
// System.Console.WriteLine(number1); // 20 

// number 1 e 40 yaparsak method un icinde 
// System.Console.WriteLine(result); // 140
// System.Console.WriteLine(number1); // 20

// eger ki ref anahtar keywordunu kullanirsak 
// cunku biz artik referans olarak veridk fakat yukari da number1 degeri olmasi gerekiyor
// disaridan bir veri almasi gerekli

//Değeri metota göndermeden önce başlatılmalı (initialize).
// Metot içinde bu değişken kullanılabilir ve değiştirilebilir.
var result2 = Add(ref number1, number2);
System.Console.WriteLine(result2); // 140
System.Console.WriteLine(number1); // 40

static int Add(ref int number1, int number2)
{
    number1 = 40;
    return number1 + number2;
}
*/

// OUT

// Değeri metoda gönderirken başlatmak gerekmez.
// Metot içinde değer atanması zorunludur.

int number1;
int number2 = 100;
var result3 = Add2(out number1, number2);
System.Console.WriteLine(result3); // 200
System.Console.WriteLine(number1); // 100
// out keywordu ref ile ayni seyi yapar fakat 
// method icinde bir defa tanimlamamiz gerekiyor 
// baslatilirken tanimlamya gerek yok
static int Add2(out int number1, int number2)
{
    number1 = 100;
    return number1 + number2;
}
