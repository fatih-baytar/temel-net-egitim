// 10 elemanlı bir sayı dizisi ++
// bu sayıların toplamı
// bu sayıların aritmetik ortalaması. 

//double[] sayilar = new double[10];
//sayilar[0] = 2.3;
//sayilar[1] = 5.8;
//sayilar[2] = 22.4;
//sayilar[3] = 2.327;
//sayilar[4] = -5.2;
//sayilar[5] = 300;
//sayilar[6] = 25;
//sayilar[7] = 62.7;
//sayilar[8] = -22.8;
//sayilar[9] = 63;

//int i = 0;
//double toplam = 0;
//while (i < sayilar.Length)
//{
//    Console.WriteLine(sayilar[i]);
//    toplam += sayilar[i];
//    i++; // i += 1;
//}
//Console.WriteLine("Toplam:" + toplam);
//var aritmetikOrtalama = toplam / sayilar.Length;
//Console.WriteLine("Aritmetik Ortalama:" + aritmetikOrtalama);

int[] sayilar2 = new int[20];

Random rnd = new Random();

for(int i = 0; i < sayilar2.Length; i++)
{
    sayilar2[i] = rnd.Next(0,200);
    Console.Write(sayilar2[i]+" ");
}
int enKucukSayi = sayilar2[0];
int enBuyukSayi = sayilar2[0];
Console.WriteLine();
foreach(int siradakiSayi in sayilar2)
{
    if (siradakiSayi < enKucukSayi)
    {
        enKucukSayi = siradakiSayi;
    }
    if(siradakiSayi > enBuyukSayi)
    {
        enBuyukSayi = siradakiSayi;
    }
}
Console.WriteLine("En Küçük Sayı:"+enKucukSayi);
Console.WriteLine("En Büyük Sayı:" + enBuyukSayi);
// 3 15 25 55 2 8 9 199 0 25 23