

// // // DortIslem dortIslem = new DortIslem(2,3);
// // // System.Console.WriteLine(dortIslem.Toplar(5, 3));

// // using System.Reflection;
// // using System.Runtime.CompilerServices;

// // var type = typeof(DortIslem1);

// // // (cast islemini yapiyoruz)
// // DortIslem1 inst = (DortIslem1) Activator.CreateInstance(type);

// // // System.Console.WriteLine(inst.Toplar(1, 2)); // parametre vermeden yaparsak 
// // // No parameterless constructor defined. inst a paramtere vermemiz lazim 

// // DortIslem1 inst1 = (DortIslem1)Activator.CreateInstance(type, 1, 2);
// // // System.Console.WriteLine(inst1.Toplar(2,4)); // burada sonuc 6 cikacak
// // // System.Console.WriteLine(inst1.Toplar2()); // burada sonuc 3 cikacak

// // // getmethod bir methodinfo doner
// // MethodInfo methodInfo = inst1.GetType().GetMethod("Toplar2");
// // System.Console.WriteLine(methodInfo.Invoke(inst1, null));

// // // metodlarina type dan ulasacagiz

// // foreach (var info in type.GetMethods())
// // {
// //     System.Console.WriteLine("methodlar: {0}", info.Name);
// //     foreach (var param in info.GetParameters())
// //     {
// //         System.Console.WriteLine("------params: {0}", param.Name);
// //     }
// //     foreach (var attr in info.GetCustomAttributes())
// //     {
// //         System.Console.WriteLine("---------attr: {0}", attr.GetType().Name);
// //     }

// // }


// // public class DortIslem1
// // {
// //     int _sayi1;
// //     int _sayi2;

// //     public DortIslem1(int sayi1, int sayi2)
// //     {
// //         _sayi1 = sayi1;
// //         _sayi2 = sayi2;
// //     }
// //     public DortIslem1()
// //     {

// //     }
// //     [Log]
// //     public int Toplar(int sayi1, int sayi2)
// //     {
// //         return sayi1 + sayi2;
// //     }
// //     public int Toplar2()
// //     {
// //         return _sayi1 + _sayi2;
// //     }
// // }
// // [AttributeUsage(AttributeTargets.Method)]
// // public class LogAttribute : Attribute
// // {

// // }

// // using System.Reflection;

// // Assembly assembly = Assembly.GetExecutingAssembly();

// // Type[] types = assembly.GetTypes();

// // foreach (var item in types)
// // {
// //     System.Console.WriteLine(item.FullName);
// //     foreach (var proporty in item.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance ))
// //     {
// //         System.Console.WriteLine(proporty.Name);
// //     }
// // }
// // class Employee
// // {
// //     private int MyProperty { get; set; }
// //     public int MyProperty1 { get; set; }
// //     public int MyProperty2 { get; set; }
// // }

// using System.Reflection;

// Type personDalType = typeof(PersonDal);
// Type personType = typeof(Person);

// Object personDalInst = (PersonDal)Activator.CreateInstance(personDalType);
// Object personInst = (Person)Activator.CreateInstance(personType);

// MethodInfo methodInfo = personDalType.GetMethod("ListPerson");
// PropertyInfo[] propertyInfo = personType.GetProperties();
// Person person1 = new Person { Id = 1, Name = "asdsad", Salary = "123", Surname = "asdads" };
// Object[] obj= new object[]{ person1 };

// // foreach (var item in propertyInfo)
// // {
// //     System.Console.WriteLine(item.Name);
// // }

// PropertyInfo name = personType.GetProperty("Name");
// name.SetValue(personInst, "Emre");
// System.Console.WriteLine(name.GetValue(personInst));

// // System.Console.WriteLine(methodInfo.Invoke(personDalInst,obj));

// // foreach (var item in propertyInfo)
// // {
// //     System.Console.WriteLine(item.Name);
// // }

// PropertyInfo prop = personType.GetProperty("Name");
// prop.SetValue(personInst, "Yunus");
// System.Console.WriteLine(prop.GetValue(personInst));


// // private bir degere encapsulation yaparak deger atariz 



// public class Person
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public string Surname { get; set; }
//     public string Salary { get; set; }
// }

// public class PersonDal {
//     public void Add(Person person)
//     {
//         System.Console.WriteLine($"Personel Eklendi: {person.Name}");
//     }
//     public void ListPerson(Person person)
//     {
//         System.Console.WriteLine($"{person.Name} {person.Surname} {person.Salary}");
//     }
// }


using System.Reflection;

// Type type = typeof(Car);
// Object inst = (Car)Activator.CreateInstance(type);
// MethodInfo methodInfo = type.GetMethod("Start");
// methodInfo.Invoke(inst, null);

// PropertyInfo propertyInfo = type.GetProperty("BrandModel");
// propertyInfo.SetValue(inst, "BMW");
// System.Console.WriteLine(propertyInfo.GetValue(inst));


// FieldInfo fieldInfo = type.GetField("brandModel", BindingFlags.NonPublic | BindingFlags.Instance);
// System.Console.WriteLine(fieldInfo.GetValue(inst));

