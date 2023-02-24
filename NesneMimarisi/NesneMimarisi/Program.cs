// See https://aka.ms/new-console-template for more information
using NesneMimarisi;

Console.WriteLine("Hello, World!");
Ogrenci o1 = new Ogrenci();
o1.Id = 1;
o1.Name = "Fatih";
Console.WriteLine(o1.Id + " " + o1.Name);
Ogrenci o2 = o1;
o2.Id = 2;
o2.Name = "Mehmet";
Console.WriteLine(o1.Id + " " + o1.Name);
