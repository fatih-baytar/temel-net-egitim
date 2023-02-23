namespace AracUygulamasi
{
    public class Arac
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public double Fiyat { get; set; }
        public string OzellikleriDon()
        {
            return "Id:" + Id + " Marka:" + Marka + " Fiyat:" + Fiyat;
        }
    }
}
