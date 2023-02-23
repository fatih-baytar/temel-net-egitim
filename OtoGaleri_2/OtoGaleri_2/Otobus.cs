namespace OtoGaleri_2
{
    public class Otobus : Arac
    {
        public bool TakometreVarMi { get; set; }
        public override string ToString()
        {
            return base.ToString()+" "+TakometreVarMi;
        }
    }
}
