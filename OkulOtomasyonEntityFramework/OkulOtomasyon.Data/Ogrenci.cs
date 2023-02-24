using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyon.Data
{
    public class Ogrenci
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Ad { get; set; }
        [StringLength(100)]
        public string Soyad { get; set; }
        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }

        public override string ToString()
        {
            return $"Id:{this.Id} Ad:{this.Ad} Soyad:{this.Soyad} Sinif:{this.Sinif?.Ad}";
        }
    }
}
