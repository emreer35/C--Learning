// See https://aka.ms/new-console-template for more information
using OOP3;

Console.WriteLine("Hello, World!");


// interfaceler de o interface i implement eden classlarin referans numarasini tutabiliyorlar
// yani sununla da calisir
// TasitKrediManager tasitKrediManager = new TasitKrediManager();
// bununla da calisir
IKrediManager tasitKrediManager = new TasitKrediManager();
// tasitKrediManager.Hesapla();
IKrediManager konutKrediManager = new KonutKrediManager();
// konutKrediManager.Hesapla();
IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
// ihtiyacKrediManager.Hesapla();

// simdi artik bir banka calisani hangi krediyi secerse basvuruyu o kredi turune gore
// hesaplatacak bir Basvuru manager yaptik 

BasvuruManager basvuruManager = new BasvuruManager();
// burda bizim yaptigimiz interface uzerinden referans alabildgimiz kredi turlerini
// gonderecegimiz parametre 
// basvuruManager.BasvuruYap(tasitKrediManager);

// simdi ise bir kredi hesaplama simulasyonu yapalim 
// kredi isteyenin hangi kredileri secip odeme planlarini listelemesini yapalim
// list yapalim 

List<IKrediManager> kredis = new List<IKrediManager>()
{
    tasitKrediManager, konutKrediManager
};

basvuruManager.KrediHesaplaOnBilgilendirmeYap(kredis);
ILoggerService databaseLogService = new DatabaseLogService();
basvuruManager.BasvuruYap(tasitKrediManager, databaseLogService);

