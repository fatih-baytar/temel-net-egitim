
DateTime suAn = DateTime.Now;
Console.WriteLine("Yıl:"+ suAn.Year);
Console.WriteLine("Ay:" + suAn.Month);
Console.WriteLine("Gün:" + suAn.Day);
DateTime yeniTarih = suAn.AddDays(-2);
Console.WriteLine(yeniTarih);
Console.WriteLine(yeniTarih.ToLongDateString());
Console.WriteLine(yeniTarih.ToLongTimeString());
Console.WriteLine(yeniTarih.ToShortDateString());
Console.WriteLine(yeniTarih.ToShortTimeString());

Console.WriteLine(yeniTarih.ToString("dd.MM.yyyy HH:mm"));