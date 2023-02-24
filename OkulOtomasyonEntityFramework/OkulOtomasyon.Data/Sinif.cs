using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyon.Data
{
    public class Sinif
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int? Kapasite { get; set; }
        public bool? AktifMi { get; set; }
    }
}
