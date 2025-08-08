
// MusteriAdi
// Bakiye
// HesapNo
// Görevler:

// Tüm field’ları private yap ve getter/setter ile dış dünyaya aç.
// ParaYatir(decimal miktar) ve ParaCek(decimal miktar) metotlarını yaz.
// ParaCek() metodunda eğer bakiyeden fazla para çekilirse hata fırlat.
// ToString() override ederek kullanıcı bilgilerini okunabilir döndür.
// Bir bankada farklı müşterilerin hesapları var. Her hesapta:


BankAccount bankAccount = new BankAccount("Yunus Emre", "Tr50123123123131", 100);

System.Console.WriteLine(bankAccount);
bankAccount.Deposit(1920);
System.Console.WriteLine(bankAccount);
bankAccount.WithDraw(200);
System.Console.WriteLine(bankAccount);
class BankAccount
{
    // private string _customerName;
    private string _accountNumber;
    private decimal _balance;
    private string _customerName;
    public string CustomerName
    {
        get { return _customerName; }
        set { _customerName = value; }
    }
    
    // public string CustomerName { get; set; } = string.Empty;
    public string AccountNumber { get => _accountNumber; }
    public decimal Balance { get => _balance; }

    public BankAccount(string name, string accountNumber, decimal balance)
    {
        _customerName = name;
        _accountNumber = accountNumber;
        _balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            System.Console.WriteLine("Yatirmak istediginiz para - degerde olmaz");
            return;
        }
        _balance += amount;
        System.Console.WriteLine("Yeni Bakiye: " + this._balance);
    }

    public void WithDraw(decimal amount)
    {
        if (_balance < amount)
        {
            System.Console.WriteLine("Lutfen miktardan fazla para eklemeyin. Cekebileceginiz maximum tutar: " + _balance);
            return;
        }
        _balance -= amount;
        System.Console.WriteLine("Para basariyla cekilmistir. Yeni Bakiye: " + _balance);
    }
    public override string ToString()
    {
        return "musteri adi: " + _customerName + " | hesap numarasi: " + _accountNumber + " | Bakiye: " + _balance;
    }
    
    
    
}