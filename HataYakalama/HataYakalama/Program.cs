// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Lütfen Yaşınızı Girin:");
try
{
    var girilen = Console.ReadLine();
    var yas = Convert.ToInt32(girilen);
    Console.WriteLine(yas + 10);
    Console.WriteLine(10 / yas);
}
catch(FormatException ex)
{
    Console.WriteLine("Lütfen sayısal değer girin:");
}
catch(NullReferenceException exp)
{

}
catch(Exception exp)
{
    Console.WriteLine("Genel Özel durum:" + exp.Message);
}
finally
{
    //Hata olsun ya da olmasın nihayi olarak çalışır.
}
Console.ReadLine();