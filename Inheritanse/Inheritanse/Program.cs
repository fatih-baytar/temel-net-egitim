using System.Diagnostics.SymbolStore;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Otomobil otomobil1 = new Otomobil();
        otomobil1.Id = 1;
        otomobil1.Marka = "Mercedes";
        otomobil1.Model = "2015";
        otomobil1.KlimaVarMi = true;
        Otobus otobus1 = new Otobus();
        otobus1.Id = 2;
        otobus1.Marka = "Iveco";
        otobus1.Model = "2020";
        otobus1.TakografVarMi = false;

        otomobil1.OzellikleriSoyle();
        otobus1.OzellikleriSoyle();
    }
}
class Arac
{
    public int Id { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public virtual void OzellikleriSoyle()
    {
        Console.WriteLine(Id + " " + Marka + " " + Model);
    }
     
}
class Otomobil : Arac
{
    public bool KlimaVarMi { get; set; }
    public override void OzellikleriSoyle()
    {
        Console.WriteLine(Id + " " + Marka + " " + Model + " " + KlimaVarMi);
    }
}
class Otobus : Arac
{
    public bool TakografVarMi { get; set; }
    public override void OzellikleriSoyle()
    {
        Console.WriteLine(Id + " " + Marka + " " + Model + " " + TakografVarMi);
    }
    
}