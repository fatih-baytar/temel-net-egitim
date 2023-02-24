// See https://aka.ms/new-console-template for more information
using EntityframeworkCodeFirst.Models;

Console.WriteLine("Hello, World!");

HastaneContext context = new HastaneContext();

var yeniDoktor = new Doktor { Ad = "Mehmet", Soyad = "Selim" };
context.Doktorlar.Add(yeniDoktor);
var result = context.SaveChanges();
Console.WriteLine();
var tumDoktorlar = context.Doktorlar.ToList();
foreach (var doktor in tumDoktorlar)
{
    Console.WriteLine($"Id:{doktor.Id} Ad:{doktor.Ad} {doktor.Soyad}");
}