// public class Car
// {
//     // public int Id { get; set; }
//     private string brandModel  = "Mercedes";
//     public string CarModel { get; set; }
//     public void Start()
//     {
//         System.Console.WriteLine("Araba calisti");
//     }
// }


// Type type = typeof(Student);

// System.Console.WriteLine("Type Bilgileri");
// System.Console.WriteLine($"Ad => {type.Name}");
// System.Console.WriteLine($"NameSpace => {type.Namespace}");
// System.Console.WriteLine($"Full Ad => {type.FullName}");
// System.Console.WriteLine($"BaseType => {type.BaseType}" );
// Console.WriteLine("\nMetodlar:");
// foreach (var method in type.GetMethods())
// {
//     System.Console.WriteLine($" - => {method.Name}");
// }

// Console.WriteLine("\nProportyler:");
// foreach (var prop in type.GetProperties())
// {
//     System.Console.WriteLine($"- => {prop.PropertyType.Name} => {prop.Name}");
// }

// System.Console.WriteLine("Assembly Bilgileri");
// Assembly assembly = Assembly.GetExecutingAssembly();

// System.Console.WriteLine($"Assembly adi => {assembly.GetName().Name}");
// System.Console.WriteLine($"Assemnly versionu => {assembly.GetName().Version}");
// System.Console.WriteLine($"ASsembly Konumu => {assembly.Location}");
// System.Console.WriteLine("==== ASsembly icinde ki typler");
// foreach (var t in assembly.GetTypes())
// {
//     System.Console.WriteLine("fullname");
//     System.Console.WriteLine($"-- => {t.FullName}");
//     System.Console.WriteLine("Name");
//     System.Console.WriteLine($"-- => {t.Name}");
// }

// public class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     public void Study() => System.Console.WriteLine($"{Name} Calisiyor");
// }


// Console.WriteLine("=== Instance constructor'lar ===");
// Type type = typeof(Person);

// ConstructorInfo[] ctors = type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

// foreach (var c in ctors)
// {
//     var access = c.IsPublic ? "public"
//                 : c.IsPrivate ? "private"
//                 : c.IsFamily ? "protected"
//                 : c.IsAssembly ? "internal"
//                 : "??";

//     var signature = string.Join(",", c.GetParameters().Select(p => $"{p.ParameterType.Name} {p.Name}"));
//     System.Console.WriteLine($"{access} {type.Name} {signature}");
// }

// System.Console.WriteLine("\n Static Constrtorcut");
// ConstructorInfo staticCtor = type.TypeInitializer;
// System.Console.WriteLine(staticCtor!= null ? "Cctor var " : "Cctor yok");
// System.Console.WriteLine(staticCtor);


Type type = typeof(Person);
var c0 = type.GetConstructor(Type.EmptyTypes);
var p0 = (Person)c0.Invoke(Array.Empty<object?>());
System.Console.WriteLine("p0 " + p0);

var c1 = type.GetConstructor(new[] { typeof(int) });
var p1 = c1.Invoke(new object[] { 42 });
System.Console.WriteLine("p1 " + p1);

var c2 = type.GetConstructor(new[] { typeof(int), typeof(string) });
var p2 = c2.Invoke(new object[] { 42, "Yunus emre" });
System.Console.WriteLine("p2 " + p2);

var cPriv = type.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance,
                  binder: null,
                  types: new[] { typeof(string) },
                  modifiers: null
);
var pPriv = cPriv.Invoke(new object[] { "Gizli" });
System.Console.WriteLine(pPriv);

System.Console.WriteLine("$$$+====+$$$");
System.Console.WriteLine("En Kalabalik Ctor");

var crowdedCtor = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance)
.OrderByDescending(c => c.GetParameters().Length).First();

System.Console.WriteLine($"En kalabalik ctor => {string.Join(" ", crowdedCtor.GetParameters().Select(p => p.ParameterType.Name))}");

var ctor = type.GetConstructor(Type.EmptyTypes);
var attr = (AuditAttribute)ctor.GetCustomAttributes(typeof(AuditAttribute), false).FirstOrDefault();
System.Console.WriteLine(attr.Message);




MethodInfo method = typeof(Person).GetMethod("Add");
var attrlar = method.GetCustomAttributes<AuditAttribute>();
foreach (var a in attrlar)
{
    System.Console.WriteLine(a.Message);
}

var types1 = Assembly.GetExecutingAssembly().GetTypes();
foreach (var item in types1)
{
    System.Console.WriteLine(item);
}



public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    [Audit("Bu Bir Okuma Islemi")]
    public Person()
    {
    }
    public Person(int id)
    {
        Id = id;
    }
    public Person(int id, string name)
    {
        Name = name;
        Id = id;
    }
    private Person(string name)
    {
        Name = name;
    }
    [Audit("Bu bir toplama methoudur")]
    public void Add()
    {

    }

    public override string ToString()
    {
        return $"Person {Name} {Id}";
    }
}

public class AuditAttribute : Attribute
{
    public string Message { get; }
    public AuditAttribute(string message)
    {
        Message = message;
    }
}



