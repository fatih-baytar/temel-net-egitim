// See https://aka.ms/new-console-template for more information
//Yorum Satırı
/* 
 * Çoklu
 * Yorum
 * Satırı
 * 
 * 
 * 
 * 
 */

// C# güçlü tip özelliklerine sahiptir. Değişkenin tipini de söylemek zorundasınız. 

int degiskenAd; //Tanımlama işlemi. //CamelCase
//int degiskenad; // C# CaseSensitive //Büyük harf küçük harf duyarlılığı var. 
//int degiskenAd; //izin vermez. 

degiskenAd = 10;
//Console.WriteLine(degiskenAd);
degiskenAd = 25;
//Console.WriteLine(degiskenAd);


//int 1Degisken = -25;  //hata değişken isimleri sayısal ifadelerle başlayamaz. 
//int class = 222; //C#'ın kendisine ayırdığı özel ifadeleri değişken ismi olarak kullanamayız. 
//int sayi bes = 0; //değişken ismi boşluklu olamaz. 

int sayi1 = -255;

//1-Sayısal Değişken Tipleri
// Tam
byte sayi2 = 255; //256 tane değer alır.  //unsigned
Console.WriteLine(byte.MinValue);
Console.WriteLine(byte.MaxValue);
Console.WriteLine("---------------");
Console.WriteLine(sbyte.MinValue);
Console.WriteLine(sbyte.MaxValue);
short sayi3 = 256;
Console.WriteLine(short.MinValue); //signed
Console.WriteLine(short.MaxValue);
Console.WriteLine("--------------");
Console.WriteLine(ushort.MinValue);
Console.WriteLine(ushort.MaxValue);
int sayi4 = 222222;
Console.WriteLine(int.MinValue);
Console.WriteLine(int.MaxValue);

long sayi5 = -2233;
Console.WriteLine(long.MinValue);
Console.WriteLine(long.MaxValue);


//Ondalıklı
float sayi6 = 23.5f;
Console.WriteLine(float.MinValue);
Console.WriteLine(float.MaxValue);
Console.WriteLine(double.MinValue);
Console.WriteLine(double.MaxValue);
Console.WriteLine(decimal.MinValue);
Console.WriteLine(decimal.MaxValue);

//2-Karakter Değişken Tipleri
char karakter1 = 'A';

string karakter2 = "Temel .NET Eğitimleri ' Yeni Satır";
Console.WriteLine(karakter2);
//3-Mantıksal Değişken Tipleri
bool ifade = true;
bool ifade2 = false;
//4-Diğer
DateTime tarih = DateTime.Now;
Console.WriteLine(tarih);
DateTime tarih2 = new DateTime(1988, 2, 1);
Console.WriteLine(tarih2);


object nesne = 'A'; //Bütün tiplerin atasıdır.
nesne = "Bu bir object";
nesne = 3;
Console.ReadLine();