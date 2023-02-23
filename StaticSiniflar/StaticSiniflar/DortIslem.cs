

namespace StaticSiniflar
{
    public static class DortIslem
    {
        public static double Pi = 3.14;
        public static double Topla(double x, double y)
        {
            return x + y;
        }
        public static double Carp(double x, double y)
        {
            return x * y;
        }
        public static double Carp(double[] sayilar)
        {
            double carpim = 1;
            foreach (double siradakiSayi in sayilar)
            {
                carpim *= siradakiSayi;
            }
            return carpim;
        }
    }
}
