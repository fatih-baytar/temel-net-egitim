

using TurDonusumu;

Arac arac1 = new Arac { Id = 1, Marka = "Fiat" };
object nesne1 = arac1;
//nesne1 = "Fatih";

Arac arac2 = (Arac)nesne1; //Type Casting.
Console.WriteLine(arac2.Marka);
Arac arac3 = nesne1 as Arac; //Hata fırlatmaz (Yapamıyorsa null değeri ataması yapar).

Console.WriteLine(arac3.Marka);

nesne1 = "Fatih";
bool aracaDonusebilirMi = nesne1 is Arac;
Console.WriteLine(aracaDonusebilirMi);