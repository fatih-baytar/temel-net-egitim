//Generic collections
List<int> sayilar = new List<int>();
sayilar.Add(0);
sayilar.Add(-255);
sayilar.Add(225);

sayilar.Remove(0);
sayilar.AddRange(new int[] { 15, 25, 100 });
var yirmiBestenBuyukElemanlar = sayilar.Where(x => x >= 25); //Lambda expression.

Console.WriteLine(yirmiBestenBuyukElemanlar.Count());