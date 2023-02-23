internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        var araba1 = new Araba(1, "Mercedes");
        Console.WriteLine(araba1.Id + ":" + araba1.Marka);
        var araba2 = new Araba();

        DortIslem(5, 3);
    }
    static void DortIslem(int sayi1, int sayi2)
    {
        Console.WriteLine("2 parametreli metot çalıştı");
    }
    static void DortIslem(double sayi1, double sayi2, double sayi3)
    {
        Console.WriteLine("3 parametreli metot çalıştı");
    }
}
class Araba
{
    public int Id { get; set; }
    public string Marka { get; set; }
    public Araba(int Id, string Marka)
    {
        Console.WriteLine("2 parametreli Yapıcı Metot Çalıştı");
        this.Id = Id;
        this.Marka = Marka;
    }
    public Araba()
    {
        Console.WriteLine("Parametresiz Yapıcı Metot Çalıştı");
    }

}