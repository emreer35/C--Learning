


PersonelManager personelManager = new PersonelManager();
List<IPersonManager> personManagers = new List<IPersonManager> {
    new CustomerManager(),
    new EmployeeManager()
};


personelManager.Add(personManagers);

interface IPersonManager
{
    void Add();
    void Update();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        System.Console.WriteLine("Musteri Eklendi");
    }

    public void Update()
    {
        System.Console.WriteLine("Musteri Guncellendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        System.Console.WriteLine("Personel Eklendi");
    }

    public void Update()
    {
        System.Console.WriteLine("Personel Guncellendi");
    }
}

class PersonelManager
{
    public void Add(List<IPersonManager> personManagers)
    {
        foreach (var personel in personManagers)
        {
            personel.Add();
        }
    }
}