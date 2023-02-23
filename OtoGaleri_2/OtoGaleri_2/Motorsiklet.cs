namespace OtoGaleri_2
{
    public class Motorsiklet : Arac
    {
        public bool YarisMotoMu { get; set; }
        public override string ToString()
        {
            return base.ToString()+" "+YarisMotoMu;
        }
    }
}
