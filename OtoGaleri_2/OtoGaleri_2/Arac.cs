using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleri_2
{
    public class Arac
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public override string ToString()
        {
            return Id+" "+Marka;
        }
    }
}
