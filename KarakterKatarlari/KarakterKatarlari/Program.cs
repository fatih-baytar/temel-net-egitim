internal class Program
{
    private static void Main(string[] args)
    {
        string benimAdim = "Ali"; //Karakter dizisi
        Console.WriteLine(benimAdim[benimAdim.Length-1]);
        int sonuc = benimAdim.IndexOf("c"); //Aradığı ifadeyi bulursa ilk indexini, bulamazsa -1
        if(sonuc == -1)
        {
            Console.WriteLine("Bulunamadı");
        }
        else
        {
            Console.WriteLine("Bulunan ilk index:" + sonuc);
        }

        string benimTumAdim = "Fatih BAYTAR";
        string soyad = benimTumAdim.Substring(6,3);
        Console.WriteLine(soyad);
        bool aIleMiBasliyor= benimTumAdim.StartsWith('A');
        Console.WriteLine(aIleMiBasliyor);
        bool bIleMiBitiyor = benimTumAdim.EndsWith("B");
        Console.WriteLine(bIleMiBitiyor);
        string silinen = benimTumAdim.Remove(5);
        Console.WriteLine(silinen);
        Console.WriteLine(benimTumAdim);
        string degisimSonucu = benimTumAdim.Replace(' ', '-');
        Console.WriteLine(degisimSonucu);
        bool aIceriyorMu= benimTumAdim.Contains('a');
        Console.WriteLine(aIceriyorMu);
        string tireEkle = benimTumAdim.Insert(0, "-");
        Console.WriteLine(tireEkle);
        string bosluklarSilinmis = benimTumAdim.Trim();
        Console.WriteLine(bosluklarSilinmis);
        //benimTumAdim.TrimEnd();
        string hepsiBuyuk = benimTumAdim.ToUpper();
        Console.WriteLine(hepsiBuyuk);
        string hepsiKucuk = benimTumAdim.ToLower();
        Console.WriteLine(hepsiKucuk);
        string[] parcalar = benimTumAdim.Split(" ");
        foreach (var parca in parcalar)
        {
            Console.WriteLine(parca);
        }


    }
}