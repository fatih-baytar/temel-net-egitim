using Microsoft.EntityFrameworkCore;
using OkulOtomasyon.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        SinifEkle();
        OgrenciEkle();
        OgrencileriListele();
        OgrenciSil();
    }
    public static void SinifEkle()
    {
        var context = new OkulContext();
        //CRUD = Create, Read, Update, Delete
        Console.Write("Sınıf bilgisi girin(Ad|Kapasite|aktifMi(E/H)):");
        var girilen = Console.ReadLine();
        var parcalar = girilen.Split('|');
        var sinifAd = parcalar[0];
        var sinif = context.Sinifs.FirstOrDefault(s => s.Ad == sinifAd);
        if (sinif == null)
        {
            //Yeni Bir sinif ekle.
            var yeniSinif = new Sinif();
            yeniSinif.Ad = sinifAd;
            yeniSinif.Kapasite = Convert.ToInt32(parcalar[1]);
            yeniSinif.AktifMi = parcalar[2] == "E" ? true : false;
            context.Sinifs.Add(yeniSinif);
            context.SaveChanges();
        }
        else
        {
            //Bu sınıfın verilerini güncelle. 
            sinif.Kapasite = Convert.ToInt32(parcalar[1]);
            sinif.AktifMi = parcalar[2] == "E" ? true : false;
            context.SaveChanges();
        }
    }
    public static void OgrenciEkle()
    {
        var context = new OkulContext();
        foreach (var sinif in context.Sinifs)
        {
            Console.WriteLine($"SinifId:{sinif.Id} Kapasite:{sinif.Kapasite} Aktif Mi:{sinif.AktifMi}");
        }
        Console.Write("Ogrenci bilgilerini girin (Ad|Soyad|SinifId):");
        var parcalar = Console.ReadLine().Split("|");
        var yeniOgrenci = new Ogrenci();
        yeniOgrenci.Ad = parcalar[0];
        yeniOgrenci.Soyad = parcalar[1];
        yeniOgrenci.SinifId = Convert.ToInt32(parcalar[2]);
        context.Ogrencis.Add(yeniOgrenci);
        context.SaveChanges();
    }
    public static void OgrencileriListele()
    {
        var context = new OkulContext();
        Console.WriteLine("**********************");
        foreach (var ogrenci in context.Ogrencis.Include(o=>o.Sinif))
        {
            Console.WriteLine(ogrenci);
        }
    }
    public static void OgrenciSil()
    {
        var context = new OkulContext();
        Console.Write("Silmek istediğiniz öğrencinin Id:");
        var silinecekOgrenciId = Convert.ToInt32(Console.ReadLine());
        var ogrenci = context.Ogrencis.FirstOrDefault(o=>o.Id== silinecekOgrenciId);
        if (ogrenci == null)
            Console.WriteLine("Böyle bir öğrenci yok");
        context.Ogrencis.Remove(ogrenci);
        context.SaveChanges();
        OgrencileriListele();
    }
}