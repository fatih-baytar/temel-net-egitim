internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Arac arac1 = new Arac(); //Abstract sınıflardan instance alınamaz. 
        Otomobil otomobil = new Otomobil();
        otomobil.Id = 1;
    }
}
abstract class Arac
{
    public int Id { get; set; }
    public virtual void OzellikleriSoyle()
    {

    }
    public abstract void OzellikleriEkle();
}
class Otomobil : Arac
{
    public override void OzellikleriEkle()
    {
        throw new NotImplementedException();
    }
}