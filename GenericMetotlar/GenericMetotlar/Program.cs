

using GenericMetotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Hesapla<int>(new List<int> { 3,15,25}));
        Console.WriteLine(Hesapla<double>(new List<double> { 2.5, 2, 8 }));
        Console.WriteLine(Hesapla<object>(new List<object> { "Fatih", false, true, 1, 5 }));

        var testGeneric = new TestGeneric<int, string>();
        testGeneric.Pro1 = 5;
        testGeneric.Pro2 = "Fatih";
        Console.WriteLine(testGeneric);
        
    }
    static double Hesapla<T>(List<T> sayilar)
    {
        if (typeof(T) == typeof(int))
        {
            var toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += Convert.ToInt32(item);
            }
            return toplam;
        }
        else if(typeof(T) == typeof(double))
        {
            var carpim = 1.0;
            foreach (var item in sayilar)
            {
                carpim *= Convert.ToDouble(item);
            }
            return carpim;
        }
        else
        {
            return 0;
        }
    }
}