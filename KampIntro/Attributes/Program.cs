// Customer customer1 = new Customer { Id = 1, LastName = "er", Age = 24 };
// CustomerDal customerDal = new CustomerDal();
// customerDal.Add(customer1);


using System.Reflection.Emit;

CategoryDal categoryDal = new CategoryDal();
categoryDal.Add(new Category { Id = 1, CategoryName = "Urun 1" });

    


[ToTable("customer")]
public class Customer
{
    public int Id { get; set; }
    [RequiredProperty("Isim alani zorunludur")]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}
[AttributeUsage(AttributeTargets.Class)]
internal class ToTableAttribute : Attribute
{
    string _tableName;
    public ToTableAttribute(string tableName)
    {
        _tableName = tableName;
    }
}
// ****************************
// Attribute Usage
// ****************************

// attribute lara da attribute eklenebilir
// [AttributeUsage(AttributeTargets.All)]// herkese eklenebilir
// [AttributeUsage(AttributeTargets.Class)] // sadece classlarin ustune eklenebilir 
// [AttributeUsage(AttributeTargets.Property)] // ozellikler ustune kullanacagimizdan 
// birden fazla yerde kullanabiliyorsak bunu pipe edebiliyourz
// [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum)]

// allow multiple birden fazla uygulamak 
// true ise birden fazla uygulayabilir
// false ise birden fazla uygulayamaz
// [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
// internal class RequiredPropertyAttribute : Attribute
// {

// }
// attribute lari gorebilmek icin Reflections kullanmamiz gerekir 
class CustomerDal
{
    // bu methodu kullanma yerine yenisini yazdim onu kullan 
    // eski method demek 
    [Obsolete("Dont use Add, instead use AddNew Method")]
    public void Add(Customer customer)
    {
        System.Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
    }
    public void AddNew()
    {

    }
}


[AttributeUsage(AttributeTargets.Method)]
public class LogAttribute : Attribute
{
    public string Message { get; }
    public LogAttribute(string message)
    {
        Message = message;
    }
}
[AttributeUsage(AttributeTargets.Property)]
public class RequiredPropertyAttribute : Attribute
{
    public string Message { get; set; }
    public RequiredPropertyAttribute(string message)
    {
        Message = message;
    }
}

 class Category
{
    public int Id { get; set; }
    [RequiredProperty("Ad Alani zorunludur")]
    public string CategoryName { get; set; }
}
class CategoryDal
{
    [Log("Urun eklenmistir Logu")]
    public void Add(Category category)
    {
        System.Console.WriteLine("Urun basariyla eklendi: " + category.CategoryName);
    }
}


// ****************************
// Constructor Named arguments
// ****************************
// once constructor (positional) daha sonrasinda named yani opsiyonel olanlar
// duration hepsinde gerekli fakat key gerekli degil 
public class CacheAttribute : Attribute
{
    public int Duration { get; set; }
    public string Key { get; set; }

    public CacheAttribute(int duration)
    {
        Duration = duration;
    }
}
public class Business
{   
    [Cache(60,Key ="Employee")]
    public void Add()
    {

    }
}