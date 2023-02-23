internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Topla();
        Carp(2, 5);
        Carp(20, 200);
        double bolum = Bol(10, 3);
        Console.WriteLine("Bölüm:" + bolum);
    }
    //Geriye Değer Döndürmeyen Metot
    static void Topla()
    {
        Console.WriteLine(2 + 3);
    }
    static void Carp(int sayi1,int sayi2)
    {
        Console.WriteLine("Çarpım:"+ (sayi1 * sayi2));
    }
    // Geriye Değer Döndüren Metot

    static double Bol(double sayi1, double sayi2)
    {
        double sonuc = sayi1 / sayi2;
        return sonuc;
    }
}