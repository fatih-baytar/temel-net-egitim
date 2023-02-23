
using AracUygulamasi;

Console.Write("Araç sayısı:");
var girilen = Console.ReadLine();
var elemanSayisi = Convert.ToInt32(girilen);
Arac[] araclar = new Arac[elemanSayisi];

for (int i = 0;i < araclar.Length; i++)
{
    araclar[i] = new Arac();
    araclar[i].Id = i + 1;
    Console.Write((i+1)+". aracın markasını girin:");
    var marka = Console.ReadLine();
    araclar[i].Marka = marka;
    Console.Write((i + 1) + ". aracın fiyatını girin:");
    var fiyat = Console.ReadLine();
    araclar[i].Fiyat =Convert.ToDouble(fiyat);
}

Console.WriteLine("***************************");
foreach(var siradakiArac in araclar)
{
    Console.WriteLine(siradakiArac.OzellikleriDon());
}