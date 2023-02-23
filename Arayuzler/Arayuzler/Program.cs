internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //IArac arac1 = new IArac();
    }
}
public abstract class Motor
{

}
public interface IKlima
{

}
public interface IArac
{
    public int Id { get; set; }
    public void OzellikleriGoster();
}
class Otomobil : Motor, IKlima, IArac
{
    public int Id { get; set; }

    public void OzellikleriGoster()
    {
        Console.WriteLine();
    }
}