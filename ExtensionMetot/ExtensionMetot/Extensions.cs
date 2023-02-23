using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMetot
{
    public static class Extensions
    {
        public static string TurkceKarakterTemizle(this string value)
        {
            return value.Replace("Ç", "C").Replace(" ", "-").Replace("ş", "s").Replace("ç", "c");
        }
    }
}
