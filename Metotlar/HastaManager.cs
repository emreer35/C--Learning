using System;

namespace Metotlar
{
    class HastaManager
    {
        public void SaveHasta(Hasta hasta)
        {
            Console.WriteLine("Hasta Kayit Islemi Yapildi: " + hasta.HastaAdi);
        }
        public void Save(string ad, string tcNo, int yas, string aciklama)
        {
            Console.WriteLine("Hasta Kayit Islemi Yapildi: " + ad);
        }
    }
}