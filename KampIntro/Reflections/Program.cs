// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");


// DortIslem dortIslem = new DortIslem(2, 3);
// dortIslem.Topla(3, 9);


var type = typeof(DortIslem);
// var dortIslem = Activator.CreateInstance(type); // spesifik bir tpye in instanscini uretir ctor u yan 
// dortIslem.

// DortIslem dortIslem = (DortIslem) Activator.CreateInstance(type,1,2);
// System.Console.WriteLine(dortIslem.Carp1());

var instance = Activator.CreateInstance(type, 3, 5);
// var result = instance.GetType().GetMethod("Topla1").Invoke(instance, null);

MethodInfo methodInfo = instance.GetType().GetMethod("Topla1");
var result = methodInfo.Invoke(instance, null);
System.Console.WriteLine(result);


var methods = type.GetMethods();
foreach (var info in methods)
{
    System.Console.WriteLine("mehodlar: {0}", info.Name);
    // Topla
    // Carp
    // Topla1
    // Carp1
    // GetType
    // ToString
    // Equals
    // GetHashCode
    foreach (var parameter in info.GetParameters())
    {
        System.Console.WriteLine("Parametreler: {0}", parameter.Name);
        // Topla
        // a
        // b
        // Carp
        // a
        // b
        // Topla1
        // Carp1
        // GetType
        // ToString
        // Equals
        // obj
        // GetHashCode
    }
    foreach (var attribute in info.GetCustomAttributes())
    {
        System.Console.WriteLine("Attributes: {0}", attribute.GetType().Name);
        // mehodlar: Topla
        // Parametreler: a
        // Parametreler: b
        // mehodlar: Carp
        // Parametreler: a
        // Parametreler: b
        // mehodlar: Topla1
        // mehodlar: Carp1
        // mehodlar: GetType
        // Attributes: NullableContextAttribute
        // Attributes: IntrinsicAttribute
        // mehodlar: ToString
        // mehodlar: Equals
        // Parametreler: obj
        // mehodlar: GetHashCode

        // methodAttribute ile ciktisi
        // mehodlar: Carp1
        // Attributes: MethodAttribute
        // mehodlar: GetType
    }
}

public class DortIslem
{
    int _sayi1;
    int _sayi2;
    public DortIslem(int sayi1, int sayi2)
    {
        _sayi1 = sayi1;
        _sayi2 = sayi2;
    }

    public int Topla(int a, int b)
    {
        return a + b;
    }
    public int Carp(int a, int b)
    {
        return a * b;
    }
    public int Topla1()
    {
        return _sayi1 + _sayi2;
    }
    [Method]
    public int Carp1()
    {
        return _sayi1 * _sayi2;
    }

}
public class MethodAttribute : Attribute
{
    
}