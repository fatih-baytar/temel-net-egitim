// See https://aka.ms/new-console-template for more information
using ExtensionMetot;

Console.WriteLine("Hello, World!");
string url = "Çarşamba Günü Yapılan İşlemler";
//url = url.Replace("Ç", "C").Replace("ş","s");
url = url.TurkceKarakterTemizle();
Console.WriteLine(url);

