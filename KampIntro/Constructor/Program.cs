
// constructor bir method newlendiginde metodun almasi gereken variabllari belirtir
// 1
CustomerManager customerManager = new CustomerManager();

//2
// ctor vermeden su sekilde doldurabilirsin 
// Product product1 = new Product { Id = 1, Name = "armut" };
// bos bir ctor vermezsen bunun icini doldurmak zorundasin
// Product product = new Product(1,"elma");
// bos ctor verirsen sonradan ad doldurabilrisin 
Product product2 = new Product();

PersonManager personManager = new PersonManager("Elma");

personManager.Added();


Validation.Validate();
User.Register();

//1
class CustomerManager
{
    public CustomerManager()
    {

    }
    public void Add()
    {
        System.Console.WriteLine("Added");
    }
    public void List()
    {
        System.Console.WriteLine("Listed");
    }
}
//2 

class Product
{

    public Product()
    {
        
    }
    int _id;
    string _name;
    public Product(int id, string name)
    {
        _id = id;
        _name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

class BaseClass
{
    string _entity;

    public BaseClass(string entity)
    {
        _entity = entity;
    }

    public void Add()
    {
        System.Console.WriteLine($"Added {_entity}");
    }
}

class PersonManager : BaseClass
{
    public PersonManager(string entity) : base(entity)
    {

    }
    public void Added()
    {
        System.Console.WriteLine("Eklendi");
        Add();
    }
}


static class Validation
{
    public static void Validate()
    {
        System.Console.WriteLine("validated data");
    }
}

class User
{
    public static void Register()
    {
        System.Console.WriteLine("registered");
    }
}


