// See https://aka.ms/new-console-template for more information

using EntityFrameworkDatabaseFirst.Models;

Console.WriteLine("Hello, World!");
//ORM
//EntityFrameworkCore
//Database First --> Scaffolding
//Code First --> Migration

OkulContext context = new OkulContext();
var siniflar = context.Sinifs.ToList();
foreach(var item in siniflar)
{
    Console.WriteLine(item.SinifAd);
}
var ogrenciler = context.Ogrencis.ToList();
foreach(var item in ogrenciler)
{
    Console.WriteLine($"Ad:{item.Firstname} Soyad:{item.Lastname} Sınıf:{item.Sinif?.SinifAd}");
}

var adiFileBaslayanOgrenciler = context.Ogrencis.Where(o => o.Firstname.StartsWith("F")).ToList();
foreach (var item in adiFileBaslayanOgrenciler)
{
    Console.WriteLine($"Id:{item.Id} Ad: {item.Firstname}");
}

