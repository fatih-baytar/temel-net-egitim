// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var dogumGunu = new DogumGunu();
dogumGunu.Gun = Gunler.Pazartesi;

public enum Gunler
{
    Pazartesi=2, Sali=5, Carsamba, Persembe, Cuma, Cumartesi, Pazar
}
public class DogumGunu
{
    public Gunler Gun { get; set; }
}