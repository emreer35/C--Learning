using System;

namespace OOP3;

public class BasvuruManager
{
    public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
    {
        // basvuru yapacagimiz kredi turunu secme islemini yapacagimizda calisacak fonksiyonu
        // interface ile belirleyecegiz yani Dependency Injection kullaniyoruz
        krediManager.Hesapla();
        loggerService.Log();
    }

    public void KrediHesaplaOnBilgilendirmeYap(List<IKrediManager> krediler)
    {
        // bir liste gonderecek o listeye gore kredi odeme planini hesaplayacak
        foreach (var kredi in krediler)
        {
            kredi.Hesapla();
        }
    }
}
