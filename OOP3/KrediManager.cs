using System;

namespace OOP3;

public interface IKrediManager
{
    // interfaceleri birbirinin alternatifi olan ama kod icerikleri farkli olan durumlar icin kullaniriz
    // bu ornekte kredi turlerinin hepsinde hesaplama vardir fakat icerisinde ki kodlar farklidir
    void Hesapla();
    void BiseyYap();
}
