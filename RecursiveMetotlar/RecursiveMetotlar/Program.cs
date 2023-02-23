internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Faktoriyel(0));
    }
    static int Faktoriyel(int sayi)
    {
        if (sayi < 1) return 1;
        return sayi * Faktoriyel(sayi - 1);
    }
    
}