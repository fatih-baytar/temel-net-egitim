using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkCodeFirst.Models
{
    public class Doktor
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Ad { get; set; }
        [StringLength(100)]
        public string Soyad { get; set; }
        public int? Yas { get; set; }

    }
}
