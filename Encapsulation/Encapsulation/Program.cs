internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Ogrenci ogrenci1 = new Ogrenci(5);
        
        Console.WriteLine(ogrenci1.Yas);
    }
}
class Ogrenci
{
    public Ogrenci(int Yas)
    {
        if (Yas > 0)
        {
            this.Yas = Yas;
        }
        else
        {
            this.Yas = 0;
        }
        
    }
    public int Yas { get; }
}