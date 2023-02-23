internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var elma1 = new Elma();
        Elma elma2 = new();

        elma1.renk = "Kırmızı";
        elma1.tat = "Tatlı";
        elma2.renk = "Yeşil";
        elma2.tat = "Ekşi";

        elma1.Curu();
        elma2.Curu();

        Console.ReadLine();

    }
}
class Elma
{
    public string renk;
    public string tat;
    public void Curu()
    {
        Console.WriteLine(this.renk+" "+this.tat+ " Elma Çürüyor");
    }
}