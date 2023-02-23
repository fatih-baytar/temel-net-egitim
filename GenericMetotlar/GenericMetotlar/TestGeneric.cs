using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMetotlar
{
    public class TestGeneric<T,E>
    {
        public T Pro1 { get; set; }
        public E Pro2 { get; set; }

        public override string ToString()
        {
            return Pro1+" "+Pro2;
        }
    }
}
