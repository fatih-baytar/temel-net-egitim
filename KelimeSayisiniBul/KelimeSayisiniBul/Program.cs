// Boşluklu olarak girilen bir uzun ifadede kaç tane kelime var. 

Console.Write("Cümleyi Girin:");
var girilenCumle = Console.ReadLine(); 
string[] parcalar = girilenCumle.Split(' ');
Console.WriteLine();
Console.WriteLine(parcalar.Length);

