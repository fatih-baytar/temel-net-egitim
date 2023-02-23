internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("3 asal mı:" + AsalMi(3));
        Console.WriteLine("24 asal mı:" + AsalMi(24));
        Console.WriteLine("3543 asal mı:" + AsalMi(3543));
    }
    static bool AsalMi(int sayi)
    {
        // 2 = 1,2 //Asal
        // 3 = 1,3 //Asal
        // 4= 1,2,4 //Asal Değil
        // 5 = 1,5 //Asal
        // 6 = 1,2,3,6 //Asal Değil
        bool asalMi = true;

        for (int i = 2; i < sayi; i++)
        {
            if (sayi % i == 0)
            {
                asalMi = false;
                Console.WriteLine(i);
                break;
            }
        }
        return asalMi;
    }
}