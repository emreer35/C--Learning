using System;
using Core.Entitites.Concrete;

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
    public static string ProductCountError = "Kategoride en fazla 10 urun bulunabilir";
    public static string ProductNameExist = "Bu Urun ismi mevcut";
    public static string CategoryLimitExceded = "Kategori Sayisi fazla oldugundan urun eklenemez";
    public static string? AuthorizationDenied = "Dogrulama hatasi";
    public static string UserRegistered = "Kullanici kaydi basarili";
    public static string UserNotFound = "Kullanici Bulunamadi";
    public static string PasswordError = "Hatali sifre girdiniz";
    public static string SuccessfulLogin = "Oturum acma islemi basarili";
    public static string UserAlreadyExists = "Bu kullanici zaten kayitli";
    public static string AccessTokenCreated ="Token Olusturuldu";
}
