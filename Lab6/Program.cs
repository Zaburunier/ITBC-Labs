using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №6. Забурунов Леонид, РТ5-31-2019";
            Del delegate1 = new Del(Delegates.Product);

            Console.WriteLine(delegate1.Invoke(16, 32, "2"));
            Delegates.ProductGetsDelegate(3.1, 16, 32, "2", delegate1);
            Delegates.ProductGetsDelegate(3.1, 16, 32, "2", (x1, x2, x3) => x1 * x2 * Convert.ToInt32(x3));
            Delegates.ProductGetsDelegate_Gen(3.1, 16, 32, "2", Delegates.Product);
            Delegates.ProductGetsDelegate_Gen(3.1, 16, 32, "2", (x1, x2, x3) => x1 * x2 * Convert.ToInt32(x3));



            Console.ReadKey();
        }
    }
}
