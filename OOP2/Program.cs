// See https://aka.ms/new-console-template for more information
using OOP2;

Console.WriteLine("Hello, World!");


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNo = "123456";
customer1.IdentityNumber = "123456789101";
customer1.Name = "Yunus Emre";
customer1.Surname = "Er";


CoorporateCustomer customer2 = new CoorporateCustomer();
customer2.Id = 2;
customer2.CustomerNo = "654321";
customer2.CompanyName = "YEE";
customer2.TaxNumber = "1234567890";

// Solid in L sini kullanmayi ogreniyoruz
// simdi yaptigimiz inheritance sadece ortak alanlari kullanmak degil 
// Base Class olan Customer class inin Individual ve Coorporate classinin referansini tutabilmesi
// yani biz simdi customerManager ksiminda add metoduna Customer customer parametresi verdigimiz icin 
// hem individual hem de coorporate musterisini ekleyebiliyoruz 
// ornek olarak 

Customer customer3 = new IndividualCustomer();
Customer customer4 = new CoorporateCustomer();
// c3 c4 de hata vermememisisn sebebi customerin ikisinin de referansini tutabilmesi 

CustomerManager customerManager = new CustomerManager();

customerManager.Add(customer1); // burasi bir musteri istiyor 
customerManager.Add(customer2); // burada ki butun 
customerManager.Add(customer3); // musterileri parametre olarak
customerManager.Add(customer4); // gonderebiliyoruz

// Eger bir base sinifimiz varsa o base sinifimiz referance tutucudur 