internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        IInsan insan1 = new Ogrenci();
        IInsan insan2 = new Ogretmen();
        IInsan[] insanlar = new IInsan[50];
        insanlar[0] = new Ogrenci();
        insanlar[1] = new Ogretmen();
    }
}
public interface IInsan
{
    public int Id { get; set; }
}
public class Ogrenci : IInsan
{
    public int Id { get; set; }
}
public class Ogretmen : IInsan
{
    public int Id { get; set; }
}
