using Metotlar;



Hasta hasta1 = new Hasta();
hasta1.HastaAdi = "Yunus Emre";
hasta1.TcNo = "20202020200220";
hasta1.Yas = 24;
Hasta hasta2 = new Hasta();
hasta2.HastaAdi = "Sueda Er";
hasta2.TcNo = "20202020200220";
hasta2.Yas = 22;

Hasta[] hastalar = new Hasta[] { hasta1, hasta2 };

foreach (var hasta in hastalar)
{
    System.Console.WriteLine(hasta.HastaAdi + " " + hasta.Yas + "-" + hasta.TcNo);
}
System.Console.WriteLine("==============METOTLAR============");

HastaManager manager = new HastaManager();

manager.SaveHasta(hasta1);
manager.SaveHasta(hasta2);

// Encapsualtion mantigi sudur 
// simdi eger ben save metodunu degistirirsem heryerde ki save metodunu degistirmem lazim 
// ama SaveHasta metodunda ki gibi degstirirsem sadece hastalarin tanimladigim yerde ki yerini 
// degistirmem yetiyor 
// save metoduna aciklama ekliyorum save metodu hata veriyor 
// her sayfada ki save metodunu degistirmem gerekyior
// gidip hasta.cs e aciklama eklersem savehasta metodu hata vermiyor
manager.Save("yunus emre", "12312313123", 13, "asfasdg");
manager.Save("yunus emre", "12312313123", 13, "asfajlkgdsg");





