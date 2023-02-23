namespace OtoGaleri_2
{
    public class Otomobil : Arac
    {
        public bool UstuAcilabilirMi { get; set; }
        public override string ToString()
        {
            return base.ToString()+" "+UstuAcilabilirMi;
        }

    }
}
