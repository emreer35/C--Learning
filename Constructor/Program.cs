// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Customer customer = new Customer() { Id = 1, Name = "Yunus ", City = "Izmir" };
Customer customer1 = new Customer(1,"Ali","asdad"); 





class Customer
{   
    // iki tane yapici metod yapmamizin sebebi yukarida ki iki turlu de kizamsin diye yapiyor
    public Customer()
    {

    }
    // default constructor 
    // yapici metod new lendigi zaman ilk calisacak metod 
    public Customer(int id, string name, string city)
    {
        Id = id;
        Name = name;
        City = city;
        // bu sekilde vermemiz lazim cunku yukarida customer1 i cw yaparsak 
        // hic bir ismi yazdirmaz yoksa 
    }
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    
}