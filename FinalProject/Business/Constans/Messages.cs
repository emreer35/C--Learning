using System;

namespace Business.Constans;
// constanst ortak sabit alanlardir 
public static class Messages
{
    // statik vermemizin nedeni surekli new gerektirmesin diye
    // neden bolye yapiyoruz cunku bircok yerde kullanabilecegimiz fieldlari 
    // tek tek degistirmeyelim tek bir yerden degistirelim diye yaptigimiz uygulama
    public static string ProdutAdded = "Urun Eklendi";
    public static string ProductNameInvalid = "Urun ismi gecersizdir";
    public static string ProductListed = "Urunler basariyla listelendi";
    public static string MaintenanceTime = "Sunucu suan da bakimda";
}
