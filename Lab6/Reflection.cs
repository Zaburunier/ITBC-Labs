using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Reflection
    {
        public Reflection(double d) { }
        public Reflection(int i1, int i2, string s) { }

        public double Product(double x, double y)
        {
            return x * y;
        }

        public string P1 { get; set; }
        public int P2 { get; set; }
        public long P3 { get; set; }
    }
}
