internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Ogrenci ogrenci1 = new();
        var deger = ogrenci1.Yas;
        ogrenci1.Yas = -15;
        Console.WriteLine(ogrenci1.Yas);
        
    }
}
class Ogrenci
{
    private int _yas;
    public int Yas
    {
        get
        {

            //Console.WriteLine("Get Çalıştı");
            return _yas;
        }
        set
        {
            if (value < 0)
            {
                _yas = 1;
            }
            else
            {
                _yas = value;
            }
            //Console.WriteLine("Set çalıştı");
        }
    }
}