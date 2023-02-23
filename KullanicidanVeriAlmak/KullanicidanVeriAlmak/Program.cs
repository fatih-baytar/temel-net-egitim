


Console.WriteLine("Yaşınız Nedir?");
string okunanDeger = Console.ReadLine();
Console.WriteLine("Girdiğiniz Değer:" + okunanDeger);
int yas = Convert.ToInt32(okunanDeger);
if(yas < 18)
{
    Console.WriteLine("Bu siteye girişiniz yok");
}
else
{
    Console.WriteLine("Hoşgeldiniz");
}

