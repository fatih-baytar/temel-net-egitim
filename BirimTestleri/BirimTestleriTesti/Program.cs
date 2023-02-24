// See https://aka.ms/new-console-template for more information
using BirimTestleri;

Console.WriteLine("Hello, World!");
DortIslem dortIslem = new DortIslem();
var sonuc = dortIslem.Topla(3, 5);
if(sonuc == 8)
{
    Console.WriteLine("Testten geçti"); //passed
}
else
{
    Console.WriteLine("Testten kaldı"); //fail
}