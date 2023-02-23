
int deger1 = 5;
short deger2 = 200;

deger1 = deger2; //Implicitly Tür Dönüşümü

double deger3 = deger2;

long deger4 = -200;
deger1 = Convert.ToInt32(deger4); //Explicitly Tür Dönüşümü

string ifade = "w30";
//Console.WriteLine("3" < "5");
int deger5 = Convert.ToInt32(ifade);
Console.WriteLine(deger5 < 10);

Console.ReadLine();
