

using OtoGaleri_2;

List<Arac> araclar = new List<Arac>();

Console.WriteLine("Lütfen bilgileri girin AracTuru(1,2,3)|Marka|TipeOzelÖzellik (Çıkmak için Ç yazın):");
//1|Mercedes|E
//2|Iveco|H
//3|Suzuki|E
var id = 1;
while (true)
{
    var girilen = Console.ReadLine();
    if (girilen == "Ç") break;
    var parcalar = girilen.Split("|");
    if (parcalar[0] == "1")
    {
        var otomobil = new Otomobil();
        otomobil.Marka = parcalar[1];
        otomobil.UstuAcilabilirMi = parcalar[2] == "E" ? true : false;
        otomobil.Id= id;
        araclar.Add(otomobil);
    }
    else if (parcalar[0] == "2")
    {
        var otobus = new Otobus();
        otobus.Marka = parcalar[1];
        otobus.TakometreVarMi = parcalar[2] == "E" ? true : false;
        otobus.Id= id;
        araclar.Add(otobus);
    }
    else
    {
        var motorsiklet = new Motorsiklet();
        motorsiklet.Marka = parcalar[1];
        motorsiklet.YarisMotoMu = parcalar[2] == "E" ? true : false;
        motorsiklet.Id= id;
        araclar.Add(motorsiklet);
    }
    id++;
}
Console.WriteLine("***************************");
foreach(var arac in araclar)
{
    Console.WriteLine(arac.ToString());
}