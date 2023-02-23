
//File.AppendAllLines("ogrenciler.txt", new List<string> { "Fatih BAYTAR", "Selim Güneş", "Tuba Saday" });
var ogrenciler = File.ReadAllLines("ogrenciler.txt");
foreach (var line in ogrenciler)
{
    Console.WriteLine(line);
}

